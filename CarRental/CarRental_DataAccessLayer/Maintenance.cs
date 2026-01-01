
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsMaintenanceDataAccess
    {
        public static bool FindMaintenance(int MaintenanceID, ref int VehicleID, ref string Description, ref DateTime MaintenanceDate, ref float Cost)
        {
            string query = @"SELECT * FROM Maintenance 
                         WHERE MaintenanceID = @MaintenanceID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            VehicleID = (int)Reader["VehicleID"];
                            Description = (string)Reader["Description"];
                            MaintenanceDate = (DateTime)Reader["MaintenanceDate"];
                            Cost = (float)Reader["Cost"];

                            IsFound = true;
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

        public static int? AddNewMaintenance(int VehicleID, string Description, DateTime MaintenanceDate, float Cost)
        {
            string query = @"INSERT INTO Maintenance (VehicleID, Description, MaintenanceDate, Cost)
                     VALUES (@VehicleID, @Description, @MaintenanceDate, @Cost);
                     SELECT SCOPE_IDENTITY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        Command.Parameters.AddWithValue("@Description", Description);
                        Command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
                        Command.Parameters.AddWithValue("@Cost", Cost);

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


        public static bool UpdateMaintenance(int MaintenanceID, int VehicleID, string Description, DateTime MaintenanceDate, float Cost)
        {
            string query = @"Update Maintenance 
                        SET 
                            VehicleID = @VehicleID, 
                            Description = @Description,
                            MaintenanceDate = @MaintenanceDate, 
                            Cost = @Cost
                        WHERE MaintenanceID = @MaintenanceID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        Command.Parameters.AddWithValue("@Description", Description);
                        Command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
                        Command.Parameters.AddWithValue("@Cost", Cost);

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


        public static bool DeleteMaintenance(int MaintenanceID)
        {
            string query = @"DELETE Maintenance 
                     WHERE MaintenanceID = @MaintenanceID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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


        public static DataTable GetAllMaintenance()
        {
            string query = @"SELECT * From Maintenance";

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

        public static bool IsMaintenanceExists(int MaintenanceID)
        {
            string query = @"IF EXISTS(SELECT 1 Maintenance 
                     WHERE MaintenanceID = @MaintenanceID) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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
