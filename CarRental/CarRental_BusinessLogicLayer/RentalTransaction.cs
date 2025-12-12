
using System;
using System.Data;
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

            this.Mode = enMode.AddNew;
        }

        private clsRentalTransaction(int TransactionID, int BookingID, int ReturnID, string PaymentDetails, float PaidInitialTotalDueAmount, float ActualTotalDueAmount, float TotalRemaining, float TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
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

            this.Mode = enMode.Update;
        }


        private bool _AddNewRentalTransaction()
        {
            this.TransactionID = clsRentalTransactionDataAccess.AddNewRentalTransaction(this.BookingID.GetValueOrDefault(), this.ReturnID.GetValueOrDefault(), this.PaymentDetails, this.PaidInitialTotalDueAmount.GetValueOrDefault(), this.ActualTotalDueAmount.GetValueOrDefault(), this.TotalRemaining.GetValueOrDefault(), this.TotalRefundedAmount.GetValueOrDefault(), DateTime.Now.Date, this.UpdatedTransactionDate.GetValueOrDefault());
            return (this.TransactionID != null);
        }


        private bool _UpdateRentalTransaction()
        {
            return clsRentalTransactionDataAccess.UpdateRentalTransaction(this.TransactionID.GetValueOrDefault(), this.BookingID.GetValueOrDefault(), this.ReturnID.GetValueOrDefault(), this.PaymentDetails, this.PaidInitialTotalDueAmount.GetValueOrDefault(), this.ActualTotalDueAmount.GetValueOrDefault(), this.TotalRemaining.GetValueOrDefault(), this.TotalRefundedAmount.GetValueOrDefault(), this.TransactionDate.GetValueOrDefault(), DateTime.Now.Date);
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
            float PaidInitialTotalDueAmount = 0, ActualTotalDueAmount = 0, TotalRemaining = 0, TotalRefundedAmount = 0;
            DateTime TransactionDate = DateTime.Now, UpdatedTransactionDate = DateTime.Now;

            if (clsRentalTransactionDataAccess.FindRentalTransactionByTransactionID(TransactionID, ref BookingID, ref ReturnID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                return new clsRentalTransaction(TransactionID, BookingID, ReturnID.Value, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);

            return null;
        }

        public static bool DeleteRentalTransaction(int TransactionID)
        {
            return clsRentalTransactionDataAccess.DeleteRentalTransaction(TransactionID);
        }

        public static DataTable GetAllRentalTransactions()
        {
            return clsRentalTransactionDataAccess.GetAllRentalTransactions();
        }

        public static bool IsRentalTransactionExists(int TransactionID)
        {
            return clsRentalTransactionDataAccess.IsRentalTransactionExists(TransactionID);
        }
    }
}
