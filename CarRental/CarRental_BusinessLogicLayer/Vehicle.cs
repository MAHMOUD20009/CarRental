using System;
using System.Data;
using System.Threading.Tasks;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsVehicle
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? VehicleID { set; get; }
        public int? MakeID { set; get; }
        public int? ModelID { set; get; }
        public int? Year { set; get; }
        public int? Mileage { set; get; }
        public int? FuelTypeID { set; get; }
        public string PlateNumber { set; get; }
        public int? CarCategoryID { set; get; }
        public float? RentalPricePerDay { set; get; }
        public bool? IsAvailableForRent { set; get; }

        public clsModel ModelInfo;
        public clsFuelType FuelTypeInfo;
        public clsVehicleCategory CarCategotyInfo;

        public clsVehicle()
        {
            this.VehicleID = null;
            this.MakeID = null;
            this.ModelID = null;
            this.Year = null;
            this.Mileage = null;
            this.FuelTypeID = null;
            this.PlateNumber = null;
            this.CarCategoryID = null;
            this.RentalPricePerDay = null;
            this.IsAvailableForRent = null;

            this.ModelInfo = new clsModel();
            this.FuelTypeInfo = new clsFuelType();
            this.CarCategotyInfo = new clsVehicleCategory();

            this.Mode = enMode.AddNew;
        }

        private clsVehicle(int VehicleID, int MakeID, int ModelID, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, float RentalPricePerDay, bool IsAvailableForRent)
        {
            this.VehicleID = VehicleID;
            this.MakeID = MakeID;
            this.ModelID = ModelID;
            this.Year = Year;
            this.Mileage = Mileage;
            this.FuelTypeID = FuelTypeID;
            this.PlateNumber = PlateNumber;
            this.CarCategoryID = CarCategoryID;
            this.RentalPricePerDay = RentalPricePerDay;
            this.IsAvailableForRent = IsAvailableForRent;

            this.ModelInfo = clsModel.FindModel(ModelID);
            this.FuelTypeInfo = clsFuelType.FindFuelType(FuelTypeID);
            this.CarCategotyInfo = clsVehicleCategory.FindVehicleCategory(CarCategoryID);

            this.Mode = enMode.Update;
        }

        private bool _AddNewVehicle()
        {
            this.VehicleID = clsVehicleDataAccess.AddNewVehicle(this.MakeID.Value, this.ModelID.Value, this.Year.GetValueOrDefault(), this.Mileage.GetValueOrDefault(), this.FuelTypeID.GetValueOrDefault(), this.PlateNumber, this.CarCategoryID.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.IsAvailableForRent.GetValueOrDefault());
            return (this.VehicleID != null);
        }


        private bool _UpdateVehicle()
        {
            return clsVehicleDataAccess.UpdateVehicle(this.VehicleID.GetValueOrDefault(), this.MakeID.GetValueOrDefault(), this.ModelID.GetValueOrDefault(), this.Year.GetValueOrDefault(), this.Mileage.GetValueOrDefault(), this.FuelTypeID.GetValueOrDefault(), this.PlateNumber, this.CarCategoryID.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.IsAvailableForRent.GetValueOrDefault());
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicle())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateVehicle();
            }

            return false;
        }

        public static clsVehicle FindVehicle(int VehicleID)
        {
            string PlateNumber = string.Empty;
            int MakeID = -1, ModelID = -1, Year = -1, Mileage = -1, FuelTypeID = -1, CarCategoryID = -1;
            float RentalPricePerDay = 0;
            bool IsAvailableForRent = false;

            if (clsVehicleDataAccess.FindVehicleByID(VehicleID, ref MakeID, ref ModelID, ref Year, ref Mileage, ref FuelTypeID, ref PlateNumber, ref CarCategoryID, ref RentalPricePerDay, ref IsAvailableForRent))
                return new clsVehicle(VehicleID, MakeID, ModelID, Year, Mileage, FuelTypeID, PlateNumber, CarCategoryID, RentalPricePerDay, IsAvailableForRent);

            return null;
        }

        public static bool DeleteVehicle(int VehicleID)
        {
            return clsVehicleDataAccess.DeleteVehicle(VehicleID);
        }

        public static async Task<DataTable> GetPagedVehicles(int PageNumber, int RowsPerPage)
        {
            return await clsVehicleDataAccess.GetPagedVehicles(PageNumber, RowsPerPage);
        }

        public static bool IsVehicleExists(int VehicleID)
        {
            return clsVehicleDataAccess.IsVehicleExists(VehicleID);
        }

        public static bool IsVehicleAvailable(int VehicleID)
        {
            return clsVehicleDataAccess.IsVehicleAvailable(VehicleID);
        }

        public static int GetVehicleCount()
        {
            return clsVehicleDataAccess.GetVehicleCount();
        }

        public static int GetTotalVehiclesAvailable()
        {
            return clsVehicleDataAccess.GetVehicleAvailableCount();
        }

        public static int GetPageCount(int RowsPerPage = 100)
        {
            return clsVehicleDataAccess.GetPageCount(RowsPerPage);
        }
    }
}
