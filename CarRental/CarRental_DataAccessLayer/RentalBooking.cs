using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccessLayer
{
    public static class clsRentalBookingDataAccess
    {
        public static bool FindRentalBookingByID(int BookingID, ref int CustomerID, ref int VehicleID, ref DateTime RentalStartDate, ref DateTime RentalEndDate, ref string PickupLocation, ref string DropoffLocation, ref byte InitialRentalDays, ref float RentalPricePerDay, ref float InitialTotalDueAmount, ref string InitialCheckNotes)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindBookingByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookingID", BookingID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                CustomerID = (int)Reader["CustomerID"];
                                VehicleID = (int)Reader["VehicleID"];
                                RentalStartDate = (DateTime)Reader["RentalStartDate"];
                                RentalEndDate = (DateTime)Reader["RentalEndDate"];
                                PickupLocation = (string)Reader["PickupLocation"];
                                DropoffLocation = (string)Reader["DropoffLocation"];
                                InitialRentalDays = (byte)Reader["InitialRentalDays"];
                                RentalPricePerDay = Convert.ToSingle(Reader["RentalPricePerDay"]);
                                InitialTotalDueAmount = Convert.ToSingle(Reader["InitialTotalDueAmount"]);
                                InitialCheckNotes = (Reader["InitialCheckNotes"] == DBNull.Value) ? string.Empty : (string)Reader["InitialCheckNotes"];

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

        public static bool FindRentalBookingByReturnID(int ReturnID, ref int BookingID, ref int CustomerID, ref int VehicleID, ref DateTime RentalStartDate, ref DateTime RentalEndDate, ref string PickupLocation, ref string DropoffLocation, ref byte InitialRentalDays, ref float RentalPricePerDay, ref float InitialTotalDueAmount, ref string InitialCheckNotes)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindBookingByReturnID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                BookingID = (int)Reader["BookingID"];
                                CustomerID = (int)Reader["CustomerID"];
                                VehicleID = (int)Reader["VehicleID"];
                                RentalStartDate = (DateTime)Reader["RentalStartDate"];
                                RentalEndDate = (DateTime)Reader["RentalEndDate"];
                                PickupLocation = (string)Reader["PickupLocation"];
                                DropoffLocation = (string)Reader["DropoffLocation"];
                                InitialRentalDays = (byte)Reader["InitialRentalDays"];
                                RentalPricePerDay = Convert.ToSingle(Reader["RentalPricePerDay"]);
                                InitialTotalDueAmount = Convert.ToSingle(Reader["InitialTotalDueAmount"]);
                                InitialCheckNotes = (Reader["InitialCheckNotes"] == DBNull.Value) ? string.Empty : (string)Reader["InitialCheckNotes"];

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
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewBooking", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

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

                        SqlParameter outputNewBooingIDParam = new SqlParameter("@NewBookingID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputNewBooingIDParam);

                        int RowsAffected = Command.ExecuteNonQuery();

                        if (RowsAffected > 0)
                            InsertedID = (int)Command.Parameters["@NewBookingID"].Value;
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
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateBooking", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

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

                        if (string.IsNullOrWhiteSpace(InitialCheckNotes))
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
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteBooking", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
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

        public static async Task<DataTable> GetPagedBookings(int PageNumber, int RowsPerPage)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetPagedBookings", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            DT.Load(Reader);
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
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsBookingExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

                        SqlParameter outputIsFoundParam = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIsFoundParam);

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

        public static int GetBookingCount()
        {
            int? BookingCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT COUNT(BookingID) FROM RentalBooking", Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            BookingCount = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return BookingCount.GetValueOrDefault();
        }

        public static int GetPageCount(int RowsPerPage)
        {
            int? PageCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetBookingsPageCount", Connection))
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

        public static bool IsVehicleReturned(int BookingID)
        {
            bool IsReturned = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsVehicleReturned", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

                        SqlParameter outputIsFoundParam = new SqlParameter("@IsReturned", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(outputIsFoundParam);

                        Command.ExecuteNonQuery();

                        IsReturned = (bool)Command.Parameters["@IsReturned"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return IsReturned;
        }
    }
}
