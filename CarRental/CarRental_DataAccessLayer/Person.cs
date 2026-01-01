using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CarRental_DataAccessLayer
{
    public static class clsPersonDataAccess
    {
        public static bool FindPersonByID(int PersonID, ref string Name, ref DateTime DateOfBirth, ref bool Gender, ref string Email, ref string Phone)
        {
            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindPersonByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
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
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        Command.Parameters.AddWithValue("@Gender", Gender);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);

                        SqlParameter OutputIDParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(OutputIDParam);

                        int RowsAffected = Command.ExecuteNonQuery();

                        if (RowsAffected > 0)
                            InsertedID = (int)Command.Parameters["@NewPersonID"].Value;
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
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdatePerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
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
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeletePersonByPersonId", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
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

        public static async Task<DataTable> GetPagedPeople(int PageNumber = 1, int RowsPerPage = 50)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    await Connection.OpenAsync();
                    using (SqlCommand Command = new SqlCommand("SP_GetPagedPeople", Connection))
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

        public static bool IsPersonExists(int PersonID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsPersonExistsByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);

                        SqlParameter OutputIsFoundParam = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(OutputIsFoundParam);

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

        public static int GetPersonCount()
        {
            int? PersonCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT COUNT(PersonID) FROM People", Connection))
                    {
                        object Result = Command.ExecuteScalar();

                        if (Result != null)
                            PersonCount = Convert.ToInt32(Result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return PersonCount.GetValueOrDefault();
        }

        public static int GetPageCount(int RowsPerPage)
        {
            int? PageCount = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetPeoplePageCount", Connection))
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
