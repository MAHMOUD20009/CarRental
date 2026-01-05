using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Maintenance
{
    public partial class frmMaintenanceList : frmListBase
    {
        public frmMaintenanceList()
        {
            InitializeComponent();
            InitializeInheritedControls();
        }

        private void RefreshTotalPages()
        {
            TotalPages = clsMaintenance.GetPageCount(RowsPerPage);
        }

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsMaintenance.GetPagedMaintenance(PageNumber, RowsPerPage));
        }

        private void frmMaintenanceList_Load(object sender, EventArgs e)
        {
            RowsPerPage = 5;
            PageNumber = 1;
            RefreshTotalPages();
            OnPageChanged();

            dtpDate.MinDate = DateTime.Today.AddYears(-1);
            dtpDate.MaxDate = DateTime.Today;
            dtpDate.Value = dtpDate.MaxDate;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "MaintenanceDate = '" + dtpDate.Value.ToString("MM/dd/yyyy") + "'";
            RefreshLabelTotalRecords();
        }

        private void frmAddUpdateMaintenance_DataBack(int MaintenanceID)
        {
            RefreshTotalPages();
            OnPageChanged();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text.ToLower().Contains("date"))
            {
                txtSearchValue.Visible = false;
                dtpDate.Visible = true;
            }
            else
            {
                dtpDate.Visible = false;
            }
        }

        private void btnAddNewMaintenance_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateMaintenance();
            frm.DataBack += frmAddUpdateMaintenance_DataBack;
            frm.Show();
        }

        private void addNewMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewMaintenance_Click(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateMaintenance((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.DataBack += frmAddUpdateMaintenance_DataBack;
            frm.Show();
        }

        private void MaintenanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMaintenanceDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvMaintenanceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MaintenanceDetailsToolStripMenuItem_Click(null, null);
        }




    }
}
