using System;
using System.Windows.Forms;
using CarRental.Returns;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlReturnCardWithFilter : UserControl
    {
        public event Action<int> OnReturnSelected;

        protected virtual void ReturnSelected(int ReturnID)
        {
            Action<int> Handler = OnReturnSelected;

            if (Handler != null)
            {
                Handler(ReturnID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsVehicleReturn Return { get { return ctrlReturnCard1.Return; } }
        public int? ReturnID { get { return ctrlReturnCard1.ReturnID; } }

        public ctrlReturnCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "Return Id": ctrlReturnCard1.LoadReturnInfo(int.Parse(txtSearchValue.Text)); break;
                case "Booking Id": ctrlReturnCard1.LoadReturnInfoByBookingID(int.Parse(txtSearchValue.Text)); break;
            }

            ReturnSelected(ctrlReturnCard1.ReturnID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadReturnInfo(int ReturnID)
        {
            cbFilter.SelectedIndex = 0;
            txtSearchValue.Text = ReturnID.ToString();
            FindNow();
        }

        public void LoadReturnInfoByBookingID(int BookingID)
        {
            cbFilter.SelectedIndex = 1;
            txtSearchValue.Text = BookingID.ToString();
            FindNow();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearchValue.IsValid || string.IsNullOrEmpty(txtSearchValue.Text)) ctrlReturnCard1.ResetControls();
            else FindNow();
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlReturnCard1.ResetControls();
        }
    }
}
