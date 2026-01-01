using System;
using System.Data;
using System.Threading.Tasks;
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
        public int? Mileage { set; get; }
        public int? ConsumedMileage { set; get; }
        public string FinalCheckNotes { set; get; }
        public float? AdditionalCharges { set; get; }
        public float? ActualTotalDueAmount { set; get; }

        public clsRentalBooking BookingInfo;

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

        private clsVehicleReturn(int ReturnID, DateTime ActualReturnDate, byte ActualRentalDays, int Mileage, int ConsumedMileage, string FinalCheckNotes, float AdditionalCharges, float ActualTotalDueAmount)
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

        private bool _AddNewVehicleReturn(int BookingID)
        {
            this.ReturnID = clsVehicleReturnDataAccess.AddNewVehicleReturn(this.ActualReturnDate.Value, this.ActualRentalDays.Value, this.Mileage.Value, this.ConsumedMileage.Value, this.FinalCheckNotes, this.AdditionalCharges.Value, this.ActualTotalDueAmount.Value, BookingID);
            return (this.ReturnID != null);
        }

        private bool _UpdateVehicleReturn(/*int BookingID*/)
        {
            return clsVehicleReturnDataAccess.UpdateVehicleReturn(this.ReturnID.Value, this.ActualReturnDate.Value, this.ActualRentalDays.Value, this.Mileage.Value, this.ConsumedMileage.Value, this.FinalCheckNotes, this.AdditionalCharges.Value, this.ActualTotalDueAmount.Value);
        }

        public bool Save(int BookingID)
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleReturn(BookingID))
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateVehicleReturn(/*BookingID*/);
            }

            return false;
        }

        public static clsVehicleReturn FindVehicleReturnByID(int ReturnID)
        {
            DateTime ActualReturnDate = DateTime.Now;
            byte ActualRentalDays = 0;
            int Mileage = 0, ConsumedMileage = 0;
            string FinalCheckNotes = string.Empty;
            float AdditionalCharges = 0, ActualTotalDueAmount = 0;

            if (clsVehicleReturnDataAccess.FindVehicleReturnByID(ReturnID, ref ActualReturnDate, ref ActualRentalDays, ref Mileage, ref ConsumedMileage, ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount))
                return new clsVehicleReturn(ReturnID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount);

            return null;
        }

        public static clsVehicleReturn FindVehicleReturnByBookingID(int BookingID)
        {
            int ReturnID = -1;
            DateTime ActualReturnDate = DateTime.Now;
            byte ActualRentalDays = 0;
            int Mileage = 0, ConsumedMileage = 0;
            string FinalCheckNotes = string.Empty;
            float AdditionalCharges = 0, ActualTotalDueAmount = 0;

            if (clsVehicleReturnDataAccess.FindVehicleReturnByBookingID(ReturnID, ref ReturnID, ref ActualReturnDate, ref ActualRentalDays, ref Mileage, ref ConsumedMileage, ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount))
            {
                var VehicleReturn = new clsVehicleReturn(ReturnID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount);
                VehicleReturn.BookingInfo = clsRentalBooking.FindRentalBookingByID(BookingID);

                return VehicleReturn;
            }
 
            return null;
        }

        public static bool DeleteVehicleReturn(int ReturnID)
        {
            return clsVehicleReturnDataAccess.DeleteVehicleReturn(ReturnID);
        }

        public static async Task<DataTable> GetPagedReturns(int PageNumber, int RowsPerPage)
        {
            return await clsVehicleReturnDataAccess.GetPagedReturns(PageNumber, RowsPerPage);
        }

        public static bool IsVehicleReturnExists(int ReturnID)
        {
            return clsVehicleReturnDataAccess.IsVehicleReturnExists(ReturnID);
        }

        public static int GetReturnCount()
        {
            return clsVehicleReturnDataAccess.GetReturnCount();
        }
    
        public static int GetPageCount(int RowsPerPage = 100)
        {
            return clsVehicleReturnDataAccess.GetPageCount(RowsPerPage);
        }
    }
}
