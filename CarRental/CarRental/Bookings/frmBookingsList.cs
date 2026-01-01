using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Bookings
{
    public partial class frmBookingsList : frmListBase
    {
        public frmBookingsList()
        {
            InitializeComponent();
            TotalPages = clsRentalBooking.GetPageCount(RowsPerPage);
            InitializeInheritedControls();
        }

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsRentalBooking.GetPagedBookings(PageNumber, RowsPerPage));
        }

        private void LoadData()
        {
            OnPageChanged();

            dtpDate.MinDate = DateTime.Now.AddYears(-20);
            dtpDate.MaxDate = DateTime.Now.AddYears(20);
            dtpDate.Value = DateTime.Now;
        }

        private void frmBookingsList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPageChanged();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataList();
            dtpDate.Visible = false;

            switch (cbFilter.Text)
            {
                case "Date": dtpDate.Visible = true; txtSearchValue.Visible = false; break;
                case "Pickup Location": txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput; break;
                case "Dropoff Location": txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput; break;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "RentalStartDate = '" + dtpDate.Value.ToString("MM/dd/yyyy") + "' OR RentalEndDate = '" + dtpDate.Value.ToString("MM/dd/yyyy") + "'";
            RefreshLabelTotalRecords();
        }

        private void frmAddUpdateBooking_DataBack(int BookingID)
        {
            OnPageChanged();
        }

        private void btnAddNewBooking_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateBooking();
            frm.DataBack += frmAddUpdateBooking_DataBack;
            frm.Show();
        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewBooking_Click(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateBooking((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.DataBack += frmAddUpdateBooking_DataBack;
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookingID = (int)dgvDataList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this Booking[" + BookingID + "]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsRentalBooking.DeleteBooking(BookingID))
            {
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                OnPageChanged();
            }
            else
            {
                MessageBox.Show("Cannot delete this Booking they are linked other record.", "Delete Operation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBookingDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvBookingsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BookingDetailsToolStripMenuItem_Click(null, null);
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Customers.frmCustomerDetails((int)dgvDataList.CurrentRow.Cells[1].Value);
            frm.Show();
        }

        private void vehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Vehicles.frmVehicleDetails((int)dgvDataList.CurrentRow.Cells[3].Value);
            frm.ShowDialog();
        }
    }
}
