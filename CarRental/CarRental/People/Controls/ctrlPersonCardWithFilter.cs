using System;
using CarRental.People;
using System.Windows.Forms;
using CarRental.GlobalClasses;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if (Handler != null)
            {
                Handler(PersonID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsPerson Person { get { return ctrlPersonCard1.Person; } }
        public int? PersonID { get { return ctrlPersonCard1.PersonID; } }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindNow()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Value;

            if (!int.TryParse(txtSearchValue.Text, out Value))
                return;

            ctrlPersonCard1.LoadPersonInfo(Value);

            PersonSelected(ctrlPersonCard1.PersonID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadPersonInfo(int PersonID)
        {
            txtSearchValue.Text = PersonID.ToString();
            FindNow();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdatePerson();
            frm.DataBack += frmAddUpdatePerson_DataBack;
            frm.ShowDialog();
        }

        private void frmAddUpdatePerson_DataBack(int? PersonID)
        {
            if (PersonID != null)
                LoadPersonInfo(PersonID.Value);
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }

        private void txtSearchValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                errorProvider1.SetError(txtSearchValue, null);
                e.Cancel = false;
                return;
            }

            if (!clsValidation.IsNumber(txtSearchValue.Text.Trim()))
            {
                errorProvider1.SetError(txtSearchValue, "Invalid Number");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtSearchValue, null);
                e.Cancel = false;
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearchValue.Text))
                FindNow();
            else
                ctrlPersonCard1.ResetControls();
        }
    }
}
