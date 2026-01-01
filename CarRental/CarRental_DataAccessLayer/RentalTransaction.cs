using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccessLayer
{
    public static class clsRentalTransactionDataAccess
    {
        public static bool FindRentalTransactionByTransactionID(int TransactionID, ref int BookingID, ref int? ReturnID, ref string PaymentDetails, ref float PaidInitialTotalDueAmount, ref float? ActualTotalDueAmount, ref float? TotalRemaining, ref float? TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();          
                    using (SqlCommand Command = new SqlCommand("SP_FindTransactionByTransactionID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@TransactionID", TransactionID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                BookingID = (int)Reader["BookingID"];
                                PaymentDetails = (string)Reader["PaymentDetails"];
                                PaidInitialTotalDueAmount = Convert.ToSingle(Reader["PaidInitialTotalDueAmount"]);
                                TransactionDate = (DateTime)Reader["TransactionDate"];
                                UpdatedTransactionDate = (DateTime)Reader["UpdatedTransactionDate"];

                                if (Reader["ReturnID"] != DBNull.Value) ReturnID = (int)Reader["ReturnID"];
                                else ReturnID = null;

                                if (Reader["ActualTotalDueAmount"] != DBNull.Value) ActualTotalDueAmount = Convert.ToSingle(Reader["ActualTotalDueAmount"]);
                                else ActualTotalDueAmount = null;

                                if (Reader["TotalRemaining"] != DBNull.Value) TotalRemaining = Convert.ToSingle(Reader["TotalRemaining"]);
                                else TotalRemaining = null;

                                if (Reader["TotalRefundedAmount"] != DBNull.Value) TotalRefundedAmount = Convert.ToSingle(Reader["TotalRefundedAmount"]);
                                else TotalRefundedAmount = null;

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

        public static bool FindRentalTransactionByBookingID(int BookingID, ref int TransactionID, ref int? ReturnID, ref string PaymentDetails, ref float PaidInitialTotalDueAmount, ref float? ActualTotalDueAmount, ref float? TotalRemaining, ref float? TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindTransactionByBookingID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                TransactionID = (int)Reader["TransactionID"];
                                PaymentDetails = (string)Reader["PaymentDetails"];
                                PaidInitialTotalDueAmount = Convert.ToSingle(Reader["PaidInitialTotalDueAmount"]);
                                TransactionDate = (DateTime)Reader["TransactionDate"];
                                UpdatedTransactionDate = (DateTime)Reader["UpdatedTransactionDate"];

                                if (Reader["ReturnID"] != DBNull.Value) ReturnID = (int)Reader["ReturnID"];
                                else ReturnID = null;

                                if (Reader["ActualTotalDueAmount"] != DBNull.Value) ActualTotalDueAmount = Convert.ToSingle(Reader["ActualTotalDueAmount"]);
                                else ActualTotalDueAmount = null;

                                if (Reader["TotalRemaining"] != DBNull.Value) TotalRemaining = Convert.ToSingle(Reader["TotalRemaining"]);
                                else TotalRemaining = null;

                                if (Reader["TotalRefundedAmount"] != DBNull.Value) TotalRefundedAmount = Convert.ToSingle(Reader["TotalRefundedAmount"]);
                                else TotalRefundedAmount = null;

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

        public static bool FindRentalTransactionByReturnID(int ReturnID, ref int TransactionID, ref int BookingID, ref string PaymentDetails, ref float PaidInitialTotalDueAmount, ref float? ActualTotalDueAmount, ref float? TotalRemaining, ref float? TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindTransactionByReturnID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                TransactionID = (int)Reader["TransactionID"];
                                BookingID = (int)Reader["BookingID"];
                                PaymentDetails = (string)Reader["PaymentDetails"];
                                PaidInitialTotalDueAmount = Convert.ToSingle(Reader["PaidInitialTotalDueAmount"]);
                                ActualTotalDueAmount = Convert.ToSingle(Reader["ActualTotalDueAmount"]);
                                TotalRemaining = Convert.ToSingle(Reader["TotalRemaining"]);
                                TotalRefundedAmount = Convert.ToSingle(Reader["TotalRefundedAmount"]);
                                TransactionDate = (DateTime)Reader["TransactionDate"];
                                UpdatedTransactionDate = (DateTime)Reader["UpdatedTransactionDate"];


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

        public static int? AddNewRentalTransaction(int BookingID, int? ReturnID, string PaymentDetails, float PaidInitialTotalDueAmount, float? ActualTotalDueAmount, float? TotalRemaining, float? TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewTransaction", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@BookingID", BookingID);
                        Command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
                        Command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
                        Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                        Command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);

                        if (ReturnID == null) Command.Parameters.AddWithValue("@ReturnID", DBNull.Value);
                        else Command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        if (ActualTotalDueAmount == null) Command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);
                        else Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

                        if (TotalRemaining == null) Command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);
                        else Command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);

                        if (TotalRefundedAmount == null) Command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
                        else Command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);

                        SqlParameter outputNewTransactionIDParam = new SqlParameter("@NewTransactionID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(outputNewTransactionIDParam);

                        int RowsAffected = Command.ExecuteNonQuery();

                        if (RowsAffected > 0)
                            InsertedID = (int)Command.Parameters["@NewTransactionID"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return InsertedID;
        }

        public static bool UpdateRentalTransaction(int TransactionID, int BookingID, int? ReturnID, string PaymentDetails, float PaidInitialTotalDueAmount, float? ActualTotalDueAmount, float? TotalRemaining, float? TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateTransaction", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@TransactionID", TransactionID);
                        Command.Parameters.AddWithValue("@BookingID", BookingID);
                        Command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
                        Command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
                        Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                        Command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);

                        if (ReturnID == null) Command.Parameters.AddWithValue("@ReturnID", DBNull.Value);
                        else Command.Parameters.AddWithValue("@ReturnID", ReturnID);
                        
                        if (ActualTotalDueAmount == null) Command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);
                        else Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

                        if (TotalRemaining == null) Command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);
                        else Command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);

                        if (TotalRefundedAmount == null) Command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
                        else Command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);

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

        public static bool DeleteRentalTransaction(int TransactionID)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteTransaction", Connection))
                    {
                        Command.Parameters.AddWithValue("@TransactionID", TransactionID);

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

        public static async Task<DataTable> GetPagedTransactions(int PageNumber, int RowsPerPage)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    await Connection.OpenAsync();
                    using (SqlCommand Command = new SqlCommand("SP_GetPagedTransactions", Connection))
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

        public static bool IsRentalTransationExistsByTransactionID(int TransactionID)
        {
           bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsTransationExistsByTransationID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@TransactionID", TransactionID);

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

        public static bool IsRentalTransationExistsByBookingID(int BookingID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsTransationExistsByBookingID", Connection))
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

        public static int GetTransactionCount()
        {
            int? TransactionCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT COUNT(TransactionID) FROM RentalTransaction", Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            TransactionCount = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return TransactionCount.GetValueOrDefault();
        }
    
        public static int GetPageCount(int RowsPerPage)
        {
            int? PageCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetTransactionsPageCount", Connection))
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
