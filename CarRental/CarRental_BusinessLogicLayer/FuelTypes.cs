
using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsFuelType
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? ID { set; get; }
        public string FuelType { set; get; }

        public clsFuelType()
        {
            this.ID = null;
            this.FuelType = null;

            this.Mode = enMode.AddNew;
        }

        private clsFuelType(int ID, string FuelType)
        {
            this.ID = ID;
            this.FuelType = FuelType;

            this.Mode = enMode.Update;
        }


        private bool _AddNewFuelType()
        {
            this.ID = clsFuelTypeDataAccess.AddNewFuelType(this.FuelType);
            return (this.ID != null);
        }


        private bool _UpdateFuelType()
        {
            return clsFuelTypeDataAccess.UpdateFuelType(this.ID.GetValueOrDefault(), this.FuelType);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFuelType())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateFuelType();
            }

            return false;
        }

        public static clsFuelType FindFuelType(int ID)
        {
            string FuelType = string.Empty;

            if (clsFuelTypeDataAccess.FindFuelTypeByID(ID, ref FuelType))
                return new clsFuelType(ID, FuelType);

            return null;
        }

        public static clsFuelType FindFuelType(string FuelType)
        {
            int ID = -1;

            if (clsFuelTypeDataAccess.FindFuelTypeByFuelType(FuelType, ref ID))
                return new clsFuelType(ID, FuelType);

            return null;
        }

        public static bool DeleteFuelType(int ID)
        {
            return clsFuelTypeDataAccess.DeleteFuelType(ID);
        }

        public static DataTable GetAllFuelTypes()
        {
            return clsFuelTypeDataAccess.GetAllFuelTypes();
        }

        public static bool IsFuelTypeExists(int ID)
        {
            return clsFuelTypeDataAccess.IsFuelTypeExists(ID);
        }
    }
}
