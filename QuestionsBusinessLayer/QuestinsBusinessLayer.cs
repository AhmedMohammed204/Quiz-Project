using System;
using System.Data;
using QuestionsDataAccessLayer;
using System.Data.SqlClient;
using System.IO;

namespace QuestionsBusinessLayer
{

    public class clsQuestion
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int QuestionID { get; set; }
        public int AdminID { get; set; }
        public int SubjectID { get; set; }
        public int RightAnswerID { get; set; }
        public byte[] Image { get; set; }
        public byte[] ExplainImage { get; set; }
        public DateTime Date { get; set; }
        
        public clsQuestion()
        {
            this.QuestionID = default;
            this.AdminID = default;
            this.SubjectID = default;
            this.RightAnswerID = default;
            this.Image = default;
            this.ExplainImage = default;
            this.Date = default;


            Mode = enMode.AddNew;

        }

        private clsQuestion(int QuestionID, int AdminID, int SubjectID, int RightAnswerID, byte[] Image, byte[] ExplainImage, DateTime Date)
        {
            this.QuestionID = QuestionID;
            this.AdminID = AdminID;
            this.SubjectID = SubjectID;
            this.RightAnswerID = RightAnswerID;
            this.Image = Image;
            this.ExplainImage = ExplainImage;
            this.Date = Date;


            Mode = enMode.Update;

        }

        private bool _AddNewQuestion()
        {
            //call DataAccess Layer 

            this.QuestionID = clsQuestionsDataAccess.AddNewQuestion(this.AdminID, this.SubjectID, this.RightAnswerID, this.Image, this.ExplainImage, this.Date);

            return (this.QuestionID != -1);

        }

        private bool _UpdateQuestion()
        {
            //call DataAccess Layer 

            return clsQuestionsDataAccess.UpdateQuestion(this.QuestionID, this.AdminID, this.SubjectID, this.RightAnswerID, this.Image, this.ExplainImage, this.Date);

        }

        public static clsQuestion Find(int QuestionID)
        {
            int AdminID = default;
            int SubjectID = default;
            int RightAnswerID = default;
            byte[] Image = null;
            byte[] ExplainImage = null;
            DateTime Date = default;


            if (clsQuestionsDataAccess.GetQuestionInfoByID(QuestionID, ref AdminID, ref SubjectID, ref RightAnswerID, ref Image, ref ExplainImage, ref Date))
                return new clsQuestion(QuestionID, AdminID, SubjectID, RightAnswerID, Image, ExplainImage, Date);
            else
                return null;

        }

        public static clsQuestion GetRandomMathQuestion()
        {
            int QuestionID = default;
            int AdminID = default;
            int SubjectID = default;
            int RightAnswerID = default;
            byte[] Image = null;
            byte[] ExplainImage = null;
            DateTime Date = default;


            if (clsQuestionsDataAccess.GetRandomQuestionInfo(ref QuestionID, ref AdminID, ref SubjectID, ref RightAnswerID, ref Image, ref ExplainImage, ref Date))
                return new clsQuestion(QuestionID, AdminID, SubjectID, RightAnswerID, Image, ExplainImage, Date);
            else
                return null;

        }

        
        public static clsQuestion GetRandomPysicsQuestion()
        {
            int QuestionID = default;
            int AdminID = default;
            int SubjectID = default;
            int RightAnswerID = default;
            byte[] Image = null;
            byte[] ExplainImage = null;
            DateTime Date = default;


            if (clsQuestionsDataAccess.GetRandomQuestionInfo(ref QuestionID, ref AdminID, ref SubjectID, ref RightAnswerID, ref Image, ref ExplainImage, ref Date, 2))
                return new clsQuestion(QuestionID, AdminID, SubjectID, RightAnswerID, Image, ExplainImage, Date);
            else
                return null;

        }

        
        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewQuestion())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateQuestion();

            }




            return false;
        }

        public static DataTable GetAllQuestions() { return clsQuestionsDataAccess.GetAllQuestions(); }

        public static bool DeleteQuestion(int QuestionID) { return clsQuestionsDataAccess.DeleteQuestion(QuestionID); }

        public static bool isQuestionExist(int QuestionID) { return clsQuestionsDataAccess.IsQuestionExist(QuestionID); }


    }

}