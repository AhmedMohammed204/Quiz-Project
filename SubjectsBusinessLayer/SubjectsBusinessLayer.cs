using System;
using System.Data;
using SubjectsDataAccessLayer;
namespace SubjectsBusinessLayer
{

    public class clsSubject
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int SubjectID { get; set; }
        public string Name { get; set; }


        public clsSubject()
        {
            this.SubjectID = default;
            this.Name = default;


            Mode = enMode.AddNew;

        }

        private clsSubject(int SubjectID, string Name)
        {
            this.SubjectID = SubjectID;
            this.Name = Name;


            Mode = enMode.Update;

        }

        private bool _AddNewSubject()
        {
            //call DataAccess Layer 

            this.SubjectID = clsSubjectsDataAccess.AddNewSubject(this.Name);

            return (this.SubjectID != -1);

        }

        private bool _UpdateSubject()
        {
            //call DataAccess Layer 

            return clsSubjectsDataAccess.UpdateSubject(this.SubjectID, this.Name);

        }

        public static clsSubject Find(int SubjectID)
        {
            string Name = default;


            if (clsSubjectsDataAccess.GetSubjectInfoByID(SubjectID, ref Name))
                return new clsSubject(SubjectID, Name);
            else
                return null;

        }
        
        public static clsSubject Find(string Name)
        {
            int SubjectID = default;


            if (clsSubjectsDataAccess.GetSubjectInfoByName(ref SubjectID, ref Name))
                return new clsSubject(SubjectID, Name);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubject())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateSubject();

            }




            return false;
        }

        public static DataTable GetAllSubjects() { return clsSubjectsDataAccess.GetAllSubjects(); }

        public static bool DeleteSubject(int SubjectID) { return clsSubjectsDataAccess.DeleteSubject(SubjectID); }

        public static bool isSubjectExist(int SubjectID) { return clsSubjectsDataAccess.IsSubjectExist(SubjectID); }


    }

}