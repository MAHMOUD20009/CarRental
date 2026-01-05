using System;
using CarRental.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Vehicles
{
    public partial class frmFindVehicle : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindVehicle_MouseDown(object sender, MouseEventArgs e)
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

        public event Action<int> OnVehicleSelected;

        protected virtual void VehicleSelected(int VehicleID)
        {
            Action<int> Handler = OnVehicleSelected;

            if (Handler != null)
            {
                Handler(VehicleID);
            }
        }

        private int? _VehicleID;

        public frmFindVehicle()
        {
            InitializeComponent();
        }

        public frmFindVehicle(int VehicleID)
        {
            InitializeComponent();
            _VehicleID = VehicleID;
            ctrlVehicleCardWithFilter1.LoadVehicleInfo(VehicleID);
        }

        private void ctrlVehicleCardWithFilter1_OnVehicleSelected(int VehicleID)
        {
            _VehicleID = VehicleID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(_VehicleID != null)
                VehicleSelected(_VehicleID.Value);
            
            btnCloseForm.PerformClick();
        }
    }
}
