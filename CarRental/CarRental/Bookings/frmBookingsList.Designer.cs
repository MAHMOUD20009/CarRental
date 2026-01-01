namespace CarRental.Bookings
{
    partial class frmBookingsList
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
            dgvDataList.CellDoubleClick += dgvBookingsList_CellDoubleClick;
        }

        private void InitializeFilerComboBox()
        {
            this.cbFilter.Items.AddRange(new object[] {
            "Booking ID",
            "Customer ID",
            "Customer Name",
            "Vehicle ID",
            "Date",
            "Pickup Location",
            "Dropoff Location"});
        }

        private void InitializeContextMenuStrip()
        {
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookingDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.RefresfToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNewBookingToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.customerDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.vehicleDetailsToolStripMenuItem,
            this.toolStripSeparator3,
            this.returnDetailsToolStripMenuItem});
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefresfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.returnDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDate = new Guna.UI.WinForms.GunaDateTimePicker();
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
            this.btnAddNewRecord.Image = global::CarRental.Properties.Resources.AddNewBooking32;
            this.btnAddNewRecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.ImageSize = new System.Drawing.Size(23, 23);
            this.btnAddNewRecord.Location = new System.Drawing.Point(737, 61);
            this.btnAddNewRecord.Size = new System.Drawing.Size(188, 38);
            this.btnAddNewRecord.Text = "Add New Booking";
            this.btnAddNewRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewBooking_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // BookingDetailsToolStripMenuItem
            // 
            this.BookingDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDetailsToolStripMenuItem.Image = Properties.Resources.BookingDetails;
            this.BookingDetailsToolStripMenuItem.Name = "BookingDetailsToolStripMenuItem";
            this.BookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.BookingDetailsToolStripMenuItem.Text = "Booking Details";
            this.BookingDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BookingDetailsToolStripMenuItem.Click += new System.EventHandler(this.BookingDetailsToolStripMenuItem_Click);
            // 
            // addNewBookingToolStripMenuItem
            // 
            this.addNewBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBookingToolStripMenuItem.Image = Properties.Resources.AddNewBooking24;
            this.addNewBookingToolStripMenuItem.Name = "addNewBookingToolStripMenuItem";
            this.addNewBookingToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.addNewBookingToolStripMenuItem.Text = "Add New Booking";
            this.addNewBookingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookingToolStripMenuItem.Click += new System.EventHandler(this.addNewBookingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // RefresfToolStripMenuItem
            // 
            this.RefresfToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefresfToolStripMenuItem.Image = Properties.Resources.Refresh24;
            this.RefresfToolStripMenuItem.Name = "RefresfToolStripMenuItem";
            this.RefresfToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.RefresfToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefresfToolStripMenuItem.Text = "Refresh";
            this.RefresfToolStripMenuItem.Click += new System.EventHandler(RefreshToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripMenuItem.Image = Properties.Resources.UpdateBooking;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = Properties.Resources.DeleteBooking24;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Image = Properties.Resources.CustomeDetails24;
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click);
            // 
            // vehicleDetailsToolStripMenuItem
            // 
            this.vehicleDetailsToolStripMenuItem.Name = "vehicleDetailsToolStripMenuItem";
            this.vehicleDetailsToolStripMenuItem.Image = Properties.Resources.VehicleDtails24;
            this.vehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.vehicleDetailsToolStripMenuItem.Text = "Vehicle Details";
            this.vehicleDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.vehicleDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // returnDetailsToolStripMenuItem
            // 
            this.returnDetailsToolStripMenuItem.Name = "returnDetailsToolStripMenuItem";
            this.returnDetailsToolStripMenuItem.Image = Properties.Resources.AddNewVehicleReturn24;
            this.returnDetailsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.returnDetailsToolStripMenuItem.Text = "Return Details";
            this.returnDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
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
            this.dtpDate.Location = new System.Drawing.Point(302, 69);
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
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Text = "18/12/2025";
            this.dtpDate.Value = new System.DateTime(2025, 12, 18, 15, 50, 53, 22);
            this.dtpDate.Visible = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // frmBookingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.dtpDate);
            this.Name = "frmBookingsList";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.frmBookingsList_Load);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.lblRecords, 0);
            this.Controls.SetChildIndex(this.lblFilter, 0);
            this.Controls.SetChildIndex(this.cbFilter, 0);
            this.Controls.SetChildIndex(this.btnAddNewRecord, 0);
            this.Controls.SetChildIndex(this.btnNextPage, 0);
            this.Controls.SetChildIndex(this.btnPreviousPage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DTDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem BookingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefresfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem vehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem returnDetailsToolStripMenuItem;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDate;
    }
}