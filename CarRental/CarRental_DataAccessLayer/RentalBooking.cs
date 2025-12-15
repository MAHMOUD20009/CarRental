using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsRentalBookingDataAccess
    {
        public static bool FindRentalBookingByBookingID(int BookingID, ref int CustomerID, ref int VehicleID, ref DateTime RentalStartDate, ref DateTime RentalEndDate, ref string PickupLocation, ref string DropoffLocation, ref byte InitialRentalDays, ref float RentalPricePerDay, ref float InitialTotalDueAmount, ref string InitialCheckNotes)
        {
            string query = @"SELECT * FROM RentalBooking
                     WHERE BookingID = @BookingID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

                        using(SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if(Reader.Read())
                            {
                                CustomerID = (int)Reader["CustomerID"];
                                VehicleID = (int)Reader["VehicleID"];
                                RentalStartDate = (DateTime)Reader["RentalStartDate"];
                                RentalEndDate = (DateTime)Reader["RentalEndDate"];
                                PickupLocation = (string)Reader["PickupLocation"];
                                DropoffLocation = (string)Reader["DropoffLocation"];
                                InitialRentalDays = (byte)Reader["InitialRentalDays"];
                                RentalPricePerDay = (float)Reader["RentalPricePerDay"];
                                InitialTotalDueAmount = (float)Reader["InitialTotalDueAmount"];
                                InitialCheckNotes = (Reader["InitialCheckNotes"] == DBNull.Value)? string.Empty : (string)Reader["InitialCheckNotes"];

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

        public static int? AddNewRentalBooking(int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, byte InitialRentalDays, float RentalPricePerDay, float InitialTotalDueAmount, string InitialCheckNotes)
        {
            string query = @"INSERT INTO RentalBooking (BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes)
                     VALUES (@CustomerID, @VehicleID, @RentalStartDate, @RentalEndDate, @PickupLocation, @DropoffLocation, @InitialRentalDays, @RentalPricePerDay, @InitialTotalDueAmount, @InitialCheckNotes);
                     SELECT SCOPE_IDENTITY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        Command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
                        Command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
                        Command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
                        Command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
                        Command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
                        Command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        Command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);

                        if (string.IsNullOrEmpty(InitialCheckNotes.Trim()))
                            Command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);

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


        public static bool UpdateRentalBooking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, byte InitialRentalDays, float RentalPricePerDay, float InitialTotalDueAmount, string InitialCheckNotes)
        {
            string query = @"Update RentalBooking 
                        SET 
                            CustomerID = @CustomerID, 
                            VehicleID = @VehicleID,
                            RentalStartDate = @RentalStartDate, 
                            RentalEndDate = @RentalEndDate,
                            PickupLocation = @PickupLocation, 
                            DropoffLocation = @DropoffLocation, 
                            InitialRentalDays = @InitialRentalDays, 
                            RentalPricePerDay = @RentalPricePerDay, 
                            InitialTotalDueAmount = @InitialTotalDueAmount, 
                            InitialCheckNotes = @InitialCheckNotes
                     WHERE BookingID = @BookingID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@BookingID", BookingID);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        Command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
                        Command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
                        Command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
                        Command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
                        Command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
                        Command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        Command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);

                        if (string.IsNullOrEmpty(InitialCheckNotes.Trim()))
                            Command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);

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

        public static bool DeleteRentalBooking(int BookingID)
        {
            string query = @"Delete RentalBooking 
                     WHERE BookingID = @BookingID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

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


        public static DataTable GetAllRentalBooking()
        {
            string query = @"SELECT * FROM RentalBooking";

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

        public static bool IsRentalBookingExists(int BookingID)
        {
            string query = @"IF EXISTS(SELECT 1 RentalBooking 
                     WHERE BookingID = @BookingID) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

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

        public static int GetTotalBookings()
        {
            string query = @"SELECT COUNT(BookingID) FROM RentalBooking ";

            int? TotalBookings = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            TotalBookings = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return TotalBookings.GetValueOrDefault();
        }
    }
}
