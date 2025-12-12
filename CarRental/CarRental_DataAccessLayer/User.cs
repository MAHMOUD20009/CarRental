
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsUserDataAccess
    {
        public static bool FindUserByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref int Permissions, ref bool IsActive)
        {
            string query = @"SELECT * FROM Users 
                     WHERE UserID = @UserID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                PersonID = (int)Reader["PersonID"];
                                UserName = (string)Reader["UserName"];
                                Password = (string)Reader["Password"];
                                Permissions = (int)Reader["Permissions"];
                                IsActive = (bool)Reader["IsActive"];

                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return IsFound;
        }

        public static bool FindUserByUserName(string UserName, ref int PersonID, ref int UserID, ref string Password, ref int Permissions, ref bool IsActive)
        {
            string query = @"SELECT * FROM Users 
                     WHERE UserName = @UserName";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@UserName", UserName);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                UserID = (int)Reader["UserID"];
                                PersonID = (int)Reader["PersonID"];
                                Password = (string)Reader["Password"];
                                Permissions = (int)Reader["Permissions"];
                                IsActive = (bool)Reader["IsActive"];

                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return IsFound;
        }

        public static int? AddNewUser(int PersonID, string UserName, string Password, int Permissions, bool IsActive)
        {
            string query = @"INSERT INTO Users (PersonID, UserName, Password, Permissions, IsActive)
                     VALUES (@PersonID, @UserName, @Password, @Permissions, @IsActive);
                     SELECT SCOPE_IDENINTY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@UserName", UserName);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Permissions", Permissions);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);

                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            InsertedID = Convert.ToInt32(Result);
                    }

                }

            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return InsertedID;
        }


        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, int Permissions, bool IsActive)
        {
            string query = @"UPDATE Users 
                  SET 
                        PersonID = @PersonID, 
                        UserName = @UserName, 
                        Password = @Password, 
                        Permissions = @Permissions, 
                        IsActive = @IsActive
                     WHERE UserID = @UserID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@UserID", UserID);
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@UserName", UserName);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Permissions", Permissions);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return (RowsAffected > 0);
        }


        public static bool DeleteUser(int UserID)
        {
            string query = @"DELETE Users 
                     WHERE UserID = @UserID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@UserID", UserID);

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return (RowsAffected > 0);
        }


        public static DataTable GetAllUsers()
        {
            string query = @"SELECT* FROM Users ";

            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                DT.Load(Reader);
                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return DT;
        }

        public static bool IsUserExists(int UserID)
        {
            string query = @"IF EXISTS(SELECT 1 FROM Users 
                     WHERE UserID = @UserID) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@UserID", UserID);

                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            IsFound = Convert.ToBoolean(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return IsFound;
        }

        public static bool IsUserExists(string UserName)
        {
            string query = @"IF EXISTS(SELECT 1 FROM Users 
                     WHERE UserName = @UserName) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@UserName", UserName);

                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            IsFound = Convert.ToBoolean(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return IsFound;
        }
    }
}
