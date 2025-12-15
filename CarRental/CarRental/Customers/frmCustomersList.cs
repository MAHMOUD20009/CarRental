using System;
using System.Data;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Customers
{
    public partial class frmCustomersList : Form
    {
        private DataTable _DTCustomersList;

        public frmCustomersList()
        {
            InitializeComponent();

        }

        private void RefreshCustomersList(bool RefreshFromDB = false)
        {
            if (RefreshFromDB)
                _DTCustomersList = clsCustomer.GetAllCustomers();

            _DTCustomersList.DefaultView.RowFilter = string.Empty;

            dgvCustomersList.DataSource = _DTCustomersList;
            lblRecords.Text = "#Records : " + dgvCustomersList.Rows.Count;
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            RefreshCustomersList(true);
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchValue.Clear();
            txtSearchValue.Visible = (cbFilter.Text != "None");
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((cbFilter.Text == "Customer ID" || cbFilter.Text == "Person ID") && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if (cbFilter.Text == "Name" && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                RefreshCustomersList();
                return;
            }

            string ColumnName = cbFilter.Text.Replace(" ", "");

            if (ColumnName == "CustomerID" || ColumnName == "PersonID")
                _DTCustomersList.DefaultView.RowFilter = "[" + ColumnName + "] = '" + txtSearchValue.Text.Trim() + "'";
            else
                _DTCustomersList.DefaultView.RowFilter = "[" + ColumnName + "] Like '" + txtSearchValue.Text.Trim() + "%'";

            lblRecords.Text = "#Records : " + dgvCustomersList.Rows.Count;
        }

        private void frmAddUpdateCustomer_DataBack(int? CustomerID)
        {
            if (CustomerID != null)
                RefreshCustomersList(true);
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
            var frm = new frmAddUpdateCustomer((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            frm.DataBack += frmAddUpdateCustomer_DataBack;
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvCustomersList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this Customer[" + CustomerID + "]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsCustomer.DeleteCustomer(CustomerID))
            {
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                RefreshCustomersList(true);
            }
            else
            {
                MessageBox.Show("Cannot delete this Customer they are linked other record.", "Delete Operation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCustomerDetails((int)dgvCustomersList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvCustomersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerDetailsToolStripMenuItem_Click(null, null);
        }

    }
}
