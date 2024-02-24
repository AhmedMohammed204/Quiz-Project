using System;
using System.Data;
using System.Data.SqlClient;

namespace AdminsDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=.;Database=QuizDB;User Id=sa;Password=sa123456;";
    }

    public static class clsAdminsDataAccess
    {
        public static bool GetAdminInfoByID(int AdminID, ref int UserID, ref int TotalAddedQuestions)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Admins WHERE AdminID = @AdminID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AdminID", AdminID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    AdminID = (int)reader["AdminID"];
                    UserID = (int)reader["UserID"];
                    TotalAddedQuestions = reader["TotalAddedQuestions"] != DBNull.Value ? (int)reader["TotalAddedQuestions"] : TotalAddedQuestions = default;

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
        public static bool GetAdminInfoByUserID(ref int AdminID, ref int UserID, ref int TotalAddedQuestions)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Admins WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    AdminID = (int)reader["AdminID"];
                    UserID = (int)reader["UserID"];
                    TotalAddedQuestions = reader["TotalAddedQuestions"] != DBNull.Value ? (int)reader["TotalAddedQuestions"] : TotalAddedQuestions = default;

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
        
        
        public static int AddNewAdmin(int UserID, int TotalAddedQuestions)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Admins VALUES (@UserID, @TotalAddedQuestions)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@UserID", UserID);

            if (string.IsNullOrEmpty(TotalAddedQuestions.ToString()))
                command.Parameters.AddWithValue("@TotalAddedQuestions", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalAddedQuestions", TotalAddedQuestions);

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
        public static bool UpdateAdmin(int AdminID, int UserID, int TotalAddedQuestions)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Admins
	SET	UserID = @UserID,
	TotalAddedQuestions = @TotalAddedQuestions	WHERE AdminID = @AdminID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@AdminID", AdminID);

            command.Parameters.AddWithValue("@UserID", UserID);

            if (string.IsNullOrEmpty(TotalAddedQuestions.ToString()))
                command.Parameters.AddWithValue("@TotalAddedQuestions", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalAddedQuestions", TotalAddedQuestions);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteAdmin(int AdminID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE Admins WHERE AdminID = @AdminID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdminID", AdminID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsAdminExist(int AdminID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Admins WHERE AdminID= @AdminID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdminID", AdminID);

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

        
        public static bool IsAdminExistByUserID(int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Admins WHERE UserID= @UserID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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



        public static DataTable GetAllAdmins()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Admins";
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