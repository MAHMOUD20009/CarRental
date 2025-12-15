using System;
using CarRental.Customers;
using System.Windows.Forms;
using CarRental.GlobalClasses;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlCustomerCardWithFilter : UserControl
    {
        public event Action<int> OnCustomerSelected;

        protected virtual void CustomerSelected(int CustomerID)
        {
            Action<int> Handler = OnCustomerSelected;

            if (Handler != null)
            {
                Handler(CustomerID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsCustomer Customer { get { return ctrlCustomerCard1.Customer; } }
        public int? CustomerID { get { return ctrlCustomerCard1.CustomerID; } }

        public ctrlCustomerCardWithFilter()
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

            switch(cbFilter.Text)
            {
                case "Customer Id":
                    ctrlCustomerCard1.LoadCustomerInfoByCustomerID(Value);
                    break;
                case "Person Id":
                    ctrlCustomerCard1.LoadCustomerInfoByPersonID(Value);
                    break;
            }

            CustomerSelected(ctrlCustomerCard1.CustomerID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadCustomerInfoByCustomerID(int CustomerID)
        {
            txtSearchValue.Text = CustomerID.ToString();
            cbFilter.SelectedIndex = 0;
            FindNow();
        }

        public void LoadCustomerInfoByPersonID(int PersonID)
        {
            txtSearchValue.Text = PersonID.ToString();
            cbFilter.SelectedIndex = 1;
            FindNow();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateCustomer();
            frm.DataBack += frmAddUpdateCustomer_DataBack;
            frm.ShowDialog();
        }

        private void frmAddUpdateCustomer_DataBack(int? CustomerID)
        {
            if (CustomerID != null)
                LoadCustomerInfoByCustomerID(CustomerID.Value);
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
                ctrlCustomerCard1.ResetControls();
        }
    }
}
