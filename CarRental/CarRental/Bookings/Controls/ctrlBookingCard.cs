using System;
using CarRental.Bookings;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlBookingCard : UserControl
    {
        public clsRentalBooking Booking { private set; get; }

        public int? BookingID { private set; get; }

        public ctrlBookingCard()
        {
            InitializeComponent();
        }

        private void FillControls()
        {
            BookingID = Booking.BookingID;


            ctrlCustomerCard1.LoadCustomerInfoByCustomerID(Booking.CustomerID.Value);
            ctrlVehicleCard1.LoadVehicleInfo(Booking.VehicleID.Value);

            lblShowBookingId.Text = "[" + Booking.BookingID + "]";
            lblShowStartDate.Text = Booking.RentalStartDate.Value.ToString("dd/MMM/yyyy");
            lblShowEndDate.Text = Booking.RentalEndDate.Value.ToString("dd/MMM/yyyy");
            lblShowPickupLocation.Text = Booking.PickupLocation;
            lblShowDropoffLocation.Text = Booking.DropoffLocation;
            lblShowInitialRentDays.Text = Booking.InitialRentalDays.Value.ToString();
            lblShowRentPricePerDay.Text = Booking.RentalPricePerDay.Value.ToString();
            lblShowInitialTotalDueAmount.Text = Booking.InitialTotalDueAmount.Value.ToString();
            lblShowPaidInitialTotalDueAmount.Text = Booking.TransactionInfo.PaidInitialTotalDueAmount.GetValueOrDefault().ToString();
            lblShowPaymentDetails.Text = (Booking.TransactionInfo.PaymentDetails == null) ? "Not Set" : Booking.TransactionInfo.PaymentDetails;
            lblShowTotalRemaining.Text = Booking.TransactionInfo.TotalRemaining.GetValueOrDefault().ToString();
            lblShowTotalRefundedAmount.Text = Booking.TransactionInfo.TotalRefundedAmount.GetValueOrDefault().ToString();
            lblShowInitialCheckNotes.Text = Booking.InitialCheckNotes;

            lblEditBookingInfo.Enabled = true;
        }

        public void ResetControls()
        {
            BookingID = null;

            ctrlCustomerCard1.ResetControls();
            ctrlVehicleCard1.ResetControls();

            lblShowBookingId.Text = "[?????]";
            lblShowStartDate.Text = "?????";
            lblShowEndDate.Text = "?????";
            lblShowPickupLocation.Text = "?????";
            lblShowDropoffLocation.Text = "?????";
            lblShowInitialRentDays.Text = "?????";
            lblShowRentPricePerDay.Text = "?????";
            lblShowInitialTotalDueAmount.Text = "?????";
            lblShowPaidInitialTotalDueAmount.Text = "?????"; 
            lblShowPaymentDetails.Text = "?????";
            lblShowTotalRemaining.Text = "?????";
            lblShowTotalRefundedAmount.Text = "?????";
            lblShowInitialCheckNotes.Text = "?????";

            lblEditBookingInfo.Enabled = false;
        }

        public void LoadBookingInfo(int BookingID)
        {
            Booking = clsRentalBooking.FindRentalBookingByID(BookingID);

            if (Booking == null)
            {
                MessageBox.Show("No Booking With Id : " + BookingID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        public void LoadBookingInfo(clsRentalBooking Booking)
        {
            this.Booking = Booking;

            if (Booking == null)
            {
                MessageBox.Show("No booking record was found.", "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        private void lblEditBookingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmAddUpdateBooking(BookingID.Value);
            frm.ShowDialog();

            if (frm.IsDataChanged)
                LoadBookingInfo(BookingID.Value);
        }
    }
}
