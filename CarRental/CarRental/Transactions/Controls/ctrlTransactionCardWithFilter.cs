using System;
using System.Windows.Forms;
using CarRental.Transactions;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlTransactionCardWithFilter : UserControl
    {
        public event Action<int> OnTransactionSelected;

        protected virtual void TransactionSelected(int TransactionID)
        {
            Action<int> Handler = OnTransactionSelected;

            if (Handler != null)
            {
                Handler(TransactionID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsRentalTransaction Transaction { get { return ctrlTransactionCard1.Transaction; } }
        public int? TransactionID { get { return ctrlTransactionCard1.TransactionID; } }

        public ctrlTransactionCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "Transaction Id": ctrlTransactionCard1.LoadTransactionInfo(int.Parse(txtSearchValue.Text)); break;
                case "Booking Id": ctrlTransactionCard1.LoadTransactionInfoByBookingID(int.Parse(txtSearchValue.Text)); break;
                case "Return Id": ctrlTransactionCard1.LoadTransactionInfoByReturnID(int.Parse(txtSearchValue.Text)); break;
            }

            TransactionSelected(ctrlTransactionCard1.TransactionID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadTransactionInfo(int TransactionID)
        {
            cbFilter.SelectedIndex = 0;
            txtSearchValue.Text = TransactionID.ToString();
            FindNow();
        }

        public void LoadTransactionInfoByBookingID(int BookingID)
        {
            cbFilter.SelectedIndex = 1;
            txtSearchValue.Text = BookingID.ToString();
            FindNow();
        }

        public void LoadTransactionInfoByReturnID(int ReturnID)
        {
            cbFilter.SelectedIndex = 2;
            txtSearchValue.Text = ReturnID.ToString();
            FindNow();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                ctrlTransactionCard1.ResetControls();
                TransactionSelected(-1);
                return;
            }

            if (txtSearchValue.IsValid) FindNow();
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlTransactionCard1.ResetControls();
        }
    }
}
