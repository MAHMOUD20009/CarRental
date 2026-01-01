using System;
using CarRental.GlobalClasses;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace CarRental.People
{
    public partial class frmAddUpdatePerson : Form
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
        private int? _PersonID;

        public delegate void DataBackEventHandler(int PersonID);
        public DataBackEventHandler DataBack;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _PersonID = null;
            _SetFormTitleByMode(enMode.AddNew);
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _SetFormTitleByMode(enMode.Update);
        }

        private void _SetFormTitleByMode(enMode Mode)
        {
            _Mode = Mode;

            lblFormTitle.Text = (Mode == enMode.AddNew) ? "Add New Person" : "Update Person Info";
        }

        private void frmAddUpdatePerson_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTIN, 0);
            }
        }

        private void LoadData()
        {
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.MaxDate = DateTime.Now;

            if (_Mode == enMode.AddNew)
                return;

            _Person = clsPerson.FindPerson(_PersonID.GetValueOrDefault());
            if (_Person == null)
            {
                MessageBox.Show("No Person With Id : " + _PersonID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblShowPersonID.Text = "[" + _Person.PersonID + "]";
            txtName.Text = _Person.Name;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;

            rbFemale.Checked = _Person.Gender.Value;

            if (_Person.DateOfBirth.Value.Date >= dtpDateOfBirth.MinDate.Date && _Person.DateOfBirth.Value.Date <= dtpDateOfBirth.MaxDate.Date)
                dtpDateOfBirth.Value = _Person.DateOfBirth.Value;
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid. put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Person == null)
                _Person = new clsPerson();

            _Person.Name = txtName.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = !rbMale.Checked;
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();

            if (_Person.Save())
            {
                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblShowPersonID.Text = "[" + _Person.PersonID + "]";

                IsDataChanged = true;

                _SetFormTitleByMode(enMode.Update);

                if (DataBack != null)
                    DataBack.Invoke(_Person.PersonID.Value);
            }
            else
            {
                MessageBox.Show("Failed to save the data. Please try again.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
