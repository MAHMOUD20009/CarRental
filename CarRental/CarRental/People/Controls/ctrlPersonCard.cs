using System;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        public clsPerson Person { private set;  get; }

        public int? PersonID { private set; get; }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void _FillControls()
        {
            PersonID = Person.PersonID.Value;

            lblShowPersonID.Text = "[" + Person.PersonID + "]";
            lblShowName.Text = Person.Name;
            lblShowGender.Text = (Person.Gender.Value) ? "Female" : "Male";
            lblShowDateOfBirth.Text = Person.DateOfBirth.Value.ToString("dd/MMM/yyyy");
            lblShowPhone.Text = Person.Phone;
            lblShowEmail.Text = (Person.Email == string.Empty) ? "Not Set" : Person.Email;

            lblEditPersonInfo.Enabled = true;
        }

        public void ResetControls()
        {
            PersonID = null;

            lblShowPersonID.Text = "[?????]";
            lblShowName.Text = "?????";
            lblShowGender.Text = "?????";
            lblShowDateOfBirth.Text = "?????";
            lblShowPhone.Text = "?????";
            lblShowEmail.Text = "?????";

            lblEditPersonInfo.Enabled = false;
        }

        public void LoadPersonInfo(int PersonID)
        {
            Person = clsPerson.FindPerson(PersonID);

            if (Person == null)
            {
                MessageBox.Show("No Person With Id : " + PersonID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        public void LoadPersonInfo(clsPerson Person)
        {
            this.Person = Person;

            if (Person == null)
            {
                MessageBox.Show("No record found for this person", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetControls();
                return;
            }

            _FillControls();
        }

        private void lblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new People.frmAddUpdatePerson(PersonID.Value);
            frm.ShowDialog();

            if (frm.IsDataChanged)
                LoadPersonInfo(PersonID.Value);
        }
    }
}
