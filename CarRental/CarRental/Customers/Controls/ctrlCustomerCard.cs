using System;
using CarRental.Customers;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlCustomerCard : UserControl
    {
        public clsCustomer Customer { private set; get; }

        public int? CustomerID { private set; get; }

        public ctrlCustomerCard()
        {
            InitializeComponent();
        }

        private void FillControls()
        {
            CustomerID = Customer.CustomerID;

            ctrlPersonCard1.LoadPersonInfo(Customer.PersonInfo);

            lblShowCustomerD.Text = "[" + Customer.CustomerID + "]";
            lblShowDriverLicenseNumber.Text = Customer.DriverLicenseNumber;

            lblEditCustomerInfo.Enabled = true;
        }

        public void ResetControls()
        {
            CustomerID = null;

            ctrlPersonCard1.ResetControls();

            lblShowCustomerD.Text = "[?????]";
            lblShowDriverLicenseNumber.Text = "?????";

            lblEditCustomerInfo.Enabled = false;
        }

        public void LoadCustomerInfoByCustomerID(int CustomerID)
        {
            Customer = clsCustomer.FindCustomerByCustomerID(CustomerID);

            if(Customer == null)
            {
                MessageBox.Show("No Customer With Id : " + CustomerID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        public void LoadCustomerInfoByPersonID(int PersonID)
        {
            Customer = clsCustomer.FindCustomerByPersonID(PersonID);

            if (Customer == null)
            {
                MessageBox.Show("No Customer With Person Id : " + PersonID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        public void LoadCustomerInfo(clsCustomer Customer)
        {
            this.Customer = Customer;

            if (Customer == null)
            {
                MessageBox.Show("No record found for this person", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            FillControls();
        }

        private void lblEditCustomerInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmAddUpdateCustomer(CustomerID.Value);
            frm.ShowDialog();

            if (frm.IsDataChanged)
                LoadCustomerInfoByCustomerID(CustomerID.Value);
        }
    }
}
