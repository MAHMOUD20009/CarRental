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

        private enum enCurrentForm { None = 0, Dashboard = 1, People = 2, Customers = 3, Vehicles = 4, Booking = 5, Transactions = 6, Returns = 7, Users = 8 }
        private enCurrentForm CurrentForm = enCurrentForm.None;

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
            if (CurrentForm == enCurrentForm.Dashboard)
                return;

            pbImageSidebar.Location = new Point(136, 88);
            LoadSubForm(frmDashboard);
            CurrentForm = enCurrentForm.Dashboard;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserPermission(clsUser.enPermissions.MangePeople))
            {
                MessageBox.Show("You do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CurrentForm == enCurrentForm.People)
                return;

            pbImageSidebar.Location = new Point(136, 140);
            LoadSubForm(frmPeopleList);
            CurrentForm = enCurrentForm.People;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserPermission(clsUser.enPermissions.MangeCustomers))
            {
                MessageBox.Show("You do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CurrentForm == enCurrentForm.Customers)
                return;

            pbImageSidebar.Location = new Point(136, 192);
            LoadSubForm(frmCustomersList);
            CurrentForm = enCurrentForm.Customers;
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserPermission(clsUser.enPermissions.MangeVehicles))
            {
                MessageBox.Show("you do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CurrentForm == enCurrentForm.Vehicles)
                return;

            pbImageSidebar.Location = new Point(141, 241);
            LoadSubForm(frmVehiclesList);
            CurrentForm = enCurrentForm.Vehicles;
            
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserPermission(clsUser.enPermissions.MangeBookings))
            {
                MessageBox.Show("you do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CurrentForm == enCurrentForm.Booking)
                return;

            pbImageSidebar.Location = new Point(141, 290);
            LoadSubForm(frmBookingsList);
            CurrentForm = enCurrentForm.Booking;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserPermission(clsUser.enPermissions.MangeTransactions))
            {
                MessageBox.Show("you do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CurrentForm == enCurrentForm.Transactions)
                return;

            pbImageSidebar.Location = new Point(141, 342);
            LoadSubForm(frmTransactionsList);
            CurrentForm = enCurrentForm.Transactions;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserPermission(clsUser.enPermissions.MangeReturns))
            {
                MessageBox.Show("you do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CurrentForm == enCurrentForm.Returns)
                return;

            pbImageSidebar.Location = new Point(141, 394);
            LoadSubForm(frmReturnsList);
            CurrentForm = enCurrentForm.Returns;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserPermission(clsUser.enPermissions.MangeUsers))
            {
                MessageBox.Show("you do not have permission to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (CurrentForm == enCurrentForm.Users)
                return;

            pbImageSidebar.Location = new Point(141, 446);
            LoadSubForm(frmUsersList);
            CurrentForm = enCurrentForm.Users;
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
