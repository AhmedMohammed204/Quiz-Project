using System;
using System.Data;
using AdminsDataAccessLayer;
namespace AdminsBusinessLayer
{

    public class clsAdmin
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int AdminID { get; set; }
        public int UserID { get; set; }
        public int TotalAddedQuestions { get; set; }


        public clsAdmin()
        {
            this.AdminID = default;
            this.UserID = default;
            this.TotalAddedQuestions = default;


            Mode = enMode.AddNew;

        }

        private clsAdmin(int AdminID, int UserID, int TotalAddedQuestions)
        {
            this.AdminID = AdminID;
            this.UserID = UserID;
            this.TotalAddedQuestions = TotalAddedQuestions;


            Mode = enMode.Update;

        }

        private bool _AddNewAdmin()
        {
            //call DataAccess Layer 

            this.AdminID = clsAdminsDataAccess.AddNewAdmin(this.UserID, this.TotalAddedQuestions);

            return (this.AdminID != -1);

        }

        private bool _UpdateAdmin()
        {
            //call DataAccess Layer 

            return clsAdminsDataAccess.UpdateAdmin(this.AdminID, this.UserID, this.TotalAddedQuestions);

        }

        public static clsAdmin Find(int AdminID)
        {
            int UserID = default;
            int TotalAddedQuestions = default;


            if (clsAdminsDataAccess.GetAdminInfoByID(AdminID, ref UserID, ref TotalAddedQuestions))
                return new clsAdmin(AdminID, UserID, TotalAddedQuestions);
            else
                return null;

        }
        
        public static clsAdmin FindByUserID(int UserID)
        {
            int AdminID = default;
            int TotalAddedQuestions = default;


            if (clsAdminsDataAccess.GetAdminInfoByUserID(ref AdminID, ref UserID, ref TotalAddedQuestions))
                return new clsAdmin(AdminID, UserID, TotalAddedQuestions);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAdmin())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateAdmin();

            }




            return false;
        }

        public static DataTable GetAllAdmins() { return clsAdminsDataAccess.GetAllAdmins(); }

        public static bool DeleteAdmin(int AdminID) { return clsAdminsDataAccess.DeleteAdmin(AdminID); }

        public static bool isAdminExist(int AdminID) { return clsAdminsDataAccess.IsAdminExist(AdminID); }

        
        public static bool isAdminExistByUserID(int UserID) { return clsAdminsDataAccess.IsAdminExist(UserID); }


    }

}