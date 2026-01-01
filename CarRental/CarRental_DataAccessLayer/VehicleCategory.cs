using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsVehicleCategoryDataAccess
    {
        public static bool FindVehicleCategoryByCategoryID(int CategoryID, ref string CategoryName)
        {
            string query = @"SELECT * FROM VehicleCategories 
                     WHERE CategoryID = @CategoryID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CategoryID", CategoryID);

                        using(SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if(Reader.Read())
                            {
                                CategoryName = (string)Reader["CategoryName"];

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

        public static bool FindVehicleCategoryByCategoryName(string CategoryName, ref int CategoryID)
        {
            string query = @"SELECT * FROM VehicleCategories 
                     WHERE CategoryName = @CategoryName";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CategoryName", CategoryName);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                CategoryID = (int)Reader["CategoryID"];

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

        public static int? AddNewVehicleCategory(string CategoryName)
        {
            string query = @"INSERT INTO VehicleCategories (CategoryName)
                     VALUES (@CategoryName);
                     SELECT SCOPE_IDENTITY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CategoryName", CategoryName);

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

        public static bool UpdateVehicleCategory(int CategoryID, string CategoryName)
        {
            string query = @"Update VehicleCategories 
                        SET 
                            CategoryName = @CategoryName
                        WHERE CategoryID = @CategoryID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Command.Parameters.AddWithValue("@CategoryName", CategoryName);

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

        public static bool DeleteVehicleCategory(int CategoryID)
        {
            string query = @"Delete VehicleCategories 
                     WHERE CategoryID = @CategoryID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CategoryID", CategoryID);

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

        public static DataTable GetAllVehicleCategories()
        {
            string query = @"SELECT * FROM VehicleCategories";

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

        public static bool IsVehicleCategoryExists(int CategoryID)
        {
            string query = @"IF EXISTS(SELECT 1 FROM VehicleCategories 
                     WHERE CategoryID = @CategoryID) SELECT ; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CategoryID", CategoryID);

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

        public static bool IsVehicleCategoryExists(string CategoryName)
        {
            string query = @"IF EXISTS(SELECT 1 FROM VehicleCategories 
                     WHERE CategoryName = @CategoryName) SELECT ; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CategoryName", CategoryName);

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
