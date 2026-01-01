using System;
using System.Data;
using System.Threading.Tasks;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public enum enPermissions { AllPermissions = -1, MangePeople = 1, MangeCustomers = 2, MangeVehicles = 4, MangeBookings = 8, MangeTransactions = 16, MangeReturns = 32, MangeUsers = 64 }

        public int? UserID { set; get; }
        public int? PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int? Permissions { set; get; }
        public bool? IsActive { set; get; }

        private string OldPassword;

        public clsPerson PersonInfo;

        public clsUser()
        {
            this.UserID = null;
            this.PersonID = null;
            this.UserName = null;
            this.Password = null;
            this.Permissions = null;
            this.IsActive = null;
            this.OldPassword = null;

            this.PersonInfo = new clsPerson();

            this.Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, int Permissions, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.OldPassword = Password;
            this.Permissions = Permissions;
            this.IsActive = IsActive;
            this.PersonInfo = clsPerson.FindPerson(PersonID);

            this.Mode = enMode.Update;
        }


        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID.GetValueOrDefault(), this.UserName, clsSecurityUtils.Encryption(this.Password), this.Permissions.GetValueOrDefault(), this.IsActive.GetValueOrDefault());
            return (this.UserID != null);
        }

        private bool _UpdateUser()
        {
            string FinalPassword = (this.Password == this.OldPassword) ? this.Password : clsSecurityUtils.Encryption(this.Password);

            return clsUserDataAccess.UpdateUser(this.UserID.GetValueOrDefault(), this.PersonID.GetValueOrDefault(), this.UserName, FinalPassword, this.Permissions.GetValueOrDefault(), this.IsActive.GetValueOrDefault());
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static clsUser FindUser(int UserID)
        {
            int PersonID = -1, Permissions = 0;
            string UserName = string.Empty, Password = string.Empty;
            bool IsActive = false;

            if (clsUserDataAccess.FindUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref Permissions, ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, Permissions, IsActive);

            return null;
        }

        public static clsUser FindUserByPersonID(int PersonID)
        {
            int UserID = -1, Permissions = 0;
            string UserName = string.Empty, Password = string.Empty;
            bool IsActive = false;

            if (clsUserDataAccess.FindUserByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref Permissions, ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, Permissions, IsActive);

            return null;
        }

        public static clsUser FindUser(string UserName)
        {
            int UserID = -1, PersonID = -1, Permissions = 0;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUserDataAccess.FindUserByUserName(UserName, ref PersonID, ref UserID, ref Password, ref Permissions, ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, Permissions, IsActive);

            return null;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        public static async Task<DataTable> GetPagedUsers(int PageNumber, int RowsPerPage)
        {
            return await clsUserDataAccess.GetPagedUsers(PageNumber, RowsPerPage);
        }

        public bool CheckUserPermission(enPermissions Permission)
        {
            return ((this.Permissions == (int)enPermissions.AllPermissions) || ((int)Permission & this.Permissions) == (int)Permission);
        }

        public static bool IsUserExists(int UserID)
        {
            return clsUserDataAccess.IsUserExists(UserID);
        }

        public static bool IsUserExistsByPersonID(int PersonID)
        {
            return clsUserDataAccess.IsUserExistsByPersonID(PersonID);
        }

        public static bool IsUserExists(string UserName)
        {
            return clsUserDataAccess.IsUserExists(UserName);
        }

        public static int GetUserCount()
        {
            return clsUserDataAccess.GetUserCount();
        }

        public static int GetPageCount(int RowsPerPage = 100)
        {
            return clsUserDataAccess.GetPageCount(RowsPerPage);
        }
    }
}
