using System;
using System.Data;
using UsersDataAccessLayer;
namespace UsersBusinessLayer
{

    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int TotalAnswers { get; set; }
        public int TotalRightAnswers { get; set; }


        public clsUser()
        {
            this.UserID = default;
            this.FirstName = default;
            this.Username = default;
            this.Password = default;
            this.TotalAnswers = default;
            this.TotalRightAnswers = default;


            Mode = enMode.AddNew;

        }

        private clsUser(int UserID, string FirstName, string Username, string Password, int TotalAnswers, int TotalRightAnswers)
        {
            this.UserID = UserID;
            this.FirstName = FirstName;
            this.Username = Username;
            this.Password = Password;
            this.TotalAnswers = TotalAnswers;
            this.TotalRightAnswers = TotalRightAnswers;


            Mode = enMode.Update;

        }

        private bool _AddNewUser()
        {
            //call DataAccess Layer 

            this.UserID = clsUsersDataAccess.AddNewUser(this.FirstName, this.Username, this.Password, this.TotalAnswers, this.TotalRightAnswers);

            return (this.UserID != -1);

        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUsersDataAccess.UpdateUser(this.UserID, this.FirstName, this.Username, this.Password, this.TotalAnswers, this.TotalRightAnswers);

        }

        public static clsUser Find(int UserID)
        {
            string FirstName = default;
            string Username = default;
            string Password = default;
            int TotalAnswers = default;
            int TotalRightAnswers = default;


            if (clsUsersDataAccess.GetUserInfoByID(UserID, ref FirstName, ref Username, ref Password, ref TotalAnswers, ref TotalRightAnswers))
                return new clsUser(UserID, FirstName, Username, Password, TotalAnswers, TotalRightAnswers);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }




            return false;
        }

        public static DataTable GetAllUsers() { return clsUsersDataAccess.GetAllUsers(); }

        public static bool DeleteUser(int UserID) { return clsUsersDataAccess.DeleteUser(UserID); }

        public static bool isUserExist(int UserID) { return clsUsersDataAccess.IsUserExist(UserID); }



        public static bool isUserExist(string Username) { return clsUsersDataAccess.IsUserExist(Username); }


        public static clsUser Find(string Username)
        {
            string FirstName = default;
            int UserID = default;
            string Password = default;
            int TotalAnswers = default;
            int TotalRightAnswers = default;


            if (clsUsersDataAccess.GetUserInfoByUsername(ref UserID, ref FirstName, ref Username, ref Password, ref TotalAnswers, ref TotalRightAnswers))
                return new clsUser(UserID, FirstName, Username, Password, TotalAnswers, TotalRightAnswers);
            else
                return null;

        }

    }

}