using System;
using System.Data;
using System.Threading.Tasks;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsRentalBooking
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

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

        public bool IsVehicledReturned { set; get; }

        public clsCustomer CustomerInfo;
        public clsVehicle VehicleInfo;
        public clsRentalTransaction TransactionInfo;

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

            this.CustomerInfo = new clsCustomer();
            this.VehicleInfo = new clsVehicle();
            this.TransactionInfo = new clsRentalTransaction();

            this._Mode = enMode.AddNew;
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

            this.CustomerInfo = clsCustomer.FindCustomerByCustomerID(CustomerID);
            this.VehicleInfo = clsVehicle.FindVehicle(VehicleID);
            this.TransactionInfo = clsRentalTransaction.FindRentalTransactionByBookingID(BookingID);

            if (this.TransactionInfo == null)
                this.TransactionInfo = new clsRentalTransaction();

            this.IsVehicledReturned = IsVehicleReturned(BookingID);

            this._Mode = enMode.Update;
        }

        private bool _AddNewRentalBooking(string PaymentDetails)
        {
            this.BookingID = clsRentalBookingDataAccess.AddNewRentalBooking(this.CustomerID.GetValueOrDefault(), this.VehicleID.GetValueOrDefault(), this.RentalStartDate.GetValueOrDefault(), this.RentalEndDate.GetValueOrDefault(), this.PickupLocation, this.DropoffLocation, this.InitialRentalDays.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.InitialTotalDueAmount.GetValueOrDefault(), this.InitialCheckNotes);

            if (this.BookingID != null)
            {
                var Transaction = new clsRentalTransaction();
                Transaction.BookingID = this.BookingID;
                Transaction.ReturnID = null;
                Transaction.PaymentDetails = PaymentDetails;
                Transaction.PaidInitialTotalDueAmount = this.InitialTotalDueAmount;
                Transaction.ActualTotalDueAmount = null;
                Transaction.TotalRemaining = null;
                Transaction.TotalRefundedAmount = null;

                if (Transaction.Save())
                    return true;

                clsRentalBooking.DeleteBooking(this.BookingID.Value);
            }

            return false;
        }

        private bool _UpdateRentalBooking(string PaymentDetails)
        {
            var Transaction = clsRentalTransaction.FindRentalTransactionByBookingID(this.BookingID.Value);
            if (Transaction != null)
            {
                Transaction.PaymentDetails = PaymentDetails;
                Transaction.PaidInitialTotalDueAmount = this.InitialTotalDueAmount;
                Transaction.Save();
            }

            return clsRentalBookingDataAccess.UpdateRentalBooking(this.BookingID.GetValueOrDefault(), this.CustomerID.GetValueOrDefault(), this.VehicleID.GetValueOrDefault(), this.RentalStartDate.GetValueOrDefault(), this.RentalEndDate.GetValueOrDefault(), this.PickupLocation, this.DropoffLocation, this.InitialRentalDays.GetValueOrDefault(), this.RentalPricePerDay.GetValueOrDefault(), this.InitialTotalDueAmount.GetValueOrDefault(), this.InitialCheckNotes);
        }

        public bool Save(string PaymentDetails)
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalBooking(PaymentDetails))
                    {
                        this._Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateRentalBooking(PaymentDetails);
            }

            return false;
        }

        public static clsRentalBooking FindRentalBookingByID(int BookingID)
        {
            int CustomerID = -1, VehicleID = -1;
            DateTime RentalStartDate = DateTime.Now, RentalEndDate = DateTime.Now;
            string PickupLocation = string.Empty, DropoffLocation = string.Empty, InitialCheckNotes = string.Empty;
            float RentalPricePerDay = 0, InitialTotalDueAmount = 0;
            byte InitialRentalDays = 0;

            if (clsRentalBookingDataAccess.FindRentalBookingByID(BookingID, ref CustomerID, ref VehicleID, ref RentalStartDate, ref RentalEndDate, ref PickupLocation, ref DropoffLocation, ref InitialRentalDays, ref RentalPricePerDay, ref InitialTotalDueAmount, ref InitialCheckNotes))
                return new clsRentalBooking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);

            return null;
        }

        public static clsRentalBooking FindRentalBookingByReturnID(int ReturnID)
        {
            int BookingID = -1, CustomerID = -1, VehicleID = -1;
            DateTime RentalStartDate = DateTime.Now, RentalEndDate = DateTime.Now;
            string PickupLocation = string.Empty, DropoffLocation = string.Empty, InitialCheckNotes = string.Empty;
            float RentalPricePerDay = 0, InitialTotalDueAmount = 0;
            byte InitialRentalDays = 0;

            if (clsRentalBookingDataAccess.FindRentalBookingByReturnID(ReturnID, ref BookingID, ref CustomerID, ref VehicleID, ref RentalStartDate, ref RentalEndDate, ref PickupLocation, ref DropoffLocation, ref InitialRentalDays, ref RentalPricePerDay, ref InitialTotalDueAmount, ref InitialCheckNotes))
                return new clsRentalBooking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);

            return null;
        }

        public static bool DeleteBooking(int BookingID)
        {
            return clsRentalBookingDataAccess.DeleteRentalBooking(BookingID);
        }

        public static async Task<DataTable> GetPagedBookings(int PageNumber = 1, int RowsPerPage = 50)
        {
            return await clsRentalBookingDataAccess.GetPagedBookings(PageNumber, RowsPerPage);
        }

        public static bool IsRentalBookingExists(int BookingID)
        {
            return clsRentalBookingDataAccess.IsRentalBookingExists(BookingID);
        }

        public static int GetTotalBookings()
        {
            return clsRentalBookingDataAccess.GetBookingCount();
        }

        public static int GetPageCount(int RowsPerPage = 100)
        {
            return clsRentalBookingDataAccess.GetPageCount(RowsPerPage);
        }

        public static bool IsVehicleReturned(int BookingID)
        {
            return clsRentalBookingDataAccess.IsVehicleReturned(BookingID);
        }
    }
}
