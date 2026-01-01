using System;
using CarRental.GlobalClasses;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.Customers
{
    public partial class frmAddUpdateCustomer : Form
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

        private int? _PersonID = null;

        private clsCustomer _Customer;
        private int _CustomerID;

        public delegate void DataBackEventHandler(int CustomerID);
        public DataBackEventHandler DataBack;

        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _SetFormTitleByMode(enMode.AddNew);
        }

        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            _SetFormTitleByMode(enMode.Update);
        }

        private void _SetFormTitleByMode(enMode Mode)
        {
            _Mode = Mode;

            lblFormTitle.Text = (Mode == enMode.AddNew) ? "Add New Customer" : "Update Customer Info";
        }

        private void frmAddUpdateCustomer_MouseDown(object sender, MouseEventArgs e)
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

            _Customer = clsCustomer.FindCustomerByCustomerID(_CustomerID);
            if(_Customer == null)
            {
                MessageBox.Show("No Customer With Id : " + _CustomerID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblShowCustomerId.Text = "[" + _Customer.CustomerID + "]";
            txtDriverLicenseNumber.Text = _Customer.DriverLicenseNumber;
            
            _PersonID = _Customer.PersonID;
            lblShowPersonID.Text = "[" + _PersonID + "]";
            txtName.Text = _Customer.PersonInfo.Name;
        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
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

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            var frm = new People.frmFindPerson();
            frm.OnPersonSelected += frmFindPerson_OnPersonSelected;
            frm.ShowDialog();
        }

        private void frmFindPerson_OnPersonSelected(int PersonID)
        {
            clsPerson Person = clsPerson.FindPerson(PersonID);
            if (Person == null)
            {
                MessageBox.Show("No Person With Id : " + PersonID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _PersonID = null;
                lblShowPersonID.Text = "[?????]";
                txtName.Clear();
                return;
            }

            _PersonID = PersonID;

            lblShowPersonID.Text = "[" + PersonID + "]";
            txtName.Text = Person.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Customer == null)
                _Customer = new clsCustomer();

            _Customer.PersonID = _PersonID;
            _Customer.DriverLicenseNumber = txtDriverLicenseNumber.Text.Trim();

            if (_Customer.Save())
            {
                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblShowCustomerId.Text = "[" + _Customer.CustomerID + "]";

                IsDataChanged = true;

                _SetFormTitleByMode(enMode.Update);

                if (DataBack != null)
                    DataBack.Invoke(_Customer.CustomerID.Value);
            }
            else
            {
                MessageBox.Show("Failed to save the data. Please try again.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
