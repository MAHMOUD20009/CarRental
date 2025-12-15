using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Customers
{
    public partial class frmCustomerDetails : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private int _CustomerID;

        public frmCustomerDetails(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            ctrlCustomerCard1.LoadCustomerInfoByCustomerID(_CustomerID);
        }

        private void ctrlCustomerCard1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }
    }
}
