using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.People
{
    public partial class frmPeopleList : frmListBase
    {
        public frmPeopleList()
        {
            InitializeComponent();
            InitializeInheritedControls();
        }

        private void RefreshTotalPages()
        {
            TotalPages = clsPerson.GetPageCount(RowsPerPage);
        }

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsPerson.GetPagedPeople(PageNumber, RowsPerPage));
        }

        private void frmPeopleList_Load(object sender, EventArgs e)
        {
            RowsPerPage = 5;
            PageNumber = 1;
            RefreshTotalPages();
            OnPageChanged();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPageChanged();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterGender.Visible = false;

            switch (cbFilter.Text)
            {
                case "Gender": cbFilterGender.Visible = true; txtSearchValue.Visible = false;  break;
                case "Phone": txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput; break;
                case "Email": txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput; break;
            }
        }

        private void cbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterGender.Text == "All")
            {
                RefreshDataList();
                return;
            }

            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "Gender = '" + (cbFilterGender.Text == "Male" ? "Male'" : "Female'");
            RefreshLabelTotalRecords();
        }

        private void frmAddUpdatePerson_DataBack(int PersonID)
        {
            OnPageChanged();
            RefreshTotalPages();
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
            var frm = new frmAddUpdatePerson((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.DataBack += (int PersonID) => OnPageChanged();
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDataList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this Person[" + PersonID + "]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsPerson.DeletePerson(PersonID))
            {
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frmPeopleList_Load(null, null);
            }
            else
            {
                MessageBox.Show("Cannot delete this person they are linked other record.", "Delete Operation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPersonDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvPeopleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            personDetailsToolStripMenuItem_Click(null, null);
        }
    }
}
