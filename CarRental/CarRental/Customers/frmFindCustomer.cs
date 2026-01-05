using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Customers
{
    public partial class frmFindCustomer : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindCustomer_MouseDown(object sender, MouseEventArgs e)
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

        public event Action<int> OnCustomerSelected;

        protected virtual void CustomerSelected(int CustomerID)
        {
            Action<int> Handler = OnCustomerSelected;

            if (Handler != null)
            {
                Handler(CustomerID);
            }
        }

        private int? _CustomerID;

        public frmFindCustomer()
        {
            InitializeComponent();
        }

        public frmFindCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            ctrlCustomerCardWithFilter1.LoadCustomerInfo(CustomerID);
        }

        private void ctrlCustomerCardWithFilter1_OnCustomerSelected(int CustomerID)
        {
            _CustomerID = CustomerID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_CustomerID != null)
                CustomerSelected(_CustomerID.GetValueOrDefault());

            btnCloseForm.PerformClick();
        }
    }
}
