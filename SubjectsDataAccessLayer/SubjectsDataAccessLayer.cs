using System;
using System.Data;
using System.Data.SqlClient;

namespace SubjectsDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=.;Database=QuizDB;User Id=sa;Password=sa123456;";
    }

    public static class clsSubjectsDataAccess
    {
        public static bool GetSubjectInfoByID(int SubjectID, ref string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Subjects WHERE SubjectID = @SubjectID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SubjectID", SubjectID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    SubjectID = (int)reader["SubjectID"];
                    Name = (string)reader["Name"];

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
        public static bool GetSubjectInfoByName(ref int SubjectID, ref string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Subjects WHERE Name = @Name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    SubjectID = (int)reader["SubjectID"];
                    Name = (string)reader["Name"];

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
        public static int AddNewSubject(string Name)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Subjects VALUES (@Name)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Name", Name);


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
        public static bool UpdateSubject(int SubjectID, string Name)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Subjects
	SET	Name = @Name	WHERE SubjectID = @SubjectID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@SubjectID", SubjectID);

            command.Parameters.AddWithValue("@Name", Name);


            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteSubject(int SubjectID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE Subjects WHERE SubjectID = @SubjectID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SubjectID", SubjectID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsSubjectExist(int SubjectID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Subjects WHERE SubjectID= @SubjectID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SubjectID", SubjectID);

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

        public static DataTable GetAllSubjects()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Subjects";
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