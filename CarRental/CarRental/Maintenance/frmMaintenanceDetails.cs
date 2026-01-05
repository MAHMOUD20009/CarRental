using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Maintenance
{
    public partial class frmMaintenanceDetails : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private int _MaintenanceID;

        public frmMaintenanceDetails(int MaintenanceID)
        {
            InitializeComponent();
            _MaintenanceID = MaintenanceID;
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMaintenanceDetails_Load(object sender, EventArgs e)
        {
            ctrlMaintenanceCard1.LoadMaintenanceInfo(_MaintenanceID);
        }

        private void ctrlMaintenanceCard1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }
    }
}
