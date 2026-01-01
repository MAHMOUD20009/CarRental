using System;
using CarRental.Users;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        public clsUser User { private set; get; }

        public int? UserID { private set; get; }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void FillControls()
        {
            UserID = User.UserID;

            ctrlPersonCard1.LoadPersonInfo(User.PersonInfo);

            lblShowUserD.Text = "[" + User.UserID + "]";
            lblShowUserName.Text = User.UserName;
            lblShowIsActive.Text = (User.IsActive.Value) ? "Active" : "Inactive";
            pbIsActive.Image = (User.IsActive.Value)? Properties.Resources.active_user : Properties.Resources.inactive_user; 

            lblEditUserInfo.Enabled = true;
        }

        public void ResetControls()
        {
            UserID = null;

            ctrlPersonCard1.ResetControls();

            lblShowUserD.Text = "[?????]";
            lblShowUserName.Text = "?????";
            lblShowIsActive.Text = "?????";

            lblEditUserInfo.Enabled = false;
        }

        public void LoadUserInfo(int UserID)
        {
            User = clsUser.FindUser(UserID);

            if(User == null)
            {
                MessageBox.Show("No User With Id : " + UserID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        public void LoadUserInfoByPersonID(int PersonID)
        {
            User = clsUser.FindUserByPersonID(PersonID);

            if (User == null)
            {
                MessageBox.Show("No User With Person Id : " + PersonID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        public void LoadUserInfo(string UserName)
        {
            User = clsUser.FindUser(UserName);

            if (User == null)
            {
                MessageBox.Show("No User With User Name : " + UserName, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        public void LoadUserInfo(clsUser User)
        {
            this.User = User;

            if (User == null)
            {
                MessageBox.Show("No record found for this person", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        private void lblEditUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmAddUpdateUser(UserID.Value);
            frm.ShowDialog();

            if (frm.IsDataChanged)
                LoadUserInfo(UserID.Value);
        }
    }
}
