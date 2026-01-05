using System;
using CarRental.GlobalClasses;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.Maintenance
{
    public partial class frmAddUpdateMaintenance : Form
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

        private clsMaintenance _Maintenance;
        private int? _MaintenanceID;

        public delegate void DataBackEventHandler(int MaintenanceID);
        public DataBackEventHandler DataBack;

        public frmAddUpdateMaintenance()
        {
            InitializeComponent();
            _SetFormTitleByMode(enMode.AddNew);
        }

        public frmAddUpdateMaintenance(int MaintenanceID)
        {
            InitializeComponent();
            _MaintenanceID = MaintenanceID;
            _SetFormTitleByMode(enMode.Update);
        }

        private void _SetFormTitleByMode(enMode Mode)
        {
            _Mode = Mode;

            lblFormTitle.Text = (Mode == enMode.AddNew) ? "Add New Maintenance" : "Update Maintenance Info";
        }

        private void frmAddUpdateMaintenance_MouseDown(object sender, MouseEventArgs e)
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

        private void LoadData()
        {
            lblShowMaintenanceDate.Text = DateTime.Today.ToString("dd/MMM/yyyy");

            if (_Mode == enMode.AddNew)
                return;

            _Maintenance = clsMaintenance.FindMaintenance(_MaintenanceID.Value);
            if (_Maintenance == null)
            {
                MessageBox.Show("No Maintenance found with Id : " + _MaintenanceID, "Maintenance Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Vehicle = _Maintenance.VehicleInfo;
            ctrlVehicleCardWithFilter1.FilterEnabled = false;
            ctrlVehicleCardWithFilter1.LoadVehicleInfo(_Vehicle.VehicleID.Value);
            

            lblShowMaintenanceId.Text = "[" + _Maintenance.MaintenanceID + "]";
            txtDescription.Text = _Maintenance.Description;
            lblShowMaintenanceDate.Text = _Maintenance.MaintenanceDate.Value.ToString("dd/MMM/yyyy");
            txtCost.Text = _Maintenance.Cost.ToString();
        }

        private void frmAddUpdateMaintenance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ctrlVehicleCardWithFilter1_OnVehicleSelected(int VehicleID)
        {
            _Vehicle = clsVehicle.FindVehicle(VehicleID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Vehicle == null)
            {
                MessageBox.Show("Please select a vehicle first.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Maintenance == null)
                _Maintenance = new clsMaintenance();


            _Maintenance.VehicleID = _Vehicle.VehicleID;
            _Maintenance.Description = txtDescription.Text.Trim();
            _Maintenance.MaintenanceDate = DateTime.Parse(lblShowMaintenanceDate.Text);
            _Maintenance.Cost = float.Parse(txtCost.Text);

            if (_Maintenance.Save())
            {
                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblShowMaintenanceId.Text = "[" + _Maintenance.MaintenanceID + "]";

                ctrlVehicleCardWithFilter1.FilterEnabled = false;
                IsDataChanged = true;

                _SetFormTitleByMode(enMode.Update);

                if (DataBack != null)
                    DataBack.Invoke(_Maintenance.MaintenanceID.Value);
            }
            else
            {
                MessageBox.Show("Failed to save the data. Please try again.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
