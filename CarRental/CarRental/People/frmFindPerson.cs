using System;
using CarRental.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.People
{
    public partial class frmFindPerson : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindPerson_MouseDown(object sender, MouseEventArgs e)
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

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if (Handler != null)
            {
                Handler(PersonID);
            }
        }

        private int? _PersonID;

        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int PersonID)
        {
            _PersonID = PersonID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(_PersonID != null)
                PersonSelected(_PersonID.Value);
            
            btnCloseForm.PerformClick();
        }
    }
}
