using System;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlVehicleCard : UserControl
    {
        public clsVehicle Vehicle { private set;  get; }

        public int? VehicleID { private set; get; }

        public ctrlVehicleCard()
        {
            InitializeComponent();
        }

        private void _FillControls()
        {
            VehicleID = Vehicle.VehicleID.Value;

            lblShowVehicleID.Text = "[" + Vehicle.VehicleID + "]";
            lblShowMake.Text = Vehicle.ModelInfo.MakeInfo.MakeName;
            lblShowModel.Text = Vehicle.ModelInfo.ModelName;
            lblShowYear.Text = Vehicle.Year.Value.ToString();
            lblShowMileage.Text = Vehicle.Mileage.ToString();
            lblShowFuelType.Text = Vehicle.FuelTypeInfo.FuelType;
            lblShowPlateNumber.Text = Vehicle.PlateNumber;
            lblShowCarCategory.Text = Vehicle.CarCategotyInfo.CategoryName;
            lblShowIsAvailable.Text = (Vehicle.IsAvailableForRent.Value)? "Available" :"Not Available";
            lblShowRentPricePerDay.Text = Vehicle.RentalPricePerDay.ToString();

            lblEditVehicleInfo.Enabled = true;
        }

        public void ResetControls()
        {
            VehicleID = null;

            lblShowVehicleID.Text = "[?????]";
            lblShowVehicleID.Text = "?????";
            lblShowMake.Text = "?????";
            lblShowModel.Text = "?????";
            lblShowYear.Text = "?????";
            lblShowMileage.Text = "?????";
            lblShowFuelType.Text = "?????";
            lblShowPlateNumber.Text = "?????";
            lblShowCarCategory.Text = "?????";
            lblShowIsAvailable.Text = "?????";
            lblShowRentPricePerDay.Text = "?????";


            lblEditVehicleInfo.Enabled = false;
        }

        public void LoadVehicleInfo(int VehicleID)
        {
            Vehicle = clsVehicle.FindVehicle(VehicleID);

            if (Vehicle == null)
            {
                MessageBox.Show("No Vehicle With Id : " + VehicleID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        public void LoadVehicleInfo(clsVehicle Vehicle)
        {
            this.Vehicle = Vehicle;

            if (Vehicle == null)
            {
                MessageBox.Show("No record found for this Vehicle", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        private void lblEditVehicleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Vehicles.frmAddUpdateVehicle(VehicleID.Value);
            frm.ShowDialog();

            if (frm.IsDataChanged)
                LoadVehicleInfo(VehicleID.Value);
        }
    }
}
