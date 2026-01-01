using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Users
{
    public partial class frmUsersList : frmListBase
    {
        public frmUsersList()
        {
            InitializeComponent();
            TotalPages = clsUser.GetPageCount(RowsPerPage);
            InitializeInheritedControls();
        }

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsUser.GetPagedUsers(PageNumber, RowsPerPage));
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {   
            OnPageChanged();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPageChanged();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsActive.Visible = false;

            switch (cbFilter.Text)
            {
                case "User Name": txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput; break;
                case "Is Active": txtSearchValue.Visible = false; cbIsActive.Visible = true; break;
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                RefreshDataList();
                return;
            }

            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "IsActive = " + (cbIsActive.Text == "Active" ? "1" : "0");
            RefreshLabelTotalRecords();
        }

        private void frmAddUpdateUser_DataBack(int UserID)
        {
            OnPageChanged();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateUser();
            frm.DataBack += frmAddUpdateUser_DataBack;
            frm.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewUser_Click(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateUser((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.DataBack += frmAddUpdateUser_DataBack;
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvDataList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this User[" + UserID + "]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsUser.DeleteUser(UserID))
            {
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                OnPageChanged();
            }
            else
            {
                MessageBox.Show("Cannot delete this User they are linked other record.", "Delete Operation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUserDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvUsersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserDetailsToolStripMenuItem_Click(null, null);
        }
    }
}
