using System;
using CarRental.Users;
using System.Windows.Forms;
using CarRental.GlobalClasses;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlUserCardWithFilter : UserControl
    {
        public event Action<int> OnUserSelected;

        protected virtual void UserSelected(int UserID)
        {
            Action<int> Handler = OnUserSelected;

            if (Handler != null)
            {
                Handler(UserID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsUser User { get { return ctrlUserCard1.User; } }
        public int? UserID { get { return ctrlUserCard1.UserID; } }

        public ctrlUserCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "User Id":
                    ctrlUserCard1.LoadUserInfo(Convert.ToInt32(txtSearchValue.Text.Trim()));
                    break;
                case "Person Id":
                    ctrlUserCard1.LoadUserInfoByPersonID(Convert.ToInt32(txtSearchValue.Text.Trim()));
                    break;
                case "User Name":
                    ctrlUserCard1.LoadUserInfo(txtSearchValue.Text.Trim());
                    break;
            }

            UserSelected(ctrlUserCard1.UserID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadUserInfoByUserID(int UserID)
        {
            txtSearchValue.Text = UserID.ToString();
            cbFilter.SelectedIndex = 0;
            FindNow();
        }

        public void LoadUserInfoByUserName(string UserName)
        {
            txtSearchValue.Text = UserName;
            cbFilter.SelectedIndex = 2;
            FindNow();
        }

        public void LoadUserInfoByPersonID(int PersonID)
        {
            txtSearchValue.Text = PersonID.ToString();
            cbFilter.SelectedIndex = 1;
            FindNow();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateUser();
            frm.DataBack += frmAddUpdateUser_DataBack;
            frm.ShowDialog();
        }

        private void frmAddUpdateUser_DataBack(int UserID)
        {
            LoadUserInfoByUserID(UserID);
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearchValue.IsValid || string.IsNullOrEmpty(txtSearchValue.Text)) ctrlUserCard1.ResetControls();
            else FindNow();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "User Name")
            {
                txtSearchValue.CustomValidationMessage = "Invalid User Name";
                txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            }
            else
            {
                txtSearchValue.CustomValidationMessage = "Invalid Id";
                txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            }
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlUserCard1.ResetControls();
        }
    }
}
