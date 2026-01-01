using System;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlReturnCard : UserControl
    {
        public clsVehicleReturn Return { private set; get; }

        public int? ReturnID { private set; get; }

        public ctrlReturnCard()
        {
            InitializeComponent();
        }

        private void _FillControls()
        {
            ReturnID = Return.ReturnID.Value;

            lblShowReturnID.Text = "[" + Return.ReturnID.Value + "]";
            lblShowActualReturnDate.Text = Return.ActualReturnDate.Value.ToString("dd/MMM/yyyy");
            lblShowActualRentalDays.Text = Return.ActualRentalDays.Value.ToString();
            lblShowMileage.Text = Return.Mileage.Value.ToString();
            lblShowConsumedMileage.Text = Return.ConsumedMileage.Value.ToString();
            lblShowFinalCheckNotes.Text = Return.FinalCheckNotes;
            lblShowAdditionalCharges.Text = Return.AdditionalCharges.Value.ToString();
            lblShowActualTotalDueAmount.Text = Return.ActualTotalDueAmount.Value.ToString();

            lblEditReturnInfo.Enabled = true;
        }

        public void ResetControls()
        {
            ReturnID = null;

            lblShowReturnID.Text = "[?????]";
            lblShowActualReturnDate.Text = "?????";
            lblShowActualRentalDays.Text = "?????";
            lblShowMileage.Text = "?????";
            lblShowConsumedMileage.Text = "?????";
            lblShowFinalCheckNotes.Text = "?????";
            lblShowAdditionalCharges.Text = "?????";
            lblShowActualTotalDueAmount.Text = "?????";

            lblEditReturnInfo.Enabled = false;
        }

        public void LoadReturnInfo(int ReturnID)
        {
            Return = clsVehicleReturn.FindVehicleReturnByID(ReturnID);

            if (Return == null)
            {
                MessageBox.Show("No Return With Id : " + ReturnID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        public void LoadReturnInfoByBookingID(int BookingID)
        {
            Return = clsVehicleReturn.FindVehicleReturnByBookingID(BookingID);

            if (Return == null)
            {
                MessageBox.Show("No Return With Booking Id : " + ReturnID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        public void LoadReturnInfo(clsVehicleReturn Return)
        {
            this.Return = Return;

            if (Return == null)
            {
                MessageBox.Show("No record found for this Return", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        private void lblEditReturnInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Returns.frmAddUpdateReturn(ReturnID.Value);
            frm.ShowDialog();

            if (frm.IsDataChanged)
                LoadReturnInfo(ReturnID.Value);
        }
    }
}
