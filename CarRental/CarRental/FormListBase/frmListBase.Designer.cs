namespace CarRental.FormListBase
{
     partial class frmListBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvDataList = new Guna.UI.WinForms.GunaDataGridView();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI.WinForms.GunaComboBox();
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.btnAddNewRecord = new Guna.UI.WinForms.GunaButton();
            this.btnPreviousPage = new Guna.UI.WinForms.GunaButton();
            this.btnNextPage = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsServices
            // 
            this.cmsServices.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsServices.Name = "cmsPeopleListServices";
            this.cmsServices.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvDataList
            // 
            this.dgvDataList.AllowUserToAddRows = false;
            this.dgvDataList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataList.ColumnHeadersHeight = 20;
            this.dgvDataList.ContextMenuStrip = this.cmsServices;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataList.EnableHeadersVisualStyles = false;
            this.dgvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvDataList.Location = new System.Drawing.Point(9, 105);
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersVisible = false;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(916, 431);
            this.dgvDataList.TabIndex = 3;
            this.dgvDataList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightBlue;
            this.dgvDataList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvDataList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDataList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDataList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDataList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDataList.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvDataList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvDataList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgvDataList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDataList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDataList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDataList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDataList.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvDataList.ThemeStyle.ReadOnly = true;
            this.dgvDataList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvDataList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDataList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDataList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDataList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvDataList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblRecords
            // 
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.Black;
            this.lblRecords.Location = new System.Drawing.Point(0, 539);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(933, 31);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "#Records : 0";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(12, 66);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(86, 34);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BaseColor = System.Drawing.Color.White;
            this.cbFilter.BorderColor = System.Drawing.Color.Silver;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None"});
            this.cbFilter.Location = new System.Drawing.Point(114, 70);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilter.Radius = 12;
            this.cbFilter.Size = new System.Drawing.Size(166, 30);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.AllowEmpty = true;
            this.txtSearchValue.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchValue.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchValue.BorderRadius = 12;
            this.txtSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.CustomValidationMessage = null;
            this.txtSearchValue.DefaultText = "";
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.TextInput;
            this.txtSearchValue.Location = new System.Drawing.Point(302, 66);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchValue.PlaceholderText = "";
            this.txtSearchValue.SelectedText = "";
            this.txtSearchValue.Size = new System.Drawing.Size(211, 34);
            this.txtSearchValue.TabIndex = 1;
            this.txtSearchValue.ValidateInputType = true;
            this.txtSearchValue.Visible = false;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewRecord.AnimationHoverSpeed = 0.07F;
            this.btnAddNewRecord.AnimationSpeed = 0.03F;
            this.btnAddNewRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewRecord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAddNewRecord.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewRecord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewRecord.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRecord.Image = null;
            this.btnAddNewRecord.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddNewRecord.Location = new System.Drawing.Point(779, 61);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNewRecord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewRecord.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewRecord.OnHoverImage = null;
            this.btnAddNewRecord.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewRecord.Radius = 12;
            this.btnAddNewRecord.Size = new System.Drawing.Size(146, 38);
            this.btnAddNewRecord.TabIndex = 4;
            this.btnAddNewRecord.Text = "Add New Record";
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviousPage.AnimationHoverSpeed = 0.07F;
            this.btnPreviousPage.AnimationSpeed = 0.03F;
            this.btnPreviousPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPreviousPage.BorderColor = System.Drawing.Color.Black;
            this.btnPreviousPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPreviousPage.FocusedColor = System.Drawing.Color.Empty;
            this.btnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Image = global::CarRental.Properties.Resources.previous;
            this.btnPreviousPage.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPreviousPage.Location = new System.Drawing.Point(9, 539);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPreviousPage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPreviousPage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.OnHoverImage = null;
            this.btnPreviousPage.OnPressedColor = System.Drawing.Color.Black;
            this.btnPreviousPage.Radius = 12;
            this.btnPreviousPage.Size = new System.Drawing.Size(117, 28);
            this.btnPreviousPage.TabIndex = 6;
            this.btnPreviousPage.Text = "Previous";
            this.btnPreviousPage.Visible = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.AnimationHoverSpeed = 0.07F;
            this.btnNextPage.AnimationSpeed = 0.03F;
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNextPage.BorderColor = System.Drawing.Color.Black;
            this.btnNextPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextPage.FocusedColor = System.Drawing.Color.Empty;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Image = global::CarRental.Properties.Resources.next;
            this.btnNextPage.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextPage.Location = new System.Drawing.Point(811, 539);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNextPage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNextPage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNextPage.OnHoverImage = null;
            this.btnNextPage.OnPressedColor = System.Drawing.Color.Black;
            this.btnNextPage.Radius = 12;
            this.btnNextPage.Size = new System.Drawing.Size(117, 28);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "   Next";
            this.btnNextPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnAddNewRecord);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvDataList);
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblRecords;
        protected System.Windows.Forms.Label lblFilter;
        protected CustomContorls.CustomTextBox txtSearchValue;
        protected Guna.UI.WinForms.GunaButton btnNextPage;
        protected Guna.UI.WinForms.GunaButton btnPreviousPage;
        protected Guna.UI.WinForms.GunaButton btnAddNewRecord;
        protected Guna.UI.WinForms.GunaComboBox cbFilter;
        protected Guna.UI.WinForms.GunaDataGridView dgvDataList;
        protected System.Windows.Forms.ContextMenuStrip cmsServices;
    }
}