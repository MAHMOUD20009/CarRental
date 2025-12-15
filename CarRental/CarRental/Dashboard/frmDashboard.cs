using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Threading;
using System.Threading.Tasks;
using CarRental_BusinessLogicLayer;

namespace CarRental.Dashboard
{
    public partial class frmDashboard : Form
    {

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            lblTotalPeople.Text = clsPerson.GetTotalPeople().ToString();
            lblTotalCustomers.Text = clsCustomer.GetTotalCustomers().ToString();
            lblTotalUsers.Text = clsUser.GetTotalUsers().ToString();
            lblTotalBookings.Text = clsRentalBooking.GetTotalBookings().ToString();
            lblTotalReturns.Text = clsVehicleReturn.GetTotalTotalReturns().ToString();

            int TotalVehicles = clsVehicle.GetTotalVehicles();
            int TotalVehiclesAvailable = clsVehicle.GetTotalVehiclesAvailable();
            int AvailablePercentage = (TotalVehiclesAvailable * 100) / TotalVehicles;

            prbVehicleAvailable.Value = AvailablePercentage;


            lblVehicleAvailabe.Text = "%" + AvailablePercentage;
            lblVehicleNotAvailabe.Text = "%" + (100 - AvailablePercentage);
            lblTotalVehicles.Text = TotalVehicles.ToString();
 
            
            lblDate.Text = DateTime.Now.Date.ToString("dd-MMMM-yyyy");
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
