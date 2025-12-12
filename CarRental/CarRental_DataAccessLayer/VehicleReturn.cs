using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsVehicleReturnDataAccess
    {
        public static bool FindVehicleReturn(int ReturnID, ref DateTime ActualReturnDate, ref byte ActualRentalDays, ref short Mileage, ref short ConsumedMileage, ref string FinalCheckNotes, ref float AdditionalCharges, ref float ActualTotalDueAmount)
        {
            string query = @"SELECT * FROM VehicleReturns 
                        WHERE ReturnID = @ReturnID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                ActualReturnDate = (DateTime)Reader["ActualReturnDate"];
                                ActualRentalDays = (byte)Reader["ActualRentalDays"];
                                Mileage = (short)Reader["Mileage"];
                                ConsumedMileage = (short)Reader["ConsumedMileage"];
                                FinalCheckNotes = (string)Reader["FinalCheckNotes"];
                                AdditionalCharges = (float)Reader["AdditionalCharges"];
                                ActualTotalDueAmount = (float)Reader["ActualTotalDueAmount"];


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

        public static int? AddNewVehicleReturn(DateTime ActualReturnDate, byte ActualRentalDays, short Mileage, short ConsumedMileage, string FinalCheckNotes, float AdditionalCharges, float ActualTotalDueAmount, int BookingID)
        {
            string AddNewRecordQuery = @"INSERT INTO VehicleReturns (ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount)
                     VALUES (@ActualReturnDate, @ActualRentalDays, @Mileage, @ConsumedMileage, @FinalCheckNotes, @AdditionalCharges, @ActualTotalDueAmount);
                     SELECT SCOPE_IDENINTY();";

            string UpdateRecordQuery = @"UPDATE RentalTransaction
                                        SET ReturnID = @ReturnID
                                        WHERE BookingID = @BookingID;
                                        SELECT @@ROWCOUNT;";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlTransaction Transaction = Connection.BeginTransaction())
                    {
                        using (SqlCommand Command = new SqlCommand(AddNewRecordQuery, Connection, Transaction))
                        {
                            Command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                            Command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                            Command.Parameters.AddWithValue("@Mileage", Mileage);
                            Command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
                            Command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
                            Command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                            Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

                            object Result = Command.ExecuteScalar();

                            if (Result != null)
                            {
                                InsertedID = Convert.ToInt32(Result);
                            }
                            else
                            {
                                Transaction.Rollback();
                                throw new Exception("An error ocurred while adding a new record to the VehicleReturn table.");
                            }
                        }

                        using (SqlCommand Command = new SqlCommand(UpdateRecordQuery, Connection, Transaction))
                        {
                            Command.Parameters.AddWithValue("@ReturnID", InsertedID);
                            Command.Parameters.AddWithValue("@BookingID", BookingID);

                            object Result = Command.ExecuteScalar();

                            if (Result != null && Convert.ToInt32(Result) == 0)
                            {
                                Transaction.Rollback();
                                throw new Exception("An error ocurred while adding a new record to the VehicleReturn table.");
                            }

                        }

                        Transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return InsertedID;
        }

        public static bool UpdateVehicleReturn(int ReturnID, DateTime ActualReturnDate, byte ActualRentalDays, short Mileage, short ConsumedMileage, string FinalCheckNotes, float AdditionalCharges, float ActualTotalDueAmount)
        {
            string query = @"Update VehicleReturns 
                        SET 
                            ActualReturnDate = @ActualReturnDate, 
                            ActualRentalDays = @ActualRentalDays, 
                            Mileage = @Mileage, 
                            ConsumedMileage = @ConsumedMileage, 
                            FinalCheckNotes = @FinalCheckNotes, 
                            AdditionalCharges = @AdditionalCharges, 
                            ActualTotalDueAmount = @ActualTotalDueAmount
                        WHERE ReturnID = @ReturnID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
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
            string query = @"Delete VehicleReturns 
                     WHERE ReturnID = @ReturnID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
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

        public static DataTable GetAllVehicleReturns()
        {
            string query = @"SELECT * FROM VehicleReturns";

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

        public static bool IsVehicleReturnExists(int ReturnID)
        {
            string query = @"IF EXISTS(SELECT 1 FROM VehicleReturns 
                     WHERE ReturnID = @ReturnID) SELECT 1; ELSE 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ReturnID", ReturnID);

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
