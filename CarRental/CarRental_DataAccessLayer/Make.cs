using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public static class clsMakeDataAccess
    {
        public static bool FindMakeByID(int MakeID, ref string MakeName)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindMakeByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MakeID", MakeID);

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                MakeName = (string)reader["MakeName"];

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

        public static bool FindMakeByMakeName(string MakeName, ref int MakeID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_FindMakeByMakeName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MakeName", MakeID);

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MakeID = (int)reader["MakeID"];

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

        public static int? AddNewMake(string MakeName)
        {
            int? InsertedID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_AddNewMake", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MakeName", MakeName);

                        SqlParameter outputMakeIDParam = new SqlParameter("@NewMakeID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputMakeIDParam);

                        int RowsAffected = Command.ExecuteNonQuery();

                        if (RowsAffected > 0)
                            InsertedID = (int)Command.Parameters["@NewMakeID"].Value;
                    }

                }

            }
            catch (Exception ex)
            {
                clsLogger.Log(ex.Message);
            }

            return InsertedID;
        }

        public static bool UpdateMake(int MakeID, string MakeName)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_UpdateMake", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MakeID", MakeID);
                        Command.Parameters.AddWithValue("@MakeName", MakeName);

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

        public static bool DeleteMake(int MakeID)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DeleteMake", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MakeID", MakeID);

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

        public static DataTable GetAllMakes()
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllMakes", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

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

        public static bool IsMakeExistsByID(int MakeID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsMakeExistsByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MakeID", MakeID);

                        SqlParameter OutputIsFoundParam = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(OutputIsFoundParam);

                        int RowsAffected = Command.ExecuteNonQuery();

                        if (RowsAffected > 0)
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

        public static bool IsMakeExistsByMakeName(string MakeName)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsMakeExistsByMakeName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MakeName", MakeName);

                        SqlParameter OutputIsFoundParam = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(OutputIsFoundParam);

                        int RowsAffected = Command.ExecuteNonQuery();

                        if (RowsAffected > 0)
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
    }
}
