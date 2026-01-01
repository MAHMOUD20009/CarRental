using System.Configuration;

namespace CarRental_DataAccessLayer
{
    internal static class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}
