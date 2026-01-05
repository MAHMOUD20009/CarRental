using System;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.Returns
{
    public partial class frmAddUpdateReturn : Form
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

        private clsRentalBooking _Booking;

        private clsVehicleReturn _Return;
        private int? _ReturnID;

        public delegate void DataBackEventHandler(int ReturnID);
        public DataBackEventHandler DataBack;

        public frmAddUpdateReturn()
        {
            InitializeComponent();
            _ReturnID = null;
            _SetFormTitleByMode(enMode.AddNew);
        }

        public frmAddUpdateReturn(int ReturnID)
        {
            InitializeComponent();
            _ReturnID = ReturnID;
            _SetFormTitleByMode(enMode.Update);
        }

        private void _SetFormTitleByMode(enMode Mode)
        {
            _Mode = Mode;

            lblFormTitle.Text = (Mode == enMode.AddNew) ? "Add New Return" : "Update Return Info";
        }

        private void frmAddUpdateReturn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadData()
        {
            dtpActualReturnDate.MinDate = DateTime.Today;
            dtpActualReturnDate.MaxDate = DateTime.Today;
            dtpActualReturnDate.Value = DateTime.Today;

            if (_Mode == enMode.AddNew)
                return;

            _Return = clsVehicleReturn.FindVehicleReturnByID(_ReturnID.Value);
            if (_Return == null)
            {
                MessageBox.Show("No Vehicle Return With Id : " + _ReturnID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Booking = clsRentalBooking.FindRentalBookingByReturnID(_ReturnID.Value);
            if (_Booking == null)
            {
                MessageBox.Show("No Booking With Return Id : " + _ReturnID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ctrlBookingCardWithFilter1.FilterEnabled = false;
            ctrlBookingCardWithFilter1.LoadBookingInfo(_Booking.BookingID.Value);

            dtpActualReturnDate.MinDate = DateTime.Today.AddMonths(-10);
            dtpActualReturnDate.MaxDate = DateTime.Today;

            nudMileage.Minimum = _Return.Mileage.Value;
            nudMileage.Value = _Return.Mileage.Value;
            nudMileage.Maximum = _Return.Mileage.Value + 1000;


            lblShowReturnID.Text = "[" + _Return.ReturnID.Value + "]";
            dtpActualReturnDate.Value = _Return.ActualReturnDate.Value;
            lblShowActualRentalDays.Text = _Return.ActualRentalDays.Value.ToString();
            lblShowConsumedMileage.Text = _Return.ConsumedMileage.Value.ToString();
            txtFinalCheckNotes.Text = _Return.FinalCheckNotes;
            txtAdditionalCharges.Text = _Return.AdditionalCharges.Value.ToString();
            lblShowActualTotalDueAmount.Text = _Return.ActualTotalDueAmount.Value.ToString();
            lblShowTotalRemaining.Text = _Booking.TransactionInfo.TotalRemaining.Value.ToString();
            lblShowTotalRefundedAmount.Text = _Booking.TransactionInfo.TotalRefundedAmount.Value.ToString();
        }

        private void frmAddUpdateReturn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ctrlBookingCardWithFilter1_OnBookingSelected(int BookingID)
        {
            _Booking = clsRentalBooking.FindRentalBookingByID(BookingID);

            if (_Booking == null)
            {
                UpdateSettlementAmounts();
                return;
            }

            if (_Mode == enMode.AddNew && _Booking.IsVehicledReturned)
            {
                MessageBox.Show("This reservation has already been completed. The vehicle was returned previously.", "Reservation Already Completed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _Booking = null;
                return;
            }

            nudMileage.Minimum = _Booking.VehicleInfo.Mileage.Value;
            nudMileage.Value = _Booking.VehicleInfo.Mileage.Value;
            nudMileage.Maximum = _Booking.VehicleInfo.Mileage.Value + 20000;

            dtpActualReturnDate_ValueChanged(null, null);
            UpdateSettlementAmounts();
        }

        private byte GetActualRentalDays()
        {
            return (byte)(dtpActualReturnDate.Value - _Booking.RentalStartDate.Value).Days;
        }

        private void dtpActualReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (_Booking == null)
            {
                lblShowActualRentalDays.Text = "?????";
                return;
            }

            lblShowActualRentalDays.Text = GetActualRentalDays().ToString();
        }

        private void nudMileage_ValueChanged(object sender, EventArgs e)
        {
            if (_Booking == null)
            {
                lblShowConsumedMileage.Text = "?????";
                return;
            }

            lblShowConsumedMileage.Text = (nudMileage.Value - _Booking.VehicleInfo.Mileage.Value).ToString();
        }

        private void txtAdditionalCharges_TextChanged(object sender, EventArgs e)
        {
            UpdateSettlementAmounts();
        }

        private void UpdateSettlementAmounts()
        {
            if (_Booking == null)
            {
                lblShowActualTotalDueAmount.Text = "?????";
                return;
            }

            float AdditionalCharges = (!string.IsNullOrEmpty(txtAdditionalCharges.Text) && txtAdditionalCharges.IsValid) ? float.Parse(txtAdditionalCharges.Text) : 0;
            float TotalDueAmount = (GetActualRentalDays() * _Booking.RentalPricePerDay.Value) + AdditionalCharges;


            lblShowActualTotalDueAmount.Text = TotalDueAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Booking == null)
            {
                MessageBox.Show("No Booking Selected.");
                return;
            }

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Return == null)
                _Return = new clsVehicleReturn();

            UpdateSettlementAmounts();

            _Return.ActualReturnDate = dtpActualReturnDate.Value;
            _Return.ActualRentalDays = byte.Parse(lblShowActualRentalDays.Text);
            _Return.Mileage = (int)nudMileage.Value;
            _Return.ConsumedMileage = int.Parse(lblShowConsumedMileage.Text);
            _Return.FinalCheckNotes = txtFinalCheckNotes.Text.Trim();
            _Return.AdditionalCharges = float.Parse(txtAdditionalCharges.Text);
            _Return.ActualTotalDueAmount = float.Parse(lblShowActualTotalDueAmount.Text);

            if (_Return.Save(_Booking.BookingID.Value))
            {
                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblShowReturnID.Text = "[" + _Return.ReturnID + "]";

                IsDataChanged = true;

                _SetFormTitleByMode(enMode.Update);
                _ReturnID = _Return.ReturnID;
                LoadData();

                if (DataBack != null)
                    DataBack.Invoke(_Return.ReturnID.Value);
            }
            else
            {
                MessageBox.Show("Failed to save the data. Please try again.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
