
using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsRentalBooking
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? BookingID { set; get; }
        public int? CustomerID { set; get; }
        public int? VehicleID { set; get; }
        public DateTime? RentalStartDate { set; get; }
        public DateTime? RentalEndDate { set; get; }
        public string PickupLocation { set; get; }
        public string DropoffLocation { set; get; }
        public byte? InitialRentalDays { set; get; }
        public float? RentalPricePerDay { set; get; }
        public float? InitialTotalDueAmount { set; get; }
        public string InitialCheckNotes { set; get; }

        public clsRentalBooking()
        {
            this.BookingID = null;
            this.CustomerID = null;
            this.VehicleID = null;
            this.RentalStartDate = null;
            this.RentalEndDate = null;
            this.PickupLocation = null;
            this.DropoffLocation = null;
            this.InitialRentalDays = null;
            this.RentalPricePerDay = null;
            this.InitialTotalDueAmount = null;
            this.InitialCheckNotes = null;

            this.Mode = enMode.AddNew;
        }

        private clsRentalBooking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, byte InitialRentalDays, float RentalPricePerDay, float InitialTotalDueAmount, string InitialCheckNotes)
        {
            this.BookingID = BookingID;
            this.CustomerID = CustomerID;
            this.VehicleID = VehicleID;
            this.RentalStartDate = RentalStartDate;
            this.RentalEndDate = RentalEndDate;
            this.PickupLocation = PickupLocation;
            this.DropoffLocation = DropoffLocation;
            this.InitialRentalDays = InitialRentalDays;
            this.RentalPricePerDay = RentalPricePerDay;
            this.InitialTotalDueAmount = InitialTotalDueAmount;
            this.InitialCheckNotes = InitialCheckNotes;

            this.Mode = enMode.Update;
        }


        private bool _AddNewRentalBooking()
        {
            this.BookingID = clsRentalBookingDataAccess.AddNewRentalBooking(this.CustomerID.GetValueOrDefault(), this.VehicleID.GetValueOrDefault(), this.RentalStartDate.GetValueOrDefault(), this.RentalEndDate.GetValueOrDefault(), this.PickupLocation, this.DropoffLocation, this.InitialRentalDays.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.InitialTotalDueAmount.GetValueOrDefault(), this.InitialCheckNotes);
            return (this.BookingID != null);
        }


        private bool _UpdateRentalBooking()
        {
            return clsRentalBookingDataAccess.UpdateRentalBooking(this.BookingID.GetValueOrDefault(), this.CustomerID.GetValueOrDefault(), this.VehicleID.GetValueOrDefault(), this.RentalStartDate.GetValueOrDefault(), this.RentalEndDate.GetValueOrDefault(), this.PickupLocation, this.DropoffLocation, this.InitialRentalDays.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.InitialTotalDueAmount.GetValueOrDefault(), this.InitialCheckNotes);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalBooking())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateRentalBooking();
            }

            return false;
        }

        public static clsRentalBooking FindRentalBooking(int BookingID)
        {
            int CustomerID = -1, VehicleID = -1;
            DateTime RentalStartDate = DateTime.Now, RentalEndDate = DateTime.Now;
            string PickupLocation = string.Empty, DropoffLocation = string.Empty, InitialCheckNotes = string.Empty;
            float RentalPricePerDay = 0, InitialTotalDueAmount = 0; 
            byte InitialRentalDays = 0;

            if (clsRentalBookingDataAccess.FindRentalBookingByBookingID(BookingID, ref CustomerID, ref VehicleID, ref RentalStartDate, ref RentalEndDate, ref PickupLocation, ref DropoffLocation, ref InitialRentalDays, ref RentalPricePerDay, ref InitialTotalDueAmount, ref InitialCheckNotes))
                return new clsRentalBooking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);

            return null;
        }

        public static bool DeleteRentalBooking(int BookingID)
        {
            return clsRentalBookingDataAccess.DeleteRentalBooking(BookingID);
        }

        public static DataTable GetAllRentalBooking()
        {
            return clsRentalBookingDataAccess.GetAllRentalBooking();
        }

        public static bool IsRentalBookingExists(int BookingID)
        {
            return clsRentalBookingDataAccess.IsRentalBookingExists(BookingID);
        }
    }
}
