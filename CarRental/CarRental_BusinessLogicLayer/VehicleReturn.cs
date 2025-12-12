using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsVehicleReturn
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? ReturnID { set; get; }
        public DateTime? ActualReturnDate { set; get; }
        public byte? ActualRentalDays { set; get; }
        public short? Mileage { set; get; }
        public short? ConsumedMileage { set; get; }
        public string FinalCheckNotes { set; get; }
        public float? AdditionalCharges { set; get; }
        public float? ActualTotalDueAmount { set; get; }

        public int? BookingID { set; get; }

        public clsVehicleReturn()
        {
            this.ReturnID = null;
            this.ActualReturnDate = null;
            this.ActualRentalDays = null;
            this.Mileage = null;
            this.ConsumedMileage = null;
            this.FinalCheckNotes = null;
            this.AdditionalCharges = null;
            this.ActualTotalDueAmount = null;

            this.Mode = enMode.AddNew;
        }

        private clsVehicleReturn(int ReturnID, DateTime ActualReturnDate, byte ActualRentalDays, short Mileage, short ConsumedMileage, string FinalCheckNotes, float AdditionalCharges, float ActualTotalDueAmount)
        {
            this.ReturnID = ReturnID;
            this.ActualReturnDate = ActualReturnDate;
            this.ActualRentalDays = ActualRentalDays;
            this.Mileage = Mileage;
            this.ConsumedMileage = ConsumedMileage;
            this.FinalCheckNotes = FinalCheckNotes;
            this.AdditionalCharges = AdditionalCharges;
            this.ActualTotalDueAmount = ActualTotalDueAmount;

            this.Mode = enMode.Update;
        }

        private bool _AddNewVehicleReturn()
        {
            this.ReturnID = clsVehicleReturnDataAccess.AddNewVehicleReturn(this.ActualReturnDate.GetValueOrDefault(), this.ActualRentalDays.GetValueOrDefault(), this.Mileage.GetValueOrDefault(), this.ConsumedMileage.GetValueOrDefault(), this.FinalCheckNotes, this.AdditionalCharges.GetValueOrDefault(), this.ActualTotalDueAmount.GetValueOrDefault(), this.BookingID.GetValueOrDefault());
            return (this.ReturnID != null);
        }

        private bool _UpdateVehicleReturn()
        {
            return clsVehicleReturnDataAccess.UpdateVehicleReturn(this.ReturnID.GetValueOrDefault(), this.ActualReturnDate.GetValueOrDefault(), this.ActualRentalDays.GetValueOrDefault(), this.Mileage.GetValueOrDefault(), this.ConsumedMileage.GetValueOrDefault(), this.FinalCheckNotes, this.AdditionalCharges.GetValueOrDefault(), this.ActualTotalDueAmount.GetValueOrDefault());
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleReturn())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateVehicleReturn();
            }

            return false;
        }

        public static clsVehicleReturn FindVehicleReturn(int ReturnID)
        {
            DateTime ActualReturnDate = DateTime.Now;
            byte ActualRentalDays = 0;
            short Mileage = 0, ConsumedMileage = 0;
            string FinalCheckNotes = string.Empty;
            float AdditionalCharges = 0, ActualTotalDueAmount = 0;

            if (clsVehicleReturnDataAccess.FindVehicleReturn(ReturnID, ref ActualReturnDate, ref ActualRentalDays, ref Mileage, ref ConsumedMileage, ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount))
                return new clsVehicleReturn(ReturnID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount);

            return null;
        }

        public static bool DeleteVehicleReturn(int ReturnID)
        {
            return clsVehicleReturnDataAccess.DeleteVehicleReturn(ReturnID);
        }

        public static DataTable GetAllVehicleReturns()
        {
            return clsVehicleReturnDataAccess.GetAllVehicleReturns();
        }

        public static bool IsVehicleReturnExists(int ReturnID)
        {
            return clsVehicleReturnDataAccess.IsVehicleReturnExists(ReturnID);
        }
    }
}
