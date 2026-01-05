using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Users
{
    public partial class frmFindUser : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindUser_MouseDown(object sender, MouseEventArgs e)
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

        public event Action<int> OnUserSelected;

        protected virtual void UserSelected(int UserID)
        {
            Action<int> Handler = OnUserSelected;

            if (Handler != null)
            {
                Handler(UserID);
            }
        }

        private int? _UserID;

        public frmFindUser()
        {
            InitializeComponent();
        }

        public frmFindUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            ctrlUserCardWithFilter1.LoadUserInfo(UserID);
        }

        private void ctrlUserCardWithFilter1_OnUserSelected(int UserID)
        {
            _UserID = UserID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_UserID != null)
                UserSelected(_UserID.GetValueOrDefault());

            btnCloseForm.PerformClick();
        }
    }
}
