using System;
using CarRental.GlobalClasses;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.Users
{
    public partial class frmAddUpdateUser : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParmam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTIN = 0x2;

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public bool IsDataChanged { private set; get; }

        private clsPerson _Person;

        private clsUser _User;
        private int _UserID;

        public delegate void DataBackEventHandler(int UserID);
        public DataBackEventHandler DataBack;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _SetFormTitleByMode(enMode.AddNew);
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _SetFormTitleByMode(enMode.Update);
        }

        private void _SetFormTitleByMode(enMode Mode)
        {
            _Mode = Mode;

            lblFormTitle.Text = (Mode == enMode.AddNew) ? "Add New User" : "Update User Info";
        }

        private void frmAddUpdateUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void LoadData()
        {
            if (_Mode == enMode.AddNew)
                return;

            _User = clsUser.FindUser(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User With Id : " + _UserID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblShowUserId.Text = "[" + _User.UserID + "]";
            txtUserName.Text = _User.UserName;
            chkIsActive.Checked = _User.IsActive.Value;

            chkAllPermissions.Checked = (_User.Permissions == (int)clsUser.enPermissions.AllPermissions || _User.Permissions == 63);
            if (!chkAllPermissions.Checked)
            {
                chkMangePeople.Checked = _User.CheckUserPermission(clsUser.enPermissions.MangePeople);
                chkMangeCustomers.Checked = _User.CheckUserPermission(clsUser.enPermissions.MangeCustomers);
                chkMangeVehicles.Checked = _User.CheckUserPermission(clsUser.enPermissions.MangeVehicles);
                chkMangeBookings.Checked = _User.CheckUserPermission(clsUser.enPermissions.MangeBookings);
                chkMangeTransactions.Checked = _User.CheckUserPermission(clsUser.enPermissions.MangeTransactions);
                chkMangeReturns.Checked = _User.CheckUserPermission(clsUser.enPermissions.MangeReturns);
                chkMangeUsers.Checked = _User.CheckUserPermission(clsUser.enPermissions.MangeUsers);
            }

            _Person = _User.PersonInfo;

            lblShowPersonID.Text = "[" + _Person.PersonID + "]";
            txtName.Text = _Person.Name;

            txtUserName.ReadOnly = true;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_Mode == enMode.AddNew && clsUser.IsUserExists(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "User Name is used for another user!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
                e.Cancel = false;
            }
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
                e.Cancel = false;
            }
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            var frm = _Mode == enMode.AddNew? new People.frmFindPerson() : new People.frmFindPerson(_Person.PersonID.Value);
            frm.OnPersonSelected += frmFindPerson_OnPersonSelected;
            frm.ShowDialog();
        }

        private void ResetControlsPerson()
        {
            lblShowPersonID.Text = "[?????]";
            txtName.Clear();
        }

        private void frmFindPerson_OnPersonSelected(int PersonID)
        {
            _Person = clsPerson.FindPerson(PersonID);
            if (_Person == null)
            {
                ResetControlsPerson();
                return;
            }

            if (_Mode == enMode.AddNew && clsUser.IsUserExistsByPersonID(PersonID))
            {
                MessageBox.Show("This person is already in use by another User", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _Person = null;
                ResetControlsPerson();
                return;
            }

            lblShowPersonID.Text = "[" + _Person.PersonID + "]";
            txtName.Text = _Person.Name;
        }

        private int GetPermissions()
        {
            int Permissions = 0;

            if (chkAllPermissions.Checked)
                return (int)clsUser.enPermissions.AllPermissions;

            if (chkMangePeople.Checked)
                Permissions += (int)clsUser.enPermissions.MangePeople;

            if (chkMangeCustomers.Checked)
                Permissions += (int)clsUser.enPermissions.MangeCustomers;

            if (chkMangeVehicles.Checked)
                Permissions += (int)clsUser.enPermissions.MangeVehicles;

            if (chkMangeBookings.Checked)
                Permissions += (int)clsUser.enPermissions.MangeBookings;

            if (chkMangeTransactions.Checked)
                Permissions += (int)clsUser.enPermissions.MangeTransactions;

            if (chkMangeReturns.Checked)
                Permissions += (int)clsUser.enPermissions.MangeReturns;

            if (chkMangeUsers.Checked)
                Permissions += (int)clsUser.enPermissions.MangeUsers;

            if(Permissions == 63)
                return (int)clsUser.enPermissions.AllPermissions;

            return Permissions;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Person == null)
            {
                MessageBox.Show("Please select a person first.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_User == null)
                _User = new clsUser();

            _User.PersonID = _Person.PersonID;
            _User.UserName = txtUserName.Text.Trim();

            if (_Mode == enMode.AddNew || !string.IsNullOrEmpty(txtPassword.Text.Trim()))
                _User.Password = txtPassword.Text.Trim();

            _User.Permissions = GetPermissions();
            _User.IsActive = chkIsActive.Checked;


            if (_User.Save())
            {
                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblShowUserId.Text = "[" + _User.UserID + "]";

                IsDataChanged = true;

                _SetFormTitleByMode(enMode.Update);

                if (DataBack != null)
                    DataBack.Invoke(_User.UserID.Value);
            }
            else
            {
                MessageBox.Show("Failed to save the data. Please try again.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            chkMangePeople.Checked = chkAllPermissions.Checked;
            chkMangeCustomers.Checked = chkAllPermissions.Checked;
            chkMangeVehicles.Checked = chkAllPermissions.Checked;
            chkMangeBookings.Checked = chkAllPermissions.Checked;
            chkMangeTransactions.Checked = chkAllPermissions.Checked;
            chkMangeReturns.Checked = chkAllPermissions.Checked;
            chkMangeUsers.Checked = chkAllPermissions.Checked;
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

    }
}
