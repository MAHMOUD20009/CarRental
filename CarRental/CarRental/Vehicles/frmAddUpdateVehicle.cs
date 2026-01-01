using System;
using System.Data;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.Vehicles
{
    public partial class frmAddUpdateVehicle : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public bool IsDataChanged { private set; get; }

        private clsVehicle _Vehicle;
        private int? _VehicleID;

        public delegate void DataBackEventHandler(int VehicleID);
        public DataBackEventHandler DataBack;

        public frmAddUpdateVehicle()
        {
            InitializeComponent();
            _VehicleID = null;
            _SetFormTitleByMode(enMode.AddNew);
        }

        public frmAddUpdateVehicle(int VehicleID)
        {
            InitializeComponent();
            _VehicleID = VehicleID;
            _SetFormTitleByMode(enMode.Update);
        }

        private void _SetFormTitleByMode(enMode Mode)
        {
            _Mode = Mode;

            lblFormTitle.Text = (Mode == enMode.AddNew) ? "Add New Vehicle" : "Update Vehicle Info";
        }

        private void frmAddUpdateVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FillMakesInComboBox()
        {
            cbMake.Items.Clear();

            var Makes = clsMake.GetAllMakes();

            cbMake.ValueMember = "MakeID";
            cbMake.DisplayMember = "MakeName";

            cbMake.DataSource = Makes;
            cbMake.SelectedIndex = 0;
        }

        private void FillModelsInComboBox()
        {
            cbModel.Items.Clear();

            var Models = clsModel.GetAllModels();

            cbModel.ValueMember = "ModelID";
            cbModel.DisplayMember = "ModelName";

            cbModel.DataSource = Models;
            cbModel.SelectedIndex = 0;
        }

        private void FillFuelTypesInComboBox()
        {
            cbFuelType.Items.Clear();

            var FuelTypes = clsFuelType.GetAllFuelTypes();

            cbFuelType.ValueMember = "ID";
            cbFuelType.DisplayMember = "FuelType";

            cbFuelType.DataSource = FuelTypes;
            cbFuelType.SelectedIndex = 0;
        }

        private void FillCarCategoriesInComboBox()
        {
            cbCarCategory.Items.Clear();

            var CarCategories = clsVehicleCategory.GetAllVehicleCategories();

            cbCarCategory.ValueMember = "CategoryID";
            cbCarCategory.DisplayMember = "CategoryName";

            cbCarCategory.DataSource = CarCategories;
            cbCarCategory.SelectedIndex = 0;
        }

        private void LoadData()
        {
            FillMakesInComboBox();
            FillModelsInComboBox();
            FillFuelTypesInComboBox();
            FillCarCategoriesInComboBox();

            nudYear.Minimum = DateTime.Now.AddYears(-20).Year;
            nudYear.Maximum = nudYear.Value = DateTime.Now.Year;

            if (_Mode == enMode.AddNew)
                return;

            _Vehicle = clsVehicle.FindVehicle(_VehicleID.Value);
            if (_Vehicle == null)
            {
                MessageBox.Show("No Vehicle With Id : " + _VehicleID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblShowVehicleID.Text = "[" + _Vehicle.VehicleID + "]";
            cbMake.SelectedValue = _Vehicle.MakeID;
            cbModel.SelectedValue = _Vehicle.ModelID;
            nudYear.Value = _Vehicle.Year.Value;
            nudMileage.Value = _Vehicle.Mileage.Value;
            cbFuelType.SelectedValue = _Vehicle.FuelTypeID;
            txtPlateNumber.Text = _Vehicle.PlateNumber;
            cbCarCategory.SelectedValue = _Vehicle.CarCategoryID;
            txtRentalPricePerDay.Text = _Vehicle.RentalPricePerDay.Value.ToString();
            chkIsAvailable.Checked = _Vehicle.IsAvailableForRent.Value;
        }

        private void frmAddUpdateVehicle_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Vehicle == null)
                _Vehicle = new clsVehicle();


            _Vehicle.MakeID = (int)cbMake.SelectedValue;
            _Vehicle.ModelID = (int)cbModel.SelectedValue;
            _Vehicle.Year = (int)nudYear.Value;
            _Vehicle.Mileage = (int) nudMileage.Value;
            _Vehicle.FuelTypeID = (int) cbFuelType.SelectedValue;
            _Vehicle.PlateNumber = txtPlateNumber.Text.ToString();
            _Vehicle.CarCategoryID = (int) cbCarCategory.SelectedValue;
            _Vehicle.RentalPricePerDay = Convert.ToSingle(txtRentalPricePerDay.Text);
            _Vehicle.IsAvailableForRent = chkIsAvailable.Checked;

            if (_Vehicle.Save())
            {
                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblShowVehicleID.Text = "[" + _Vehicle.VehicleID + "]";

                IsDataChanged = true;

                _SetFormTitleByMode(enMode.Update);

                if (DataBack != null)
                    DataBack.Invoke(_Vehicle.VehicleID.Value);
            }
            else
            {
                MessageBox.Show("Failed to save the data. Please try again.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
