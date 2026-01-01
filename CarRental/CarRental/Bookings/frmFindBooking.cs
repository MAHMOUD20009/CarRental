using System;
using CarRental.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental.Bookings
{
    public partial class frmFindBooking : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private void frmFindBooking_MouseDown(object sender, MouseEventArgs e)
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

        public event Action<int> OnBookingSelected;

        protected virtual void BookingSelected(int BookingID)
        {
            Action<int> Handler = OnBookingSelected;

            if (Handler != null)
            {
                Handler(BookingID);
            }
        }

        private int? _BookingID;

        public frmFindBooking()
        {
            InitializeComponent();
        }

        private void ctrlBookingCardWithFilter1_OnBookingSelected(int BookingID)
        {
            _BookingID = BookingID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(_BookingID != null)
                BookingSelected(_BookingID.Value);
            
            btnCloseForm.PerformClick();
        }
    }
}
