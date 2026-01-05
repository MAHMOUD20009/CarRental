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
            switch (cbFilter.Text)
            {
                case "Customer Id": ctrlCustomerCard1.LoadCustomerInfoByCustomerID(int.Parse(txtSearchValue.Text)); break;
                case "Person Id": ctrlCustomerCard1.LoadCustomerInfoByPersonID(int.Parse(txtSearchValue.Text)); break;
            }

            CustomerSelected(ctrlCustomerCard1.CustomerID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadCustomerInfo(int CustomerID)
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

        private void frmAddUpdateCustomer_DataBack(int CustomerID)
        {
            LoadCustomerInfo(CustomerID);
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearchValue.Text))
            {
                ctrlCustomerCard1.ResetControls();
                CustomerSelected(-1);
                return;
            }

            if (txtSearchValue.IsValid) FindNow();
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlCustomerCard1.ResetControls();
        }
    }
}
