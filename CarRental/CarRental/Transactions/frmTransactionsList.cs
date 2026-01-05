using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Transactions
{
    public partial class frmTransactionsList : frmListBase
    {
        public frmTransactionsList()
        {
            InitializeComponent(); 
            InitializeInheritedControls();
        }

        private void RefreshTotalPages()
        {
            TotalPages = clsRentalTransaction.GetPageCount(RowsPerPage);
        }

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsRentalTransaction.GetPagedTransactions(PageNumber, RowsPerPage));
        }

        private void frmTransactionsList_Load(object sender, EventArgs e)
        {
            RowsPerPage = 5;
            PageNumber = 1;
            RefreshToolStripMenuItem_Click(null, null);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshTotalPages();
            OnPageChanged();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDate.Visible = false;

            if (cbFilter.Text.Contains("Date"))
            {
                txtSearchValue.Visible = false;
                dtpDate.Visible = true;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "TransactionDate = '" + dtpDate.Value.ToString("MM/dd/yyyy") + "' OR UpdatedTransactionDate = '" + dtpDate.Value.ToString("MM/dd/yyyy") + "'";
            RefreshLabelTotalRecords();
        }

        private void TransactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTransactionDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvTransactionsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TransactionDetailsToolStripMenuItem_Click(null, null);
        }
    }
}
