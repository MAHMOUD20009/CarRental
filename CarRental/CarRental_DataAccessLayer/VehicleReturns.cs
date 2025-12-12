using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsVehiclesReturnsDataAccessLayer
    {

        public static int? AddNew(int ReturenID, DateTime ActualReturnDate, byte ActualRentalDays, short Mileage, short ConsumedMileage, string FinalCheckNotes, string AdditionalCharges, string ActualTotalDueAmount)
        {
            string query = @"INSERT INTO VehiclesReturns (ReturenID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount)
                     VALUES (@ReturenID, @ActualReturnDate, @ActualRentalDays, @Mileage, @ConsumedMileage, @FinalCheckNotes, @AdditionalCharges, @ActualTotalDueAmount);
                     SELECT SCOPE_IDENINTY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ReturenID", ReturenID);
                        Command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        Command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                        Command.Parameters.AddWithValue("@Mileage", Mileage);
                        Command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
                        Command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
                        Command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                        Command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            InsertedID = Convert.ToInt32(Result);
                    }

                }

            }
            catch (Exception)
            { }
            return InsertedID;
        }

        public static bool Update(int ReturenID, DateTime ActualReturnDate, byte ActualRentalDays, short Mileage, short ConsumedMileage, string FinalCheckNotes, string AdditionalCharges, string ActualTotalDueAmount)
        {
            string query = @"Update VehiclesReturns 
                  SET ActualReturnDate = @ActualReturnDate, ActualRentalDays = @ActualRentalDays, Mileage = @Mileage, ConsumedMileage = @ConsumedMileage, FinalCheckNotes = @FinalCheckNotes, AdditionalCharges = @AdditionalCharges, ActualTotalDueAmount = @ActualTotalDueAmount
                     WHERE ReturenID = @Comon.ColumnInfo";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ReturenID", ReturenID);
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
            catch (Exception)
            { }
            return (RowsAffected > 0);
        }

        public static bool Delete(int ReturenID)
        {
            string query = @"Delete VehiclesReturns 
                     WHERE ReturenID = @ReturenID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ReturenID", ReturenID);

                        RowsAffected = Command.ExecuteNonQuery();


                    }

                }

            }
            catch (Exception)
            { }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllData()
        {
            string query = @"Select * From VehiclesReturns ";

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
                        } // End Reader

                    }

                }

            }
            catch (Exception)
            { }
            return DT;
        }
    }
}
