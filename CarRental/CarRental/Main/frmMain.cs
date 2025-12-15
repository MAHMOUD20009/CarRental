using System;
using System.Drawing;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        public frmMain()
        {
            InitializeComponent();
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

        private enum enCurrentForm { None = 0, Dashboard = 1, People = 2, Customers = 3, Booking = 4, Transactions = 5, Returns = 6, Users = 7 }
        private enCurrentForm CurrentForm = enCurrentForm.None;

        private void LoadSubForm(Form frm)
        {
            if (pnlMain.Controls.Count > 0)
            {
                Form oldFrm = (Form)pnlMain.Controls[0];
                oldFrm.Close();
                oldFrm.Dispose();
            }

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

            pbImageSidebar.Location = new Point(136, 91);
            LoadSubForm(new Dashboard.frmDashboard());
            CurrentForm = enCurrentForm.Dashboard;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            if (CurrentForm == enCurrentForm.People)
                return;

            pbImageSidebar.Location = new Point(136, 140);
            LoadSubForm(new People.frmPeopleList());
            CurrentForm = enCurrentForm.People;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (CurrentForm == enCurrentForm.Customers)
                return;

            pbImageSidebar.Location = new Point(136, 192);
            LoadSubForm(new Customers.frmCustomersList());
            CurrentForm = enCurrentForm.Customers;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (CurrentForm == enCurrentForm.Booking)
                return;

            pbImageSidebar.Location = new Point(136, 244);
            CurrentForm = enCurrentForm.Booking;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (CurrentForm == enCurrentForm.Transactions)
                return;

            pbImageSidebar.Location = new Point(136, 296);
            CurrentForm = enCurrentForm.Transactions;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (CurrentForm == enCurrentForm.Returns)
                return;

            pbImageSidebar.Location = new Point(136, 348);
            CurrentForm = enCurrentForm.Returns;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (CurrentForm == enCurrentForm.Users)
                return;

            pbImageSidebar.Location = new Point(136, 400);
            CurrentForm = enCurrentForm.Users;
        }








    }
}
