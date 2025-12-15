using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsRentalTransactionDataAccess
    {
        public static bool FindRentalTransactionByTransactionID(int TransactionID, ref int BookingID, ref int? ReturnID, ref string PaymentDetails, ref float PaidInitialTotalDueAmount, ref float? ActualTotalDueAmount, ref float? TotalRemaining, ref float? TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            string query = @"SELECT * FROM RentalTransaction
                        WHERE TransactionID = @TransactionID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@TransactionID", TransactionID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                BookingID = (int)Reader["BookingID"];

                                if (Reader["ReturnID"] == DBNull.Value) ReturnID = (int)Reader["ReturnID"];
                                else ReturnID = null;
                                PaymentDetails = (string)Reader["PaymentDetails"];
                                PaidInitialTotalDueAmount = (float)Reader["PaidInitialTotalDueAmount"];
                                PaidInitialTotalDueAmount = (float)Reader["PaidInitialTotalDueAmount"];

                                if (Reader["ActualTotalDueAmount"] == DBNull.Value) ActualTotalDueAmount = (float)Reader["ActualTotalDueAmount"];
                                else ActualTotalDueAmount = null;

                                if (Reader["TotalRemaining"] == DBNull.Value) TotalRemaining = (float)Reader["TotalRemaining"];
                                else TotalRemaining = null;

                                if (Reader["TotalRefundedAmount"] == DBNull.Value) TotalRefundedAmount = (float)Reader["TotalRefundedAmount"];
                                else TotalRefundedAmount = null;

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

        public static bool FindRentalTransactionByBookingID(int BookingID, ref int TransactionID, ref int? ReturnID, ref string PaymentDetails, ref float PaidInitialTotalDueAmount, ref float? ActualTotalDueAmount, ref float? TotalRemaining, ref float? TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            string query = @"SELECT * FROM RentalTransaction
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

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                TransactionID = (int)Reader["TransactionID"];

                                if (Reader["ReturnID"] == DBNull.Value) ReturnID = (int)Reader["ReturnID"];
                                else ReturnID = null;
                                PaymentDetails = (string)Reader["PaymentDetails"];
                                PaidInitialTotalDueAmount = (float)Reader["PaidInitialTotalDueAmount"];
                                PaidInitialTotalDueAmount = (float)Reader["PaidInitialTotalDueAmount"];

                                if (Reader["ActualTotalDueAmount"] == DBNull.Value) ActualTotalDueAmount = (float)Reader["ActualTotalDueAmount"];
                                else ActualTotalDueAmount = null;

                                if (Reader["TotalRemaining"] == DBNull.Value) TotalRemaining = (float)Reader["TotalRemaining"];
                                else TotalRemaining = null;

                                if (Reader["TotalRefundedAmount"] == DBNull.Value) TotalRefundedAmount = (float)Reader["TotalRefundedAmount"];
                                else TotalRefundedAmount = null;

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
            string query = @"INSERT INTO RentalTransaction (BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate)
                     VALUES (@BookingID, @ReturnID, @PaymentDetails, @PaidInitialTotalDueAmount, @ActualTotalDueAmount, @TotalRemaining, @TotalRefundedAmount, @TransactionDate, @UpdatedTransactionDate);
                     SELECT SCOPE_IDENTITY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

                        if (ReturnID == null)
                            Command.Parameters.AddWithValue("@ReturnID", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        Command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
                        Command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);

                        if (ActualTotalDueAmount == null)
                            Command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

                        if (TotalRemaining == null)
                            Command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);

                        if (TotalRefundedAmount == null)
                            Command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@TotalRefundedAmount", ReturnID);

                        Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                        Command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);

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

        public static bool UpdateRentalTransaction(int TransactionID, int BookingID, int? ReturnID, string PaymentDetails, float PaidInitialTotalDueAmount, float ActualTotalDueAmount, float TotalRemaining, float TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            string query = @"Update RentalTransaction 
                        SET 
                            BookingID = @BookingID, 
                            ReturnID = @ReturnID, 
                            PaymentDetails = @PaymentDetails, 
                            PaidInitialTotalDueAmount = @PaidInitialTotalDueAmount, 
                            ActualTotalDueAmount = @ActualTotalDueAmount, 
                            TotalRemaining = @TotalRemaining, 
                            TotalRefundedAmount = @TotalRefundedAmount, 
                            TransactionDate = @TransactionDate, 
                            UpdatedTransactionDate = @UpdatedTransactionDate
                        WHERE TransactionID = @TransactionID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@TransactionID", TransactionID);
                        Command.Parameters.AddWithValue("@BookingID", BookingID);

                        if (ReturnID == null)
                            Command.Parameters.AddWithValue("@ReturnID", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        Command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
                        Command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);

                        if (ActualTotalDueAmount == null)
                            Command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

                        if (TotalRemaining == null)
                            Command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);

                        if (TotalRefundedAmount == null)
                            Command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@TotalRefundedAmount", ReturnID);

                        Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                        Command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);

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
            string query = @"Delete RentalTransaction 
                     WHERE TransactionID = @TransactionID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
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

        public static DataTable GetAllRentalTransactions()
        {
            string query = @"SELECT * From RentalTransaction";

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

        public static bool IsRentalTransactionExists(int TransactionID)
        {
            string query = @"IF EXISTS(SELECT 1 RentalTransaction
                     WHERE TransactionID = @TransactionID) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@TransactionID", TransactionID);

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

        public static int GetTotalTransactions()
        {
            string query = @"SELECT COUNT(TransactionID) FROM RentalTransaction ";

            int? TotalTransactions = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            TotalTransactions = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return TotalTransactions.GetValueOrDefault();
        }
    }
}
