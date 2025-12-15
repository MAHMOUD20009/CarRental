
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsVehicleDataAccess
    {
        public static bool FindVehicleByVehicleID(int VehicleID, ref string Make, ref string Model, ref int Year, ref int Mileage, ref int FuelTypeID, ref string PlateNumber, ref int CarCategoryID, ref float RentalPricePerDay, ref bool IsAvailableForRent)
        {
            string query = @"SELECT * FROM Vehicles 
                     WHERE VehicleID = @Comon.ColumnInfo";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                Make = (string)Reader["Make"];
                                Model = (string)Reader["Model"];
                                Year = (int)Reader["Year"];
                                Mileage = (int)Reader["Mileage"];
                                FuelTypeID = (int)Reader["FuelTypeID"];
                                PlateNumber = (string)Reader["PlateNumber"];
                                CarCategoryID = (int)Reader["CarCategoryID"];
                                RentalPricePerDay = (float)Reader["RentalPricePerDay"];
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

        public static int? AddNewVehicle(string Make, string Model, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, float RentalPricePerDay, bool IsAvailableForRent)
        {
            string query = @"INSERT INTO Vehicles (Make, Model, Year, Mileage, FuelTypeID, PlateNumber, CarCategoryID, RentalPricePerDay, IsAvailableForRent)
                     VALUES (@Make, @Model, @Year, @Mileage, @FuelTypeID, @PlateNumber, @CarCategoryID, @RentalPricePerDay, @IsAvailableForRent);
                     SELECT SCOPE_IDENTITY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Make", Make);
                        Command.Parameters.AddWithValue("@Model", Model);
                        Command.Parameters.AddWithValue("@Year", Year);
                        Command.Parameters.AddWithValue("@Mileage", Mileage);
                        Command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        Command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                        Command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);
                        Command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        Command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

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

        public static bool UpdateVehicle(int VehicleID, string Make, string Model, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, float RentalPricePerDay, bool IsAvailableForRent)
        {
            string query = @"Update Vehicles 
                        SET 
                            Make = @Make, 
                            Model = @Model, 
                            Year = @Year, 
                            Mileage = @Mileage, 
                            FuelTypeID = @FuelTypeID, 
                            PlateNumber = @PlateNumber, 
                            CarCategoryID = @CarCategoryID, 
                            RentalPricePerDay = @RentalPricePerDay, 
                            IsAvailableForRent = @IsAvailableForRent
                     WHERE VehicleID = @Comon.ColumnInfo";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        Command.Parameters.AddWithValue("@Make", Make);
                        Command.Parameters.AddWithValue("@Model", Model);
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
            string query = @"DELETE Vehicles 
                     WHERE VehicleID = @VehicleID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
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

        public static DataTable GetAllVehicles()
        {
            string query = @"SELECT * FROM Vehicles";

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

        public static bool IsVehicleExists(int VehicleID)
        {
            string query = @"IF EXISTS(SELECT 1 FROM Vehicles 
                     WHERE VehicleID = @VehicleID) SELECT !; ELSE SELECT 0;";

            bool IsFound = false;
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

        public static int GetTotalVehicles()
        {
            string query = @"SELECT COUNT(VehicleID) FROM Vehicles ";

            int? TotalVehicles = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            TotalVehicles = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return TotalVehicles.GetValueOrDefault();
        }

        public static int GetTotalVehiclesAvailable()
        {
            string query = @"SELECT COUNT(VehicleID) FROM Vehicles WHERE IsAvailableForRent = 1";

            int? TotalVehiclesAvailable = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            TotalVehiclesAvailable = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return TotalVehiclesAvailable.GetValueOrDefault();
        }
    }
}
