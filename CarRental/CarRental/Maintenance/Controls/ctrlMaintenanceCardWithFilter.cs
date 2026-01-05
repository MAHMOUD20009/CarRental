using System;
using System.Windows.Forms;
using CarRental.Maintenance;
using CarRental.GlobalClasses;
using CarRental_BusinessLogicLayer;

namespace CarRental.Controls
{
    public partial class ctrlMaintenanceCardWithFilter : UserControl
    {
        public event Action<int> OnMaintenanceSelected;

        protected virtual void MaintenanceSelected(int MaintenanceID)
        {
            Action<int> Handler = OnMaintenanceSelected;

            if (Handler != null)
            {
                Handler(MaintenanceID);
            }
        }

        public bool FilterEnabled { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled; } }

        public clsMaintenance Maintenance { get { return ctrlMaintenanceCard1.Maintenance; } }
        public int? MaintenanceID { get { return ctrlMaintenanceCard1.MaintenanceID; } }

        public ctrlMaintenanceCardWithFilter()
        {
            InitializeComponent();
        }

        private void FindNow()
        {
            ctrlMaintenanceCard1.LoadMaintenanceInfo(int.Parse(txtSearchValue.Text));

            MaintenanceSelected(ctrlMaintenanceCard1.MaintenanceID.GetValueOrDefault());
        }

        public void FilterFocus()
        {
            txtSearchValue.Focus();
        }

        public void LoadMaintenanceInfo(int MaintenanceID)
        {
            txtSearchValue.Text = MaintenanceID.ToString();
            FindNow();
        }

        private void btnAddNewMaintenance_Click(object sender, EventArgs e)
        {
            var frm = new frmAddUpdateMaintenance();
            frm.DataBack += frmAddUpdateMaintenance_DataBack;
            frm.ShowDialog();
        }

        private void frmAddUpdateMaintenance_DataBack(int MaintenanceID)
        {
            LoadMaintenanceInfo(MaintenanceID);
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                ctrlMaintenanceCard1.ResetControls();
                MaintenanceSelected(-1);
                return;
            }

            if (txtSearchValue.IsValid) FindNow();
        }

        public void ResetControls()
        {
            txtSearchValue.Clear();
            ctrlMaintenanceCard1.ResetControls();
        }
    }
}
