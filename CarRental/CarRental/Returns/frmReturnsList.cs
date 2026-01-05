using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Returns
{
    public partial class frmReturnsList : frmListBase
    {
        public frmReturnsList()
        {
            InitializeComponent();
            InitializeInheritedControls();
        }

        private void RefreshTotalPages()
        {
            TotalPages = clsVehicleReturn.GetPageCount(RowsPerPage);
        }

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsVehicleReturn.GetPagedReturns(PageNumber, RowsPerPage));
        }

        private  void frmReturnsList_Load(object sender, EventArgs e)
        {
            RowsPerPage = 5;
            PageNumber = 1;
            RefreshTotalPages();
            RefreshToolStripMenuItem_Click(null, null);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPageChanged();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDate.Visible = false;

            if (cbFilter.Text == "Actual Return Date")
            {
                txtSearchValue.Visible = false;
                dtpDate.Visible = true;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "ActualReturnDate = '" + dtpDate.Value.ToString("MM/dd/yyyy") + "'";
            RefreshLabelTotalRecords();
        }

        private void frmAddUpdateReturn_DataBack(int ReturnID)
        {
            frmReturnsList_Load(null, null);
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateReturn();
            frm.DataBack += frmAddUpdateReturn_DataBack;
            frm.ShowDialog();
        }

        private void addNewReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewRecord_Click(null, null);
        }

        private void updateReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateReturn((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.DataBack += (int ReturnId) => OnPageChanged();
            frm.ShowDialog();
        }

        private void returnDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmReturnDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvDataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            returnDetailsToolStripMenuItem_Click(null, null);
        }
    }
}
