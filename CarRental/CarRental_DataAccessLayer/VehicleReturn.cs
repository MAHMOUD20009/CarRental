using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccessLayer
{
    public static class clsVehicleReturnDataAccess
    {
        public static bool FindVehicleReturnByID(int ReturnID, ref DateTime ActualReturnDate, ref byte ActualRentalDays, ref int Mileage, ref int ConsumedMileage, ref string FinalCheckNotes, ref float AdditionalCharges, ref float ActualTotalDueAmount)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindReturnByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                ActualReturnDate = (DateTime)Reader["ActualReturnDate"];
                                ActualRentalDays = (byte)Reader["ActualRentalDays"];
                                Mileage = Convert.ToInt32(Reader["Mileage"]);
                                ConsumedMileage = Convert.ToInt32(Reader["ConsumedMileage"]);
                                FinalCheckNotes = (string)Reader["FinalCheckNotes"];
                                AdditionalCharges = Convert.ToSingle(Reader["AdditionalCharges"]);
                                ActualTotalDueAmount = Convert.ToSingle(Reader["ActualTotalDueAmount"]);

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

        public static bool FindVehicleReturnByBookingID(int BookingID, ref int ReturnID, ref DateTime ActualReturnDate, ref byte ActualRentalDays, ref int Mileage, ref int ConsumedMileage, ref string FinalCheckNotes, ref float AdditionalCharges, ref float ActualTotalDueAmount)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindReturnByBookingID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookingID", ReturnID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                ReturnID = (int)Reader["ReturnID"];
                                ActualReturnDate = (DateTime)Reader["ActualReturnDate"];
                                ActualRentalDays = (byte)Reader["ActualRentalDays"];
                                Mileage = Convert.ToInt32(Reader["Mileage"]);
                                ConsumedMileage = Convert.ToInt32(Reader["ConsumedMileage"]);
                                FinalCheckNotes = (string)Reader["FinalCheckNotes"];
                                AdditionalCharges = Convert.ToSingle(Reader["AdditionalCharges"]);
                                ActualTotalDueAmount = Convert.ToSingle(Reader["ActualTotalDueAmount"]);

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

        public static int? AddNewVehicleReturn(DateTime ActualReturnDate, byte ActualRentalDays, int Mileage, int ConsumedMileage, string FinalCheckNotes, float AdditionalCharges, float ActualTotalDueAmount, int BookingID)
        {
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewReturn", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        Command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                        Command.Parameters.AddWithValue("@Mileage", Mileage);
                        Command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
                        Command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
                        Command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                        Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

                        SqlParameter outputIsSuccessParam = new SqlParameter("@IsSuccess", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        SqlParameter outputNewReturnIDParam = new SqlParameter("@NewReturnID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(outputIsSuccessParam);
                        Command.Parameters.Add(outputNewReturnIDParam);

                        Command.ExecuteNonQuery();

                        if ((bool)Command.Parameters["@IsSuccess"].Value)
                        {
                            InsertedID = (int)Command.Parameters["@NewReturnID"].Value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return InsertedID;
        }

        public static bool UpdateVehicleReturn(int ReturnID, DateTime ActualReturnDate, byte ActualRentalDays, int Mileage, int ConsumedMileage, string FinalCheckNotes, float AdditionalCharges, float ActualTotalDueAmount)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateReturn", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);
                        Command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        Command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                        Command.Parameters.AddWithValue("@Mileage", Mileage);
                        Command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
                        Command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
                        Command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                        Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

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

        public static bool DeleteVehicleReturn(int ReturnID)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteReturn", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);

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

        public static async Task<DataTable> GetPagedReturns(int PageNumber, int RowsPerPage)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    await Connection.OpenAsync();
                    using (SqlCommand Command = new SqlCommand("SP_GetPagedReturns", Connection))
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

        public static bool IsVehicleReturnExists(int ReturnID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsReturnExistsByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);

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

        public static int GetReturnCount()
        {
            int? ReturnCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT COUNT(ReturnID) FROM VehicleReturns", Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            ReturnCount = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return ReturnCount.GetValueOrDefault();
        }

        public static int GetPageCount(int RowsPerPage)
        {
            int? PageCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetReturnsPageCount", Connection))
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
