using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsMake
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? MakeID { set; get; }
        public string MakeName { set; get; }

        public clsMake()
        {
            this.MakeID = null;
            this.MakeName = null;

            this.Mode = enMode.AddNew;
        }

        private clsMake(int MakeID, string MakeName)
        {
            this.MakeID = MakeID;
            this.MakeName = MakeName;

            this.Mode = enMode.Update;
        }

        private bool _AddNewMake()
        {
            this.MakeID = clsMakeDataAccess.AddNewMake(this.MakeName);
            return (this.MakeID != null);
        }

        private bool _UpdateMake()
        {
            return clsMakeDataAccess.UpdateMake(this.MakeID.GetValueOrDefault(), this.MakeName);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMake())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateMake();
            }

            return false;
        }

        public static clsMake FindMakeByID(int MakeID)
        {
            string MakeName = string.Empty;

            if (clsMakeDataAccess.FindMakeByID(MakeID, ref MakeName))
                return new clsMake(MakeID, MakeName);

            return null;
        }

        public static clsMake FindMakeByMakeName(string MakeName)
        {
            int MakeID = -1;

            if (clsMakeDataAccess.FindMakeByMakeName(MakeName, ref MakeID))
                return new clsMake(MakeID, MakeName);

            return null;
        }

        public static bool DeleteMake(int MakeID)
        {
            return clsMakeDataAccess.DeleteMake(MakeID);
        }

        public static DataTable GetAllMakes()
        {
            return clsMakeDataAccess.GetAllMakes();
        }

        public static bool IsMakeExistsByID(int MakeID)
        {
            return clsMakeDataAccess.IsMakeExistsByID(MakeID);
        }

        public static bool IsMakeExistsByMakeName(string MakeName)
        {
            return clsMakeDataAccess.IsMakeExistsByMakeName(MakeName);
        }
    }
}
