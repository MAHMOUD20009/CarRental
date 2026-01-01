using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsFuelTypeDataAccess
    {
        public static bool FindFuelTypeByID(int ID, ref string FuelType)
        {
            string query = @"SELECT * From FuelTypes
                        WHERE ID = @ID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ID", ID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                FuelType = (string)Reader["FuelType"];

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

        public static bool FindFuelTypeByFuelType(string FuelType, ref int ID)
        {
            string query = @"SELECT * From FuelTypes
                        WHERE FuelType = @FuelType";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@FuelType", FuelType);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                ID = (int)Reader["ID"];

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

        public static int? AddNewFuelType(string FuelType)
        {
            string query = @"INSERT INTO FuelTypes (FuelType)
                     VALUES (@FuelType);
                     SELECT SCOPE_IDENTITY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@FuelType", FuelType);

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

        public static bool UpdateFuelType(int ID, string FuelType)
        {
            string query = @"Update FuelTypes 
                    SET 
                        FuelType = @FuelType
                    WHERE ID = @ID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@FuelType", FuelType);

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

        public static bool DeleteFuelType(int ID)
        {
            string query = @"Delete FuelTypes 
                     WHERE ID = @ID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ID", ID);

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

        public static DataTable GetAllFuelTypes()
        {
            string query = @"SELECT * From FuelTypes";

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

        public static bool IsFuelTypeExists(int ID)
        {
            string query = @"IF EXISTS(SELECT 1 FuelTypes 
                     WHERE ID = @ID) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ID", ID);

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
