using System;
using System.Data;
using OptionsDataAccessLayer;
namespace OptionsBusinessLayer
{

    public class clsOption
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int OptionID { get; set; }
        public string Name { get; set; }


        public clsOption()
        {
            this.OptionID = default;
            this.Name = default;


            Mode = enMode.AddNew;

        }

        private clsOption(int OptionID, string Name)
        {
            this.OptionID = OptionID;
            this.Name = Name;


            Mode = enMode.Update;

        }

        private bool _AddNewOption()
        {
            //call DataAccess Layer 

            this.OptionID = clsOptionsDataAccess.AddNewOption(this.Name);

            return (this.OptionID != -1);

        }

        private bool _UpdateOption()
        {
            //call DataAccess Layer 

            return clsOptionsDataAccess.UpdateOption(this.OptionID, this.Name);

        }

        public static clsOption Find(int OptionID)
        {
            string Name = default;


            if (clsOptionsDataAccess.GetOptionInfoByID(OptionID, ref Name))
                return new clsOption(OptionID, Name);
            else
                return null;

        }
        
        public static clsOption Find(string Name)
        {
            int OptionID = default;


            if (clsOptionsDataAccess.GetOptionInfoByName(ref OptionID, ref Name))
                return new clsOption(OptionID, Name);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewOption())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateOption();

            }




            return false;
        }

        public static DataTable GetAllOptions() { return clsOptionsDataAccess.GetAllOptions(); }

        public static bool DeleteOption(int OptionID) { return clsOptionsDataAccess.DeleteOption(OptionID); }

        public static bool isOptionExist(int OptionID) { return clsOptionsDataAccess.IsOptionExist(OptionID); }


    }

}