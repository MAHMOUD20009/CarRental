using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;

namespace CarRental.FormListBase
{
    public partial class frmListBase : Form
    {
        protected DataTable DTDataList = new DataTable();

        protected frmListBase()
        {
            InitializeComponent();
        }

        private int _TotalPages;
        private int _PageNumber;
        private int _RowsPerPage;

        protected int PageNumber { 
            set 
            {
                _PageNumber = value <= 1 ? 1 : value;
                btnPreviousPage.Visible = _PageNumber > 1;
            }
            get
            {
                return _PageNumber;
            }
        }
        
        protected int RowsPerPage 
        {
            set
            {
                _RowsPerPage = value <= 1 ? 1 : value;
            }
            get
            {
                return _RowsPerPage;
            }
        }

        protected int TotalPages
        {
            set
            {
                _TotalPages = value <= 0 ? 0 : value;
                btnNextPage.Visible = _TotalPages > 1;
            }
            get
            {
                return _TotalPages;
            }
        }

        protected virtual void OnPageChanged()
        { }

        protected void RefreshLabelTotalRecords()
        {
            lblRecords.Text = "#Records : " + dgvDataList.Rows.Count;
        }

        protected void RefreshDataList(DataTable DTNewData = null)
        {
            if (DTNewData != null)
                DTDataList = DTNewData;

            DTDataList.DefaultView.RowFilter = string.Empty;
            dgvDataList.DataSource = DTDataList;
            RefreshLabelTotalRecords();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchValue.Visible = false;
            txtSearchValue.Clear();
            RefreshDataList();

            if (cbFilter.Text != "None")
            {
                txtSearchValue.Visible = true;

                if (cbFilter.Text.ToLower().Contains("id")) txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
                else txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.TextInput;
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                RefreshDataList();
                return;
            }

            string ColumnName = cbFilter.Text.Replace(" ", "");

            if (ColumnName.ToLower().Contains("id"))
            {
                if (txtSearchValue.IsValid)
                    DTDataList.DefaultView.RowFilter = "[" + ColumnName + "] = '" + txtSearchValue.Text + "'";
            }
            else
            {
                DTDataList.DefaultView.RowFilter = "[" + ColumnName + "] Like '" + txtSearchValue.Text.Trim() + "%'";
            }

            RefreshLabelTotalRecords();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            PageNumber++;
            OnPageChanged();
            btnPreviousPage.Visible = true;

            if (PageNumber == _TotalPages)
            {
                btnNextPage.Visible = false;
                return;
            }

        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            PageNumber--;
            OnPageChanged();
            btnNextPage.Visible = true;

            if (PageNumber == 1)
            {
                btnPreviousPage.Visible = false;
                return;
            }
        }
    }
}
