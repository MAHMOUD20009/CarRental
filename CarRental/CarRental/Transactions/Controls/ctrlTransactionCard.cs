using System;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlTransactionCard : UserControl
    {
        public clsRentalTransaction Transaction { private set;  get; }

        public int? TransactionID { private set; get; }

        public ctrlTransactionCard()
        {
            InitializeComponent();
        }

        private void _FillControls()
        {
            TransactionID = Transaction.TransactionID.Value;

            lblShowTransactionID.Text = "[" + Transaction.TransactionID + "]";
            lblShowBookingID.Text = "[" + Transaction.BookingID + "]";
            lblShowReturnId.Text = (!Transaction.ReturnID.HasValue) ? "Pending Return" : "[" + Transaction.ReturnID.Value + "]";
            lblShowPaymentDetails.Text = Transaction.PaymentDetails;
            lblShowPaidInitialTotalDueAmount.Text = Transaction.PaidInitialTotalDueAmount.ToString();
            lblShowTotalRemaining.Text = (!Transaction.TotalRemaining.HasValue) ? "Pending Return" : Transaction.TotalRemaining.Value.ToString();
            lblShowActualTotalDueAmount.Text = (!Transaction.ActualTotalDueAmount.HasValue) ? "Pending Return" : Transaction.ActualTotalDueAmount.Value.ToString();
            lblShowTotalRefundedAmount.Text = (!Transaction.TotalRefundedAmount.HasValue) ? "Pending Return" : Transaction.TotalRefundedAmount.Value.ToString();
            lblShowTransactionDate.Text = Transaction.TransactionDate.Value.ToString("dd/MMM/yyyy");
            lblShowUpdatedTransactionDate.Text = Transaction.UpdatedTransactionDate.Value.ToString("dd/MMM/yyyy");
        }

        public void ResetControls()
        {
            TransactionID = null;

            lblShowTransactionID.Text = "[?????]";
            lblShowBookingID.Text = "[?????]";
            lblShowReturnId.Text = "[?????]";
            lblShowPaymentDetails.Text = "?????";
            lblShowPaidInitialTotalDueAmount.Text ="?????";
            lblShowTotalRemaining.Text = "?????";
            lblShowActualTotalDueAmount.Text = "?????";
            lblShowTotalRefundedAmount.Text = "?????";
            lblShowTransactionDate.Text = "?????";
            lblShowUpdatedTransactionDate.Text = "?????";
        }

        public void LoadTransactionInfo(int TransactionID)
        {
            Transaction = clsRentalTransaction.FindRentalTransactionByTransactionID(TransactionID);

            if (Transaction == null)
            {
                MessageBox.Show("No Transaction With Id : " + TransactionID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        public void LoadTransactionInfoByBookingID(int TransactionID)
        {
            Transaction = clsRentalTransaction.FindRentalTransactionByBookingID(TransactionID);

            if (Transaction == null)
            {
                MessageBox.Show("No Transaction With Book Id : " + TransactionID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        public void LoadTransactionInfoByReturnID(int ReturnID)
        {
            Transaction = clsRentalTransaction.FindRentalTransactionByReturnID(ReturnID);

            if (Transaction == null)
            {
                MessageBox.Show("No Transaction With Return Id : " + TransactionID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        public void LoadTransactionInfo(clsRentalTransaction Transaction)
        {
            this.Transaction = Transaction;

            if (Transaction == null)
            {
                MessageBox.Show("No record found for this Transaction", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }
    }
}
