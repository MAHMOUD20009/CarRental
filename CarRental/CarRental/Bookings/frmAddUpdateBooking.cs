using System;
using CarRental.GlobalClasses;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.Bookings
{
    public partial class frmAddUpdateBooking : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public bool IsDataChanged { private set; get; }

        private clsCustomer _Customer;

        private clsVehicle _Vehicle;

        private clsRentalBooking _Booking;
        private int _BookingID;

        public delegate void DataBackEventHandler(int BookingID);
        public DataBackEventHandler DataBack;

        public frmAddUpdateBooking()
        {
            InitializeComponent();
            _SetFormTitleByMode(enMode.AddNew);
        }

        public frmAddUpdateBooking(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
            _SetFormTitleByMode(enMode.Update);
        }

        private void _SetFormTitleByMode(enMode Mode)
        {
            _Mode = Mode;

            lblFormTitle.Text = (Mode == enMode.AddNew) ? "Add New Booking" : "Update Booking Info";
        }

        private void frmAddUpdateBooking_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void LoadData()
        {
            dtpRentStartDate.MinDate = DateTime.Today;
            dtpRentStartDate.MaxDate = DateTime.Today.AddMonths(1);
            dtpRentStartDate.Value = dtpRentStartDate.MinDate;

            dtpRentEndDate.MinDate = DateTime.Today.AddDays(1);
            dtpRentEndDate.MaxDate = DateTime.Today.AddMonths(1);
            dtpRentEndDate.Value = dtpRentEndDate.MinDate;

            if (_Mode == enMode.AddNew)
                return;

            _Booking = clsRentalBooking.FindRentalBookingByID(_BookingID);
            if (_Booking == null)
            {
                MessageBox.Show("No booking found with Id : " + _BookingID, "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtpRentStartDate.MinDate = _Booking.RentalStartDate.Value;
            dtpRentStartDate.MaxDate = _Booking.RentalStartDate.Value.AddMonths(1);
            dtpRentStartDate.Value = dtpRentStartDate.MinDate;

            dtpRentEndDate.MinDate = _Booking.RentalEndDate.Value;
            dtpRentEndDate.MaxDate = _Booking.RentalStartDate.Value.AddMonths(1);
            dtpRentEndDate.Value = dtpRentEndDate.MinDate;

            Date_ValueChanged(null, null);

            _Customer = _Booking.CustomerInfo;
            _Vehicle = _Booking.VehicleInfo;

            ctrlCustomerCardWithFilter1.FilterEnabled = false;
            ctrlCustomerCardWithFilter1.LoadCustomerInfo(_Booking.CustomerID.Value);

            ctrlVehicleCardWithFilter1.FilterEnabled = false;
            ctrlVehicleCardWithFilter1.LoadVehicleInfo(_Booking.VehicleID.Value);

            lblShowBookingId.Text = "[" + _Booking.BookingID + "]";
            txtPickupLocation.Text = _Booking.PickupLocation;
            txtDropoffLocation.Text = _Booking.DropoffLocation;
            lblShowInitialRentDays.Text = _Booking.InitialRentalDays.Value.ToString();
            lblShowRentPricePerDay.Text = _Booking.RentalPricePerDay.Value.ToString();
            lblShowInitialTotalDueAmount.Text = _Booking.InitialTotalDueAmount.Value.ToString();
            txtPaidInitialTotalDueAmount.Text = _Booking.TransactionInfo.PaidInitialTotalDueAmount.GetValueOrDefault().ToString();
            txtPaymentDetails.Text = (_Booking.TransactionInfo.PaymentDetails != null)? _Booking.TransactionInfo.PaymentDetails : "";
            txtInitialCheckNotes.Text = _Booking.InitialCheckNotes;
        }

        private void frmAddUpdateBooking_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ctrlCustomerCardWithFilter1_OnCustomerSelected(int CustomerID)
        {
            _Customer = clsCustomer.FindCustomerByCustomerID(CustomerID);
            if (_Customer == null)
            {
                return;
            }
        }

        private void UpdateInitialTotalDueAmount()
        {
            lblShowInitialTotalDueAmount.Text = (_Vehicle == null) ? "0" : (Convert.ToInt16(lblShowInitialRentDays.Text) * _Vehicle.RentalPricePerDay.Value).ToString();
        }

        private void ctrlVehicleCardWithFilter1_OnVehicleSelected(int VehicleID)
        {
            _Vehicle = clsVehicle.FindVehicle(VehicleID);
            if (_Vehicle == null)
            {
                lblShowRentPricePerDay.Text = "0";
                return;
            }

            if (_Mode == enMode.AddNew && !_Vehicle.IsAvailableForRent.Value)
            {
                MessageBox.Show("The selected vehicle is not available. Please Choose another one.", "Vehicle Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _Vehicle = null;
                return;
            }

            lblShowRentPricePerDay.Text = _Vehicle.RentalPricePerDay.ToString();

            UpdateInitialTotalDueAmount();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            int InitialRentDays = (dtpRentEndDate.Value - dtpRentStartDate.Value).Days;

            lblShowInitialRentDays.Text = InitialRentDays.ToString();

            UpdateInitialTotalDueAmount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Customer == null)
            {
                MessageBox.Show("Please select a customer first.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_Vehicle == null)
            {
                MessageBox.Show("Please select a vehicle first.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Booking == null)
                _Booking = new clsRentalBooking();


            _Booking.CustomerID = _Customer.CustomerID;
            _Booking.VehicleID = _Vehicle.VehicleID;
            _Booking.RentalStartDate = dtpRentStartDate.Value;
            _Booking.RentalEndDate = dtpRentEndDate.Value;
            _Booking.PickupLocation = txtPickupLocation.Text.Trim();
            _Booking.DropoffLocation = txtDropoffLocation.Text.Trim();
            _Booking.InitialRentalDays = Convert.ToByte(lblShowInitialRentDays.Text);
            _Booking.RentalPricePerDay = Convert.ToSingle(lblShowRentPricePerDay.Text);
            _Booking.InitialTotalDueAmount = Convert.ToSingle(lblShowInitialTotalDueAmount.Text);
            _Booking.InitialCheckNotes = txtInitialCheckNotes.Text.Trim();

            _Vehicle.IsAvailableForRent = false;

            if (_Booking.Save(txtPaymentDetails.Text) && _Vehicle.Save())
            {
                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblShowBookingId.Text = "[" + _Booking.BookingID + "]";

                ctrlCustomerCardWithFilter1.FilterEnabled = false;
                ctrlVehicleCardWithFilter1.FilterEnabled = false;
                IsDataChanged = true;

                _SetFormTitleByMode(enMode.Update);

                if (DataBack != null)
                    DataBack.Invoke(_Booking.BookingID.Value);
            }
            else
            {
                MessageBox.Show("Failed to save the data. Please try again.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
