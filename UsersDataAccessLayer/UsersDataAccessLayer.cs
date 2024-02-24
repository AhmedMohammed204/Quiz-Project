


using System;
using System.Data;
using System.Data.SqlClient;

namespace UsersDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=.;Database=QuizDB;User Id=sa;Password=sa123456;";
    }
    public static class clsUsersDataAccess
    {

        public static bool IsUserExist(string Username)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE Username= @Username";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

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



        public static bool GetUserInfoByUsername(ref int UserID, ref string FirstName, ref string Username, ref string Password, ref int TotalAnswers, ref int TotalRightAnswers)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    FirstName = (string)reader["FirstName"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    TotalAnswers = reader["TotalAnswers"] != DBNull.Value ? (int)reader["TotalAnswers"] : TotalAnswers = default;
                    TotalRightAnswers = reader["TotalRightAnswers"] != DBNull.Value ? (int)reader["TotalRightAnswers"] : TotalRightAnswers = default;

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




        public static bool GetUserInfoByID(int UserID, ref string FirstName, ref string Username, ref string Password, ref int TotalAnswers, ref int TotalRightAnswers)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    FirstName = (string)reader["FirstName"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    TotalAnswers = reader["TotalAnswers"] != DBNull.Value ? (int)reader["TotalAnswers"] : TotalAnswers = default;
                    TotalRightAnswers = reader["TotalRightAnswers"] != DBNull.Value ? (int)reader["TotalRightAnswers"] : TotalRightAnswers = default;

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
        public static int AddNewUser(string FirstName, string Username, string Password, int TotalAnswers, int TotalRightAnswers)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users VALUES (@FirstName, @Username, @Password, @TotalAnswers, @TotalRightAnswers)
        SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@Username", Username);

            command.Parameters.AddWithValue("@Password", Password);

            if (TotalAnswers == -1)
                command.Parameters.AddWithValue("@TotalAnswers", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalAnswers", TotalAnswers);
            if (TotalRightAnswers == -1)
                command.Parameters.AddWithValue("@TotalRightAnswers", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalRightAnswers", TotalRightAnswers);

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
        public static bool UpdateUser(int UserID, string FirstName, string Username, string Password, int TotalAnswers, int TotalRightAnswers)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Users
	SET	FirstName = @FirstName,
	Username = @Username,
	Password = @Password,
	TotalAnswers = @TotalAnswers,
	TotalRightAnswers = @TotalRightAnswers	WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@UserID", UserID);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@Username", Username);

            command.Parameters.AddWithValue("@Password", Password);


            if (TotalAnswers == -1)
                command.Parameters.AddWithValue("@TotalAnswers", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalAnswers", TotalAnswers);
            if (TotalRightAnswers == -1)
                command.Parameters.AddWithValue("@TotalRightAnswers", DBNull.Value);
            else
                command.Parameters.AddWithValue("@TotalRightAnswers", TotalRightAnswers);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffected > 0);

        }
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (rowsAffected > 0);

        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE UserID= @UserID";
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

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users";
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