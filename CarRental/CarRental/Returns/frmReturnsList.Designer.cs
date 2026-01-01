namespace CarRental.Returns
{
    partial class frmReturnsList
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

        private void InitializeInheritedControls()
        {
            InitializeDataGridView();
            InitializeFilerComboBox();
            InitializeContextMenuStrip();
        }

        private void InitializeDataGridView()
        {
            dgvDataList.CellDoubleClick += dgvDataList_CellDoubleClick;
        }

        private void InitializeFilerComboBox()
        {
            this.cbFilter.Items.AddRange(new object[]{
                "Return ID",
                "Actual Return Date"
            });
        }

        private void InitializeContextMenuStrip()
        {
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnDetailsToolStripMenuItem,
            this.ToolStripSeparator1,
            this.RefreshToolStripMenuItem,
            this.ToolStripSeparator2,
            this.addNewReturnToolStripMenuItem,
            this.updateReturnToolStripMenuItem});
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.returnDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DTDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextPage
            // 
            this.btnNextPage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNextPage.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPreviousPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPreviousPage.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Image = global::CarRental.Properties.Resources.AddNewVehicleReturn32;
            this.btnAddNewRecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.ImageSize = new System.Drawing.Size(23, 23);
            this.btnAddNewRecord.Location = new System.Drawing.Point(746, 61);
            this.btnAddNewRecord.Size = new System.Drawing.Size(175, 38);
            this.btnAddNewRecord.Text = "Add New Return";
            this.btnAddNewRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbFilter.Size = new System.Drawing.Size(177, 30);
            this.cbFilter.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BaseColor = System.Drawing.Color.White;
            this.dtpDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(310, 70);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(0);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDate.Radius = 12;
            this.dtpDate.Size = new System.Drawing.Size(137, 30);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.Text = "18/12/2025";
            this.dtpDate.Value = new System.DateTime(2025, 12, 18, 15, 50, 53, 22);
            this.dtpDate.Visible = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // returnDetailsToolStripMenuItem
            // 
            this.returnDetailsToolStripMenuItem.Image = global::CarRental.Properties.Resources.Details;
            this.returnDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnDetailsToolStripMenuItem.Name = "returnDetailsToolStripMenuItem";
            this.returnDetailsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.returnDetailsToolStripMenuItem.Text = "Return Details";
            this.returnDetailsToolStripMenuItem.Click += new System.EventHandler(this.returnDetailsToolStripMenuItem_Click);
            // 
            // addNewReturnToolStripMenuItem
            // 
            this.addNewReturnToolStripMenuItem.Image = global::CarRental.Properties.Resources.AddNewVehicle24;
            this.addNewReturnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewReturnToolStripMenuItem.Name = "addNewReturnToolStripMenuItem";
            this.addNewReturnToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.addNewReturnToolStripMenuItem.Text = "Add New Return";
            this.addNewReturnToolStripMenuItem.Click += new System.EventHandler(this.addNewReturnToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshToolStripMenuItem.Image = global::CarRental.Properties.Resources.Refresh24;
            this.RefreshToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // updateReturnToolStripMenuItem
            // 
            this.updateReturnToolStripMenuItem.Image = global::CarRental.Properties.Resources.UpdateVehicleReturn24;
            this.updateReturnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateReturnToolStripMenuItem.Name = "updateReturnToolStripMenuItem";
            this.updateReturnToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.updateReturnToolStripMenuItem.Text = "Update Return";
            this.updateReturnToolStripMenuItem.Click += new System.EventHandler(this.updateReturnToolStripMenuItem_Click);
            // 
            // frmReturnsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.dtpDate);
            this.Name = "frmReturnsList";
            this.Text = "Returns";
            this.Load += new System.EventHandler(this.frmReturnsList_Load);
            this.Controls.SetChildIndex(this.lblRecords, 0);
            this.Controls.SetChildIndex(this.lblFilter, 0);
            this.Controls.SetChildIndex(this.cbFilter, 0);
            this.Controls.SetChildIndex(this.btnAddNewRecord, 0);
            this.Controls.SetChildIndex(this.btnNextPage, 0);
            this.Controls.SetChildIndex(this.btnPreviousPage, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DTDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker dtpDate;
        private System.Windows.Forms.ToolStripMenuItem returnDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addNewReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateReturnToolStripMenuItem;
    }
}