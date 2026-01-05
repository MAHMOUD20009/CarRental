using System;
using CarRental.Vehicles;
using System.Windows.Forms;
using CarRental.GlobalClasses;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlVehicleCardWithFilter : UserControl
    {
        public event Action<int> OnVehicleSelected;

        protected virtual void VehicleSelected(int VehicleID)
        {
            Action<int> Handler = OnVehicleSelected;

            if (Handler != null)
            {
                Handler(VehicleID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsVehicle Vehicle { get { return ctrlVehicleCard1.Vehicle; } }
        public int? VehicleID { get { return ctrlVehicleCard1.VehicleID; } }

        public ctrlVehicleCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindNow()
        {
            ctrlVehicleCard1.LoadVehicleInfo(Convert.ToInt32(txtSearchValue.Text.Trim()));

            VehicleSelected(ctrlVehicleCard1.VehicleID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadVehicleInfo(int VehicleID)
        {
            txtSearchValue.Text = VehicleID.ToString();
            FindNow();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateVehicle();
            frm.DataBack += frmAddUpdateVehicle_DataBack;
            frm.ShowDialog();
        }

        private void frmAddUpdateVehicle_DataBack(int VehicleID)
        {
            LoadVehicleInfo(VehicleID);
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                ctrlVehicleCard1.ResetControls();
                VehicleSelected(-1);
                return;
            }

            if (txtSearchValue.IsValid) FindNow();
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlVehicleCard1.ResetControls();
        }
    }
}
