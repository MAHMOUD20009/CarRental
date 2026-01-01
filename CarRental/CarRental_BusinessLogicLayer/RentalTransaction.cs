using System;
using System.Data;
using System.Threading.Tasks;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsRentalTransaction
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? TransactionID { set; get; }
        public int? BookingID { set; get; }
        public int? ReturnID { set; get; }
        public string PaymentDetails { set; get; }
        public float? PaidInitialTotalDueAmount { set; get; }
        public float? ActualTotalDueAmount { set; get; }
        public float? TotalRemaining { set; get; }
        public float? TotalRefundedAmount { set; get; }
        public DateTime? TransactionDate { set; get; }
        public DateTime? UpdatedTransactionDate { set; get; }

        public clsVehicleReturn VehicleReturnInfo;


        public clsRentalTransaction()
        {
            this.TransactionID = null;
            this.BookingID = null;
            this.ReturnID = null;
            this.PaymentDetails = null;
            this.PaidInitialTotalDueAmount = null;
            this.ActualTotalDueAmount = null;
            this.TotalRemaining = null;
            this.TotalRefundedAmount = null;
            this.TransactionDate = null;
            this.UpdatedTransactionDate = null;

            this.VehicleReturnInfo = new clsVehicleReturn();

            this.Mode = enMode.AddNew;
        }

        private clsRentalTransaction(int TransactionID, int BookingID, int? ReturnID, string PaymentDetails, float PaidInitialTotalDueAmount, float? ActualTotalDueAmount, float? TotalRemaining, float? TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            this.TransactionID = TransactionID;
            this.BookingID = BookingID;
            this.ReturnID = ReturnID;
            this.PaymentDetails = PaymentDetails;
            this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TotalRemaining = TotalRemaining;
            this.TotalRefundedAmount = TotalRefundedAmount;
            this.TransactionDate = TransactionDate;
            this.UpdatedTransactionDate = UpdatedTransactionDate;

            if (this.ReturnID.HasValue)
                this.VehicleReturnInfo = clsVehicleReturn.FindVehicleReturnByID(ReturnID.Value);

            this.Mode = enMode.Update;
        }

        private bool _AddNewRentalTransaction()
        {
            this.TransactionID = clsRentalTransactionDataAccess.AddNewRentalTransaction(this.BookingID.Value, this.ReturnID, this.PaymentDetails, this.PaidInitialTotalDueAmount.Value, this.ActualTotalDueAmount, this.TotalRemaining, this.TotalRefundedAmount, DateTime.Now.Date, DateTime.Now.Date);
            return (this.TransactionID != null);
        }

        private bool _UpdateRentalTransaction()
        {
            return clsRentalTransactionDataAccess.UpdateRentalTransaction(this.TransactionID.Value, this.BookingID.Value, this.ReturnID, this.PaymentDetails, this.PaidInitialTotalDueAmount.Value, this.ActualTotalDueAmount, this.TotalRemaining, this.TotalRefundedAmount, this.TransactionDate.Value, DateTime.Now.Date);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalTransaction())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateRentalTransaction();
            }

            return false;
        }

        public static clsRentalTransaction FindRentalTransactionByTransactionID(int TransactionID)
        {
            int BookingID = -1;
            int? ReturnID = -1;
            string PaymentDetails = string.Empty;
            float PaidInitialTotalDueAmount = 0;
            float? ActualTotalDueAmount = 0, TotalRemaining = 0, TotalRefundedAmount = 0;
            DateTime TransactionDate = DateTime.Now, UpdatedTransactionDate = DateTime.Now;

            if (clsRentalTransactionDataAccess.FindRentalTransactionByTransactionID(TransactionID, ref BookingID, ref ReturnID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                return new clsRentalTransaction(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);

            return null;
        }

        public static clsRentalTransaction FindRentalTransactionByBookingID(int BookingID)
        {
            int TransactionID = -1;
            int? ReturnID = -1;
            string PaymentDetails = string.Empty;
            float PaidInitialTotalDueAmount = 0;
            float? ActualTotalDueAmount = 0, TotalRemaining = 0, TotalRefundedAmount = 0;
            DateTime TransactionDate = DateTime.Now, UpdatedTransactionDate = DateTime.Now;

            if (clsRentalTransactionDataAccess.FindRentalTransactionByBookingID(BookingID, ref TransactionID, ref ReturnID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                return new clsRentalTransaction(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            return null;
        }

        public static clsRentalTransaction FindRentalTransactionByReturnID(int ReturnID)
        {
            int TransactionID = -1, BookingID = -1;
            string PaymentDetails = string.Empty;
            float PaidInitialTotalDueAmount = 0;
            float? ActualTotalDueAmount = 0, TotalRemaining = 0, TotalRefundedAmount = 0;
            DateTime TransactionDate = DateTime.Now, UpdatedTransactionDate = DateTime.Now;

            if (clsRentalTransactionDataAccess.FindRentalTransactionByReturnID(ReturnID, ref TransactionID, ref BookingID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                return new clsRentalTransaction(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);

            return null;
        }

        public static bool DeleteRentalTransaction(int TransactionID)
        {
            return clsRentalTransactionDataAccess.DeleteRentalTransaction(TransactionID);
        }

        public static async Task<DataTable> GetPagedTransactions(int PageNumber, int RowsPerPage)
        {
            return await clsRentalTransactionDataAccess.GetPagedTransactions(PageNumber, RowsPerPage);
        }

        public static bool IsRentalTransationExistsByTransactionID(int TransactionID)
        {
            return clsRentalTransactionDataAccess.IsRentalTransationExistsByTransactionID(TransactionID);
        }

        public static bool IsRentalTransationExistsByBookingID(int BookingID)
        {
            return clsRentalTransactionDataAccess.IsRentalTransationExistsByBookingID(BookingID);
        }

        public static int GetTransactionCount()
        {
            return clsRentalTransactionDataAccess.GetTransactionCount();
        }

        public static int GetPageCount(int RowsPerPage = 100)
        {
            return clsRentalTransactionDataAccess.GetPageCount(RowsPerPage);
        }
    }
}
