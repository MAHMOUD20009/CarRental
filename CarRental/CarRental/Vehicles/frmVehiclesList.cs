using System;
using CarRental.FormListBase;
using System.Windows.Forms;
using System.Threading.Tasks;
using CarRental_BusinessLogicLayer;

namespace CarRental.Vehicles
{
    public partial class frmVehiclesList : frmListBase
    {
        public frmVehiclesList()
        {
            InitializeComponent();
            InitializeInheritedControls();
        }

        private void RefreshTotalPages()
        {
            TotalPages = clsVehicle.GetPageCount(RowsPerPage);
        }

        protected override async void OnPageChanged()
        {
            RefreshDataList(await clsVehicle.GetPagedVehicles(PageNumber, RowsPerPage));
        }

        private async void FillMakesInComboBox()
        {
            var DT = await Task.Run(() => clsMake.GetAllMakes());

            cbFilterMakes.DisplayMember = "MakeName";
            cbFilterMakes.DataSource = DT;

            cbFilterMakes.SelectedIndex = 0;
        }

        private void FillModelsInComboBox()
        {
            var DT = clsModel.GetAllModels();

            cbFilterModels.DisplayMember = "ModelName";
            cbFilterModels.DataSource = DT;

            cbFilterModels.SelectedIndex = 0;
        }

        private void FillCategoryNamesInComboBox()
        {
            var DT = clsVehicleCategory.GetAllVehicleCategories();

            cbFilterCategoryName.DisplayMember = "CategoryName";
            cbFilterCategoryName.DataSource = DT;

            cbFilterCategoryName.SelectedIndex = 0;
        }

        private void FillFuelTypesInComboBox()
        {
            var DT = clsFuelType.GetAllFuelTypes();

            cbFilterFuelType.DisplayMember = "FuelType";
            cbFilterFuelType.DataSource = DT;

            cbFilterFuelType.SelectedIndex = 0;
        }

        private void LoadData()
        {
            RowsPerPage = 5;
            PageNumber = 1;
            RefreshTotalPages();
            RefreshToolStripMenuItem_Click(null, null);

            FillMakesInComboBox();
            FillModelsInComboBox();
            FillCategoryNamesInComboBox();
            FillFuelTypesInComboBox();

            nudYear.Maximum = nudYear.Value = DateTime.Now.Year;
        }

        private void frmVehiclesList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPageChanged();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterMakes.Visible = false;
            cbFilterModels.Visible = false;
            cbFilterFuelType.Visible = false;
            cbFilterCategoryName.Visible = false;
            nudYear.Visible = false;
            cbFilterAvailable.Visible = false;

            switch (cbFilter.Text)
            {
                case "Make": cbFilterMakes.Visible = true; txtSearchValue.Visible = false; break;
                case "Model": cbFilterModels.Visible = true; txtSearchValue.Visible = false; break;
                case "Year": nudYear.Visible = true; txtSearchValue.Visible = false; break;
                case "Fuel Type": cbFilterFuelType.Visible = true; txtSearchValue.Visible = false; break;
                case "Category Name": cbFilterCategoryName.Visible = true; txtSearchValue.Visible = false; break;
                case "Is Available": cbFilterAvailable.Visible = true; txtSearchValue.Visible = false; break;
            }
        }

        private void cbsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            var cb = (Guna.UI.WinForms.GunaComboBox)sender;

            DTDataList.DefaultView.RowFilter = "[" + cb.Tag + "] = '" + cb.Text + "'";
            lblRecords.Text = "#Records : " + dgvDataList.Rows.Count;
        }

        private void cbFilterAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterAvailable.Text == "All")
            {
                RefreshDataList();
                return;
            }

            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "IsAvailableForRent = " + (cbFilterAvailable.Text == "Available" ? 1 : 0);
            RefreshLabelTotalRecords();
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            if (DTDataList == null || DTDataList.Columns.Count == 0)
                return;

            DTDataList.DefaultView.RowFilter = "Year = '" + nudYear.Value + "'";
            RefreshLabelTotalRecords();
        }

        private void frmAddUpdateVehicle_DataBack(int VehicleID)
        {
            OnPageChanged();
            RefreshTotalPages();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateVehicle();
            frm.DataBack += frmAddUpdateVehicle_DataBack;
            frm.Show();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewVehicle_Click(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateVehicle((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.DataBack += (int VehicleID) => OnPageChanged();
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VehicleID = (int)dgvDataList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this Vehicle[" + VehicleID + "]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsVehicle.DeleteVehicle(VehicleID))
            {
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                PageNumber = 1;
                RefreshTotalPages();
                OnPageChanged();
            }
            else
            {
                MessageBox.Show("Cannot delete this Vehicle they are linked other record.", "Delete Operation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmVehicleDetails((int)dgvDataList.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void dgvVehiclesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VehicleDetailsToolStripMenuItem_Click(null, null);
        }
    }
}
