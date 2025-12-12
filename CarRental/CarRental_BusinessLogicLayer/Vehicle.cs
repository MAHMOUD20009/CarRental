using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsVehicle
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? VehicleID { set; get; }
        public string Make { set; get; }
        public string Model { set; get; }
        public int? Year { set; get; }
        public int? Mileage { set; get; }
        public int? FuelTypeID { set; get; }
        public string PlateNumber { set; get; }
        public int? CarCategoryID { set; get; }
        public float? RentalPricePerDay { set; get; }
        public bool? IsAvailableForRent { set; get; }

        public clsVehicle()
        {
            this.VehicleID = null;
            this.Make = null;
            this.Model = null;
            this.Year = null;
            this.Mileage = null;
            this.FuelTypeID = null;
            this.PlateNumber = null;
            this.CarCategoryID = null;
            this.RentalPricePerDay = null;
            this.IsAvailableForRent = null;

            this.Mode = enMode.AddNew;
        }

        private clsVehicle(int VehicleID, string Make, string Model, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, float RentalPricePerDay, bool IsAvailableForRent)
        {
            this.VehicleID = VehicleID;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Mileage = Mileage;
            this.FuelTypeID = FuelTypeID;
            this.PlateNumber = PlateNumber;
            this.CarCategoryID = CarCategoryID;
            this.RentalPricePerDay = RentalPricePerDay;
            this.IsAvailableForRent = IsAvailableForRent;

            this.Mode = enMode.Update;
        }

        private bool _AddNewVehicle()
        {
            this.VehicleID = clsVehicleDataAccess.AddNewVehicle(this.Make, this.Model, this.Year.GetValueOrDefault(), this.Mileage.GetValueOrDefault(), this.FuelTypeID.GetValueOrDefault(), this.PlateNumber, this.CarCategoryID.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.IsAvailableForRent.GetValueOrDefault());
            return (this.VehicleID != null);
        }


        private bool _UpdateVehicle()
        {
            return clsVehicleDataAccess.UpdateVehicle(this.VehicleID.GetValueOrDefault(), this.Make, this.Model, this.Year.GetValueOrDefault(), this.Mileage.GetValueOrDefault(), this.FuelTypeID.GetValueOrDefault(), this.PlateNumber, this.CarCategoryID.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.IsAvailableForRent.GetValueOrDefault());
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

        public static clsVehicle FindVehicleByVehicleID(int VehicleID)
        {
            string Make = string.Empty, Model = string.Empty, PlateNumber = string.Empty;
            int Year = -1, Mileage = -1, FuelTypeID = -1, CarCategoryID = -1;
            float RentalPricePerDay = 0;
            bool IsAvailableForRent = false;

            if (clsVehicleDataAccess.FindVehicleByVehicleID(VehicleID, ref Make, ref Model, ref Year, ref Mileage, ref FuelTypeID, ref PlateNumber, ref CarCategoryID, ref RentalPricePerDay, ref IsAvailableForRent))
                return new clsVehicle(VehicleID, Make, Model, Year, Mileage, FuelTypeID, PlateNumber, CarCategoryID, RentalPricePerDay, IsAvailableForRent);

            return null;
        }

        public static bool DeleteVehicle(int VehicleID)
        {
            return clsVehicleDataAccess.DeleteVehicle(VehicleID);
        }

        public static DataTable GetAllVehicles()
        {
            return clsVehicleDataAccess.GetAllVehicles();
        }

        public static bool IsVehicleExists(int VehicleID)
        {
            return clsVehicleDataAccess.IsVehicleExists(VehicleID);
        }
    }
}
