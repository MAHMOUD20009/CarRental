using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccessLayer
{
    public static class clsVehicleDataAccess
    {
        public static bool FindVehicleByID(int VehicleID, ref int MakeID, ref int ModelID, ref int Year, ref int Mileage, ref int FuelTypeID, ref string PlateNumber, ref int CarCategoryID, ref float RentalPricePerDay, ref bool IsAvailableForRent)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindVehicleByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                MakeID = (int)Reader["MakeID"];
                                ModelID = (int)Reader["ModelID"];
                                Year = (int)Reader["Year"];
                                Mileage = (int)Reader["Mileage"];
                                FuelTypeID = (int)Reader["FuelTypeID"];
                                PlateNumber = (string)Reader["PlateNumber"];
                                CarCategoryID = (int)Reader["CarCategoryID"];
                                RentalPricePerDay = Convert.ToSingle(Reader["RentalPricePerDay"]);
                                IsAvailableForRent = (bool)Reader["IsAvailableForRent"];

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

        public static int? AddNewVehicle(int MakeID, int ModelID, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, float RentalPricePerDay, bool IsAvailableForRent)
        {
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewVehicle", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MakeID", MakeID);
                        Command.Parameters.AddWithValue("@ModelID", ModelID);
                        Command.Parameters.AddWithValue("@Year", Year);
                        Command.Parameters.AddWithValue("@Mileage", Mileage);
                        Command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        Command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                        Command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);
                        Command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        Command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

                        SqlParameter outputNewVehicleIDParam = new SqlParameter("@NewVehicleID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputNewVehicleIDParam);

                        Command.ExecuteNonQuery();

                        if (Command.Parameters["@NewVehicleID"].Value != null)
                            InsertedID = (int) Command.Parameters["@NewVehicleID"].Value;
                    }

                }

            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return InsertedID;
        }

        public static bool UpdateVehicle(int VehicleID, int MakeID, int ModelID, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, float RentalPricePerDay, bool IsAvailableForRent)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UPdateVehicle", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        Command.Parameters.AddWithValue("@MakeID", MakeID);
                        Command.Parameters.AddWithValue("@ModelID", ModelID);
                        Command.Parameters.AddWithValue("@Year", Year);
                        Command.Parameters.AddWithValue("@Mileage", Mileage);
                        Command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        Command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                        Command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);
                        Command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        Command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

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

        public static bool DeleteVehicle(int VehicleID)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteVehicle", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);

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

        public static async Task<DataTable> GetPagedVehicles(int PageNumber, int RowsPerPage)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetPagedVehicles", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
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

        public static bool IsVehicleExists(int VehicleID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsVehicleExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        SqlParameter outputIsFound = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIsFound);

                        Command.ExecuteNonQuery();

                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return IsFound;
        }

        public static bool IsVehicleAvailable(int VehicleID)
        {
            string query = @"SELECT IsAvailableForRent FROM Vehicles 
                     WHERE VehicleID = @VehicleID";

            bool IsVehicleAvailable = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            IsVehicleAvailable = Convert.ToBoolean(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return IsVehicleAvailable;
        }

        public static int GetVehicleCount()
        {
            int? VehicleCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT COUNT(VehicleID) FROM Vehicles", Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            VehicleCount = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return VehicleCount.GetValueOrDefault();
        }

        public static int GetVehicleAvailableCount()
        {
            int? VehicleAvailableCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT COUNT(VehicleID) FROM Vehicles WHERE IsAvailableForRent = 1", Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            VehicleAvailableCount = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return VehicleAvailableCount.GetValueOrDefault();
        }

        public static int GetPageCount(int RowsPerPage)
        {
            int? PageCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetVehiclesPageCount", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);

                        SqlParameter outputPageCountParam = new SqlParameter("@PageCount", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputPageCountParam);


                        Command.ExecuteNonQuery();

                        PageCount = (int)Command.Parameters["@PageCount"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return PageCount.GetValueOrDefault();
        }
    }
}
