using System;
using System.Windows.Forms;
using CarRental.GlobalClasses;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.Login
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool PasswordVisible = false;
        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = PasswordVisible;

            PasswordVisible = !PasswordVisible;

            txtPassword.IconRight = (PasswordVisible) ? Properties.Resources.eye_Close : Properties.Resources.eye_Open;

        }

        private bool ValidateUserNameAndPassword()
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "Cannot be empty");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Cannot be empty");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }

            return true;
        }

        private bool CheckUserInfo()
        {
            if (!ValidateUserNameAndPassword())
                return false;

            clsGlobal.CurrentUser = clsUser.FindUser(txtUserName.Text.Trim());

            if (clsGlobal.CurrentUser == null || clsSecurityUtils.Encryption(txtPassword.Text.Trim()) != clsGlobal.CurrentUser.Password)
            {
                MessageBox.Show("Invaild UserName/Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!clsGlobal.CurrentUser.IsActive.Value)
            {
                MessageBox.Show("Your Account is currently inactive Access denied.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void OpenMainForm()
        {
            this.Hide();

            Main.frmMain frm = new Main.frmMain();
            frm.ShowDialog();

            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckUserInfo())
            {
                OpenMainForm();
            }
        }
    }
}
