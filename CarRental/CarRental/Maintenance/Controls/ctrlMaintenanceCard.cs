using System;
using System.Windows.Forms;
using CarRental.Maintenance;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlMaintenanceCard : UserControl
    {
        public clsMaintenance Maintenance { private set; get; }

        public int? MaintenanceID { private set; get; }

        public ctrlMaintenanceCard()
        {
            InitializeComponent();
        }

        private void FillControls()
        {
            MaintenanceID = Maintenance.MaintenanceID;

            ctrlVehicleCard1.LoadVehicleInfo(Maintenance.VehicleInfo);

            lblShowMaintenanceId.Text = "[" + Maintenance.MaintenanceID + "]";
            lblShowDescription.Text = Maintenance.Description;
            lblShowMaintenanceDate.Text = Maintenance.MaintenanceDate.Value.ToString("dd/MMM/yyyy");
            lblShowCost.Text = Maintenance.Cost.Value.ToString();

            lblEditMaintenanceInfo.Enabled = true;
        }

        public void ResetControls()
        {
            MaintenanceID = null;

            ctrlVehicleCard1.ResetControls();

            lblShowMaintenanceId.Text = "[?????]";
            lblShowDescription.Text = "?????";
            lblShowMaintenanceDate.Text = "?????";
            lblShowCost.Text = "?????";

            lblEditMaintenanceInfo.Enabled = false;
        }

        public void LoadMaintenanceInfo(int MaintenanceID)
        {
            Maintenance = clsMaintenance.FindMaintenance(MaintenanceID);

            if (Maintenance == null)
            {
                MessageBox.Show("No Maintenance With Id : " + MaintenanceID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        public void LoadMaintenanceInfo(clsMaintenance Maintenance)
        {
            this.Maintenance = Maintenance;

            if (Maintenance == null)
            {
                MessageBox.Show("No record found for this maintenance", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        private void lblEditMaintenanceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmAddUpdateMaintenance(MaintenanceID.Value);
            frm.ShowDialog();

            if (frm.IsDataChanged)
                LoadMaintenanceInfo(MaintenanceID.Value);
        }
    }
}
