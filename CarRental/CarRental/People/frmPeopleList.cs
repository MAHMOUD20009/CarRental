using System;
using System.Data;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.People
{
    public partial class frmPeopleList : Form
    {
        private DataTable _DTPeopleList;

        public frmPeopleList()
        {
            InitializeComponent();

        }

        private void RefreshPeopleList(bool RefreshFromDB = false)
        {
            if (RefreshFromDB)
                _DTPeopleList = clsPerson.GetAllPeople();

            _DTPeopleList.DefaultView.RowFilter = string.Empty;

            dgvPeopleList.DataSource = _DTPeopleList;
            lblRecords.Text = "#Records : " + dgvPeopleList.Rows.Count;
        }

        private void frmPeopleList_Load(object sender, EventArgs e)
        {
            RefreshPeopleList(true);
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                cbFilterGender.Visible = false;
                txtSearchValue.Visible = false;
                txtSearchValue.Clear();
            }
            else if (cbFilter.Text == "Gender")
            {
                cbFilterGender.Visible = true;
                txtSearchValue.Visible = false;
            }
            else
            {
                cbFilterGender.Visible = false;
                txtSearchValue.Visible = true;
            }
        }

        private void cbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterGender.Text == "All")
            {
                RefreshPeopleList();
                return;
            }

            if (cbFilterGender.Text == "Male")
                _DTPeopleList.DefaultView.RowFilter = "Gender = 'Male'";
            else
                _DTPeopleList.DefaultView.RowFilter = "Gender = 'Female'";

            lblRecords.Text = "#Records : " + dgvPeopleList.Rows.Count;
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((cbFilter.Text == "Person ID" || cbFilter.Text == "Phone") && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if ((cbFilter.Text == "Name" || cbFilter.Text == "Email") && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                RefreshPeopleList();
                return;
            }

            string ColumnName = cbFilter.Text.Replace(" ", "");

            if (ColumnName == "PersonID")
                _DTPeopleList.DefaultView.RowFilter = "[" + ColumnName + "] = '" + txtSearchValue.Text.Trim() + "'";
            else
                _DTPeopleList.DefaultView.RowFilter = "[" + ColumnName + "] Like '" + txtSearchValue.Text.Trim() + "%'";

            lblRecords.Text = "#Records : " + dgvPeopleList.Rows.Count;
        }

        private void frmAddUpdatePerson_DataBack(int? PersonID)
        {
            if (PersonID != null)
                RefreshPeopleList(true);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdatePerson();
            frm.DataBack += frmAddUpdatePerson_DataBack;
            frm.Show();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewPerson_Click(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdatePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.DataBack += frmAddUpdatePerson_DataBack;
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this Person[" + PersonID + "]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsPerson.DeletePerson(PersonID))
            {
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                RefreshPeopleList(true);
            }
            else
            {
                MessageBox.Show("Cannot delete this person they are linked other record.", "Delete Operation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPersonDetails((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvPeopleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            personDetailsToolStripMenuItem_Click(null, null);
        }

    }
}
