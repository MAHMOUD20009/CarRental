using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsCustomerDataAccess
    {
        public static bool FindCustomerByCustomerID(int CustomerID, ref int PersonID, ref string DriverLicenseNumber)
        {
            string query = @"SELECT * FROM Customer
                     WHERE CustomerID = @CustomerID";
            
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        using(SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if(Reader.Read())
                            {
                                PersonID = (int)Reader["PersonID"];
                                DriverLicenseNumber = (string)Reader["DriverLicenseNumber"];

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

        public static bool FindCustomerByPersonID(int PersonID, ref int CustomerID, ref string DriverLicenseNumber)
        {
            string query = @"SELECT * FROM Customer
                     WHERE PersonID = @PersonID";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                CustomerID = (int)Reader["CustomerID"];
                                DriverLicenseNumber = (string)Reader["DriverLicenseNumber"];

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

        public static int? AddNewCustomer(int PersonID, string DriverLicenseNumber)
        {
            string query = @"INSERT INTO Customer (PersonID, DriverLicenseNumber)
                     VALUES (@PersonID, @DriverLicenseNumber);
                     SELECT SCOPE_IDENINTY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

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

        public static bool UpdateCustomer(int CustomerID, int PersonID, string DriverLicenseNumber)
        {
            string query = @"Update Customer 
                  SET 
                    PersonID = @PersonID, 
                    DriverLicenseNumber = @DriverLicenseNumber
                     WHERE CustomerID = @CustomerID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

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

        public static bool DeleteCustomer(int CustomerID)
        {
            string query = @"DELETE Customer 
                     WHERE CustomerID = @CustomerID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static DataTable GetAllCustomers()
        {
            string query = @"SELECT * FROM Customer ";

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

        public static bool IsCustomerExists(int CustomerID)
        {
            string query = @"IF EXISTS(SELECT 1 Customer 
                     WHERE CustomerID = @CustomerID) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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
