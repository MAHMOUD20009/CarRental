using System;
using CarRental.Bookings;
using System.Windows.Forms;
using CarRental.GlobalClasses;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlBookingCardWithFilter : UserControl
    {
        public event Action<int> OnBookingSelected;

        protected virtual void BookingSelected(int BookingID)
        {
            Action<int> Handler = OnBookingSelected;

            if (Handler != null)
            {
                Handler(BookingID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsRentalBooking Booking { get { return ctrlBookingCard1.Booking; } }
        public int? BookingID { get { return ctrlBookingCard1.BookingID; } }

        public ctrlBookingCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindNow()
        {
            ctrlBookingCard1.LoadBookingInfo(int.Parse(txtSearchValue.Text.Trim()));

            BookingSelected(ctrlBookingCard1.BookingID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadBookingInfo(int BookingID)
        {
            txtSearchValue.Text = BookingID.ToString();
            FindNow();
        }

        private void btnAddNewBooking_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateBooking();
            frm.DataBack += frmAddUpdateBooking_DataBack;
            frm.ShowDialog();
        }

        private void frmAddUpdateBooking_DataBack(int BookingID)
        {
            LoadBookingInfo(BookingID);
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                ctrlBookingCard1.ResetControls();
                BookingSelected(-1);
                return;
            }

            if (txtSearchValue.IsValid) FindNow();
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlBookingCard1.ResetControls();
        }
    }
}
