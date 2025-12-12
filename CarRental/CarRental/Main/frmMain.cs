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
            Application.Exit();
        }
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pbImageSidebar.Location = new Point(136, 91);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            pbImageSidebar.Location = new Point(136, 140);

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            pbImageSidebar.Location = new Point(136, 192);

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            pbImageSidebar.Location = new Point(136, 244);

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            pbImageSidebar.Location = new Point(136, 296);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pbImageSidebar.Location = new Point(136, 348);

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pbImageSidebar.Location = new Point(136, 400);

        }
    
    
    
    
    
    
    }
}
