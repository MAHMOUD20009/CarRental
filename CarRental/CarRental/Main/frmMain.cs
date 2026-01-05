using System;
using System.Drawing;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;
using CarRental.GlobalClasses;

namespace CarRental.Main
{
    public partial class frmMain : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private Dashboard.frmDashboard frmDashboard;
        private People.frmPeopleList frmPeopleList;
        private Customers.frmCustomersList frmCustomersList;
        private Vehicles.frmVehiclesList frmVehiclesList;
        private Bookings.frmBookingsList frmBookingsList;
        private Transactions.frmTransactionsList frmTransactionsList;
        private Returns.frmReturnsList frmReturnsList;
        private Users.frmUsersList frmUsersList;
        private Maintenance.frmMaintenanceList frmMaintenanceList;

        public frmMain()
        {
            InitializeComponent();
            frmDashboard = new Dashboard.frmDashboard();
            frmPeopleList = new People.frmPeopleList();
            frmCustomersList = new Customers.frmCustomersList();
            frmVehiclesList = new Vehicles.frmVehiclesList();
            frmBookingsList = new Bookings.frmBookingsList();
            frmTransactionsList = new Transactions.frmTransactionsList();
            frmReturnsList = new Returns.frmReturnsList();
            frmUsersList = new Users.frmUsersList();
            frmMaintenanceList = new Maintenance.frmMaintenanceList();
        }

        private void lblFormTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSubForm(Form frm)
        {
            if (pnlMain.Controls.Count > 0)
                pnlMain.Controls.RemoveAt(0);

            if (frm == null)
                return;

            lblFormTitle.Text = frm.Text;

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(null, null);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmDashboard, (clsUser.enPermissions) GlobalClasses.clsGlobal.CurrentUser.Permissions, 56);
        }

        private void NavigateToSection(Form frm, clsUser.enPermissions Permission, int y)
        {
            pbImageSidebar.Location = new Point(136, y);

            if (!clsGlobal.CurrentUser.CheckUserPermission(Permission))
            {
                MessageBox.Show("You do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnDashboard.PerformClick();
                return;
            }
            LoadSubForm(frm);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmPeopleList, clsUser.enPermissions.MangePeople, 108);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmCustomersList, clsUser.enPermissions.MangeCustomers, 160);
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmVehiclesList, clsUser.enPermissions.MangeVehicles, 209);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmBookingsList, clsUser.enPermissions.MangeBookings, 258);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmTransactionsList, clsUser.enPermissions.MangeTransactions, 310);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmReturnsList, clsUser.enPermissions.MangeReturns, 362);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmUsersList, clsUser.enPermissions.MangeUsers, 414);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            NavigateToSection(frmMaintenanceList, clsUser.enPermissions.MangeMaintenance, 463);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnClose.PerformClick();
        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            var frm = new Users.frmUserDetails(GlobalClasses.clsGlobal.CurrentUser.UserID.Value);
            frm.ShowDialog();
        }
    }
}
