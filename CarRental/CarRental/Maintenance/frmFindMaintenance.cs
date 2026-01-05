using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Maintenance
{
    public partial class frmFindMaintenance : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindMaintenance_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public event Action<int> OnMaintenanceelected;

        protected virtual void Maintenanceelected(int MaintenanceID)
        {
            Action<int> Handler = OnMaintenanceelected;

            if (Handler != null)
            {
                Handler(MaintenanceID);
            }
        }

        private int? _MaintenanceID;

        public frmFindMaintenance()
        {
            InitializeComponent();
        }

        private void ctrlMaintenanceCardWithFilter1_OnMaintenanceelected(int MaintenanceID)
        {
            _MaintenanceID = MaintenanceID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_MaintenanceID.HasValue)
                Maintenanceelected(_MaintenanceID.Value);

            btnCloseForm.PerformClick();
        }
    }
}
