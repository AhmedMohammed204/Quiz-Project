using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QuestionsDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=.;Database=QuizDB;User Id=sa;Password=sa123456;";
    }

    public static class clsQuestionsDataAccess
    {
        public static bool GetQuestionInfoByID(int QuestionID, ref int AdminID, ref int SubjectID, ref int RightAnswerID, ref byte[] Image, ref byte[] ExplainImage, ref DateTime Date)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Questions WHERE QuestionID = @QuestionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@QuestionID", QuestionID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    QuestionID = (int)reader["QuestionID"];
                    AdminID = (int)reader["AdminID"];
                    SubjectID = (int)reader["SubjectID"];
                    RightAnswerID = (int)reader["RightAnswerID"];
                    Image = (byte[])reader["Image"];
                    ExplainImage = reader["ExplainImage"] != DBNull.Value ? (byte[])reader["ExplainImage"] : ExplainImage = default;
                    Date = (DateTime)reader["Date"];

                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;

        }
        
        public static bool GetRandomQuestionInfo(ref int QuestionID, ref int AdminID, ref int SubjectID, ref int RightAnswerID, ref byte[] Image, ref byte[] ExplainImage, ref DateTime Date, byte Subject = 1)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 * from Questions WHERE SubjectID = @Subject order by NEWID();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Subject", Subject);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    QuestionID = (int)reader["QuestionID"];
                    AdminID = (int)reader["AdminID"];
                    SubjectID = (int)reader["SubjectID"];
                    RightAnswerID = (int)reader["RightAnswerID"];
                    Image = (byte[])reader["Image"];
                    ExplainImage = reader["ExplainImage"] != DBNull.Value ? (byte[])reader["ExplainImage"] : ExplainImage = default;
                    Date = (DateTime)reader["Date"];

                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;

        }


        public static int AddNewQuestion(int AdminID, int SubjectID, int RightAnswerID, byte[] Image, byte[] ExplainImage, DateTime Date)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Questions VALUES (@AdminID, @SubjectID, @RightAnswerID, @Image, @ExplainImage, @Date)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@AdminID", AdminID);

            command.Parameters.AddWithValue("@SubjectID", SubjectID);

            command.Parameters.AddWithValue("@RightAnswerID", RightAnswerID);

            command.Parameters.AddWithValue("@Image", Image);

            if (ExplainImage== null)
                command.Parameters.Add("@ExplainImage", SqlDbType.VarBinary, -1).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@ExplainImage", ExplainImage);
            command.Parameters.AddWithValue("@Date", Date);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine(Error:  + ex.Message);
                

            }

            finally
            {
                connection.Close();
            }


            return ID;

        }
        public static bool UpdateQuestion(int QuestionID, int AdminID, int SubjectID, int RightAnswerID, byte[] Image, byte[] ExplainImage, DateTime Date)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Questions
	SET	AdminID = @AdminID,
	SubjectID = @SubjectID,
	RightAnswerID = @RightAnswerID,
	Image = @Image,
	ExplainImage = @ExplainImage,
	Date = @Date	WHERE QuestionID = @QuestionID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@QuestionID", QuestionID);

            command.Parameters.AddWithValue("@AdminID", AdminID);

            command.Parameters.AddWithValue("@SubjectID", SubjectID);

            command.Parameters.AddWithValue("@RightAnswerID", RightAnswerID);

            command.Parameters.AddWithValue("@Image", Image);

            if (ExplainImage == null)
                command.Parameters.Add("@ExplainImage", SqlDbType.VarBinary, -1).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@ExplainImage", ExplainImage);
            command.Parameters.AddWithValue("@Date", Date);


            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteQuestion(int QuestionID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE Questions WHERE QuestionID = @QuestionID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@QuestionID", QuestionID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsQuestionExist(int QuestionID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Questions WHERE QuestionID= @QuestionID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@QuestionID", QuestionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return isFound;

        }

        public static DataTable GetAllQuestions()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Questions";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return dt;
        }


    }

}