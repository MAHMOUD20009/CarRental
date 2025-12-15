using System;
using System.Text;
using System.Security.Cryptography;

namespace CarRental_BusinessLogicLayer
{
    public static class clsSecurityUtils
    {
        public static string Encryption(string Input)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] HashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));
                return BitConverter.ToString(HashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
