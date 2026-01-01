using System;
using CarRental.People;
using System.Windows.Forms;
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

        private void frmAddUpdatePerson_DataBack(int PersonID)
        {
            LoadPersonInfo(PersonID);
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearchValue.IsValid || string.IsNullOrEmpty(txtSearchValue.Text)) ctrlPersonCard1.ResetControls();
            else FindNow();  
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlPersonCard1.ResetControls();
        }
    }
}
