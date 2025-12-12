using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsVehicleCategory
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? CategoryID { set; get; }
        public string CategoryName { set; get; }

        public clsVehicleCategory()
        {
            this.CategoryID = null;
            this.CategoryName = null;

            this.Mode = enMode.AddNew;
        }

        private clsVehicleCategory(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;

            this.Mode = enMode.Update;
        }

        private bool _AddNewVehicleCategory()
        {
            this.CategoryID = clsVehicleCategoryDataAccess.AddNewVehicleCategory(this.CategoryName);
            return (this.CategoryID != null);
        }

        private bool _UpdateVehicleCategory()
        {
            return clsVehicleCategoryDataAccess.UpdateVehicleCategory(this.CategoryID.GetValueOrDefault(), this.CategoryName);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleCategory())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateVehicleCategory();
            }

            return false;
        }

        public static clsVehicleCategory FindVehicleCategory(int CategoryID)
        {
            string CategoryName = string.Empty;

            if (clsVehicleCategoryDataAccess.FindVehicleCategoryByCategoryID(CategoryID, ref CategoryName))
                return new clsVehicleCategory(CategoryID, CategoryName);

            return null;
        }

        public static clsVehicleCategory FindVehicleCategory(string CategoryName)
        {
            int CategoryID = -1;

            if (clsVehicleCategoryDataAccess.FindVehicleCategoryByCategoryName(CategoryName, ref CategoryID))
                return new clsVehicleCategory(CategoryID, CategoryName);

            return null;
        }

        public static bool DeleteVehicleCategory(int CategoryID)
        {
            return clsVehicleCategoryDataAccess.DeleteVehicleCategory(CategoryID);
        }

        public static DataTable GetAllVehicleCategories()
        {
            return clsVehicleCategoryDataAccess.GetAllVehicleCategories();
        }
    
        public static bool IsVehicleCategoryExists(int CategoryID)
        {
            return clsVehicleCategoryDataAccess.IsVehicleCategoryExists(CategoryID);
        }

        public static bool IsVehicleCategoryExists(string CategoryName)
        {
            return clsVehicleCategoryDataAccess.IsVehicleCategoryExists(CategoryName);
        }
    }
}
