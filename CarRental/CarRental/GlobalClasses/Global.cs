using System;
using Microsoft.Win32;
using CarRental_BusinessLogicLayer;

namespace CarRental.GlobalClasses
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        private const string _KeyPath = @"SOFTWARE\CarRental_Management";
        private const string _LoginInfoPath = _KeyPath + @"\LoginInformation";
        private const string _KeyName1 = "UserName";
        private const string _KeyName2 = "Password";

        private static bool ResetLoginInfoFromRegistry()
        {
            try
            {
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey SubKey = BaseKey.OpenSubKey(_LoginInfoPath, true))
                    {
                        if (SubKey != null)
                        {
                            SubKey.DeleteValue(_KeyName1);
                            SubKey.DeleteValue(_KeyName2);
                            return true;
                        }
                    }
                }

            }
            catch (Exception)
            {
            }
            return false;
        }

        private static bool CreateSubKey(string SubKeyPath)
        {
            try
            {
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey SubKey = BaseKey.OpenSubKey(SubKeyPath, true))
                    {
                        if (SubKey == null)
                            BaseKey.CreateSubKey(SubKeyPath);
                        
                        return true;
                    }
                }
            }
            catch (Exception)
            { }

            return false;
        }

        public static bool SaveLoginToRegistry(string UserName, string Password)
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
                return ResetLoginInfoFromRegistry();

            if (!CreateSubKey(_LoginInfoPath))
                return false;

            try
            {
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey SubKey = BaseKey.OpenSubKey(_LoginInfoPath, true))
                    {
                        if (SubKey != null)
                        {
                            SubKey.SetValue(_KeyName1, UserName, RegistryValueKind.String);
                            SubKey.SetValue(_KeyName2, Password, RegistryValueKind.String);
                            return true;
                        }
                    }
                }

            }
            catch (Exception)
            {
                ResetLoginInfoFromRegistry();
            }

            return false;
        }

        public static bool LoadLoginInfoFromRegistry(ref string UserName, ref string Password)
        {
            try
            {
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey SubKey = BaseKey.OpenSubKey(_LoginInfoPath, true))
                    {
                        if (SubKey != null)
                        {
                            string ValueUserName = SubKey.GetValue(_KeyName1, null) as string;
                            string ValuePassword = SubKey.GetValue(_KeyName2, null) as string;

                            if (ValueUserName != null && ValuePassword != null)
                            {

                                UserName = ValueUserName;
                                Password = ValuePassword;
                                return true;
                            }
                        }
                    }
                }


            }
            catch (Exception)
            {

            }

            return false;
        }
    }
}
