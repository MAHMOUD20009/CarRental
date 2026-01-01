using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Transactions
{
    public partial class frmFindTransaction : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindTransaction_MouseDown(object sender, MouseEventArgs e)
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

        public event Action<int> OnTransactionSelected;

        protected virtual void TransactionSelected(int TransactionID)
        {
            Action<int> Handler = OnTransactionSelected;

            if (Handler != null)
            {
                Handler(TransactionID);
            }
        }

        private int? _TransactionID;

        public frmFindTransaction()
        {
            InitializeComponent();
        }

        private void ctrlTransactionCardWithFilter1_OnTransactionSelected(int TransactionID)
        {
            _TransactionID = TransactionID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(_TransactionID != null)
                TransactionSelected(_TransactionID.Value);
            
            btnCloseForm.PerformClick();
        }
    }
}
