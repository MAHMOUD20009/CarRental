using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsPersonDataAccess
    {
        public static bool FindPersonByID(int PersonID, ref string Name, ref DateTime DateOfBirth, ref bool Gender, ref string Email, ref string Phone)
        {
            string query = @"SELECT * FROM People
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
                                Name = (string)Reader["Name"];
                                DateOfBirth = (DateTime)Reader["DateOfBirth"];
                                Gender = (bool)Reader["Gender"];
                                Email = (string)Reader["Email"];
                                Phone = (string)Reader["Phone"];

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

        public static int? AddNewPerson(string Name, DateTime DateOfBirth, bool Gender, string Email, string Phone)
        {
            string query = @"INSERT INTO People (Name, DateOfBirth, Gender, Email, Phone)
                     VALUES (@Name, @DateOfBirth, @Gender, @Email, @Phone);
                     SELECT SCOPE_IDENINTY();";

            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        Command.Parameters.AddWithValue("@Gender", Gender);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);

                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            InsertedID = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
                InsertedID = null;
            }

            return InsertedID;
        }

        public static bool UpdatePerson(int PersonID, string Name, DateTime DateOfBirth, bool Gender, string Email, string Phone)
        {
            string query = @"UPDATE People 
                  SET 
                    Name = @Name,
                    DateOfBirth = @DateOfBirth, 
                    Gender = @Gender,
                    Email = @Email,
                    Phone = @Phone
                  WHERE PersonID = @PersonID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        Command.Parameters.AddWithValue("@Gender", Gender);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);

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

        public static bool DeletePerson(int PersonID)
        {
            string query = @"DELETE People 
                     WHERE PersonID = @PersonID";

            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static DataTable GetAllPeople()
        {
            string query = @"SELECT * FROM People";

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

        public static bool IsPersonExists(int PersonID)
        {
            string query = @"IF EXISTS(SELECT 1 FROM People 
                     WHERE PersonID = @PersonID) SELECT 1; ELSE SELECT 0;";

            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);

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
