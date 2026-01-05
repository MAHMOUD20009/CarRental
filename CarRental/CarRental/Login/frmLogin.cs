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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool PasswordVisible = false;
        private void TogglePasswordVisibility_OnIconRightClick(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = PasswordVisible;

            PasswordVisible = !PasswordVisible;

            txtPassword.IconRight = (PasswordVisible) ? Properties.Resources.eye_Close : Properties.Resources.eye_Open;
        }

        private bool AuthenticateUserCretentials()
        {
            if (!this.ValidateChildren())
                return false;

            clsGlobal.CurrentUser = clsUser.FindUser(txtUserName.Text.Trim());

            if (clsGlobal.CurrentUser == null || clsGlobal.CurrentUser.Password != clsSecurityUtils.Encryption(txtPassword.Text.Trim()))
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
            var frm = new Main.frmMain();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AuthenticateUserCretentials())
            {
                if (chkRememberMe.Checked) clsGlobal.SaveLoginToRegistry(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                else clsGlobal.SaveLoginToRegistry(null, null);
                   
                OpenMainForm();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = null, Password = null;

            if(clsGlobal.LoadLoginInfoFromRegistry(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        
    }
}
