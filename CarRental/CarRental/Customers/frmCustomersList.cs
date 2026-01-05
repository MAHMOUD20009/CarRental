using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Customers
{
    public partial class frmCustomersList : frmListBase
    {
        public frmCustomersList()
        {
            InitializeComponent();          
            InitializeInheritedControls();
        }

        private void RefreshTotalPages()
        {
            TotalPages = clsCustomer.GetPageCount(RowsPerPage);
        } 

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsCustomer.GetPagedCustomers(PageNumber, RowsPerPage));
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
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

        private void frmAddUpdateCustomer_DataBack(int CustomerID)
        {
            RefreshTotalPages();
            OnPageChanged();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateCustomer();
            frm.DataBack += frmAddUpdateCustomer_DataBack;
            frm.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewCustomer_Click(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateCustomer((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.DataBack += (int CustomerID) => OnPageChanged();
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvDataList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this Customer[" + CustomerID + "]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsCustomer.DeleteCustomer(CustomerID))
            {
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frmCustomersList_Load(null, null);
            }
            else
            {
                MessageBox.Show("Cannot delete this Customer they are linked other record.", "Delete Operation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCustomerDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvCustomersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerDetailsToolStripMenuItem_Click(null, null);
        }
    }
}
