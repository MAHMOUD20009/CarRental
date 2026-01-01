using System;
using System.Threading;
using System.Windows.Forms;
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

        private async void LoadData()
        {
            lblTotalPeople.Text = (await Task.Run(() => clsPerson.GetPersonCount())).ToString();
            lblTotalCustomers.Text = (await Task.Run(() => clsCustomer.GetCustomerCount())).ToString();
            lblTotalUsers.Text = (await Task.Run(() => clsUser.GetUserCount())).ToString();
            lblTotalBookings.Text = (await Task.Run(() => clsRentalBooking.GetTotalBookings())).ToString();
            lblTotalReturns.Text = (await Task.Run(() => clsVehicleReturn.GetReturnCount())).ToString();

            int TotalVehicles = await Task.Run(() => clsVehicle.GetVehicleCount());
            int TotalVehiclesAvailable = await Task.Run(() => clsVehicle.GetTotalVehiclesAvailable());
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
