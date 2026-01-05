using System;
using CarRental.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Returns
{
    public partial class frmFindReturn : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindReturn_MouseDown(object sender, MouseEventArgs e)
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

        public event Action<int> OnReturnSelected;

        protected virtual void ReturnSelected(int ReturnID)
        {
            Action<int> Handler = OnReturnSelected;

            if (Handler != null)
            {
                Handler(ReturnID);
            }
        }

        private int? _ReturnID;

        public frmFindReturn()
        {
            InitializeComponent();
        }

        public frmFindReturn(int ReturnID)
        {
            InitializeComponent();
            _ReturnID = ReturnID;
            ctrlReturnCardWithFilter1.LoadReturnInfo(ReturnID);
        }

        private void ctrlReturnCardWithFilter1_OnReturnSelected(int ReturnID)
        {
            _ReturnID = ReturnID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(_ReturnID != null)
                ReturnSelected(_ReturnID.Value);
            
            btnCloseForm.PerformClick();
        }
    }
}
