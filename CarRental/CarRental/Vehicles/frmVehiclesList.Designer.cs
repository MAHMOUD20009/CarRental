namespace CarRental.Vehicles
{
    partial class frmVehiclesList
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
            dgvDataList.CellDoubleClick += dgvVehiclesList_CellDoubleClick;
        }

        private void InitializeFilerComboBox()
        {
            this.cbFilter.Items.AddRange(new object[] {
            "Vehicle ID",
            "Make",
            "Model",
            "Year",
            "Fuel Type",
            "Category Name",
            "Is Available"});
        }

        private void InitializeContextMenuStrip()
        {
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VehicleDetailsToolStripMenuItem,
            this.ToolStripSeparator1,
            this.RefreshToolStripMenuItem,
            this.ToolStripSeparator2,
            this.addNewVehicleToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterMakes = new Guna.UI.WinForms.GunaComboBox();
            this.cbFilterModels = new Guna.UI.WinForms.GunaComboBox();
            this.cbFilterCategoryName = new Guna.UI.WinForms.GunaComboBox();
            this.cbFilterFuelType = new Guna.UI.WinForms.GunaComboBox();
            this.nudYear = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbFilterAvailable = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
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
            this.btnAddNewRecord.Image = global::CarRental.Properties.Resources.AddNewVehicle32;
            this.btnAddNewRecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.ImageSize = new System.Drawing.Size(23, 23);
            this.btnAddNewRecord.Location = new System.Drawing.Point(745, 61);
            this.btnAddNewRecord.Size = new System.Drawing.Size(180, 38);
            this.btnAddNewRecord.Text = "Add New Vehicle";
            this.btnAddNewRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // VehicleDetailsToolStripMenuItem
            // 
            this.VehicleDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleDetailsToolStripMenuItem.Image = global::CarRental.Properties.Resources.VehicleDtails24;
            this.VehicleDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VehicleDetailsToolStripMenuItem.Name = "VehicleDetailsToolStripMenuItem";
            this.VehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.VehicleDetailsToolStripMenuItem.Text = "Vehicle Details";
            this.VehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.VehicleDetailsToolStripMenuItem_Click);
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
            // addNewVehicleToolStripMenuItem
            // 
            this.addNewVehicleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewVehicleToolStripMenuItem.Image = global::CarRental.Properties.Resources.AddNewVehicle24;
            this.addNewVehicleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
            this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.addNewVehicleToolStripMenuItem.Text = "Add New Vehicle";
            this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.addNewVehicleToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripMenuItem.Image = global::CarRental.Properties.Resources.UpdateVehicle;
            this.updateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::CarRental.Properties.Resources.DeleteVehicle;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cbFilterMakes
            // 
            this.cbFilterMakes.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterMakes.BaseColor = System.Drawing.Color.White;
            this.cbFilterMakes.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterMakes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterMakes.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterMakes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterMakes.ForeColor = System.Drawing.Color.Black;
            this.cbFilterMakes.FormattingEnabled = true;
            this.cbFilterMakes.Items.AddRange(new object[] {
            "Makes"});
            this.cbFilterMakes.Location = new System.Drawing.Point(302, 69);
            this.cbFilterMakes.Name = "cbFilterMakes";
            this.cbFilterMakes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterMakes.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterMakes.Radius = 12;
            this.cbFilterMakes.Size = new System.Drawing.Size(166, 30);
            this.cbFilterMakes.StartIndex = 0;
            this.cbFilterMakes.TabIndex = 2;
            this.cbFilterMakes.Tag = "Make";
            this.cbFilterMakes.Visible = false;
            this.cbFilterMakes.SelectedIndexChanged += new System.EventHandler(this.cbsFilter_SelectedIndexChanged);
            // 
            // cbFilterModels
            // 
            this.cbFilterModels.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterModels.BaseColor = System.Drawing.Color.White;
            this.cbFilterModels.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterModels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterModels.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterModels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterModels.ForeColor = System.Drawing.Color.Black;
            this.cbFilterModels.FormattingEnabled = true;
            this.cbFilterModels.Items.AddRange(new object[] {
            "Models"});
            this.cbFilterModels.Location = new System.Drawing.Point(302, 70);
            this.cbFilterModels.Name = "cbFilterModels";
            this.cbFilterModels.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterModels.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterModels.Radius = 12;
            this.cbFilterModels.Size = new System.Drawing.Size(166, 30);
            this.cbFilterModels.StartIndex = 0;
            this.cbFilterModels.TabIndex = 5;
            this.cbFilterModels.Tag = "Model";
            this.cbFilterModels.Visible = false;
            this.cbFilterModels.SelectedIndexChanged += new System.EventHandler(this.cbsFilter_SelectedIndexChanged);
            // 
            // cbFilterCategoryName
            // 
            this.cbFilterCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterCategoryName.BaseColor = System.Drawing.Color.White;
            this.cbFilterCategoryName.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterCategoryName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCategoryName.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterCategoryName.ForeColor = System.Drawing.Color.Black;
            this.cbFilterCategoryName.FormattingEnabled = true;
            this.cbFilterCategoryName.Items.AddRange(new object[] {
            "CategoryName"});
            this.cbFilterCategoryName.Location = new System.Drawing.Point(302, 70);
            this.cbFilterCategoryName.Name = "cbFilterCategoryName";
            this.cbFilterCategoryName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterCategoryName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterCategoryName.Radius = 12;
            this.cbFilterCategoryName.Size = new System.Drawing.Size(166, 30);
            this.cbFilterCategoryName.StartIndex = 0;
            this.cbFilterCategoryName.TabIndex = 6;
            this.cbFilterCategoryName.Tag = "CategoryName";
            this.cbFilterCategoryName.Visible = false;
            this.cbFilterCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbsFilter_SelectedIndexChanged);
            // 
            // cbFilterFuelType
            // 
            this.cbFilterFuelType.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterFuelType.BaseColor = System.Drawing.Color.White;
            this.cbFilterFuelType.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterFuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterFuelType.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterFuelType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterFuelType.ForeColor = System.Drawing.Color.Black;
            this.cbFilterFuelType.FormattingEnabled = true;
            this.cbFilterFuelType.Items.AddRange(new object[] {
            "FuelType"});
            this.cbFilterFuelType.Location = new System.Drawing.Point(302, 70);
            this.cbFilterFuelType.Name = "cbFilterFuelType";
            this.cbFilterFuelType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterFuelType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterFuelType.Radius = 12;
            this.cbFilterFuelType.Size = new System.Drawing.Size(166, 30);
            this.cbFilterFuelType.StartIndex = 0;
            this.cbFilterFuelType.TabIndex = 7;
            this.cbFilterFuelType.Tag = "FuelType";
            this.cbFilterFuelType.Visible = false;
            this.cbFilterFuelType.SelectedIndexChanged += new System.EventHandler(this.cbsFilter_SelectedIndexChanged);
            // 
            // nudYear
            // 
            this.nudYear.BackColor = System.Drawing.Color.Transparent;
            this.nudYear.BorderRadius = 10;
            this.nudYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(302, 71);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(126, 29);
            this.nudYear.TabIndex = 5;
            this.nudYear.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nudYear.Visible = false;
            this.nudYear.ValueChanged += new System.EventHandler(this.nudYear_ValueChanged);
            // 
            // cbFilterAvailable
            // 
            this.cbFilterAvailable.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterAvailable.BaseColor = System.Drawing.Color.White;
            this.cbFilterAvailable.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterAvailable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterAvailable.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterAvailable.ForeColor = System.Drawing.Color.Black;
            this.cbFilterAvailable.FormattingEnabled = true;
            this.cbFilterAvailable.Items.AddRange(new object[] {
            "All",
            "Available",
            "Not Available"});
            this.cbFilterAvailable.Location = new System.Drawing.Point(302, 70);
            this.cbFilterAvailable.Name = "cbFilterAvailable";
            this.cbFilterAvailable.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterAvailable.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterAvailable.Radius = 12;
            this.cbFilterAvailable.Size = new System.Drawing.Size(166, 30);
            this.cbFilterAvailable.StartIndex = 0;
            this.cbFilterAvailable.TabIndex = 8;
            this.cbFilterAvailable.Tag = "FuelType";
            this.cbFilterAvailable.Visible = false;
            this.cbFilterAvailable.SelectedIndexChanged += new System.EventHandler(this.cbFilterAvailable_SelectedIndexChanged);
            // 
            // frmVehiclesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.cbFilterAvailable);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.cbFilterFuelType);
            this.Controls.Add(this.cbFilterCategoryName);
            this.Controls.Add(this.cbFilterModels);
            this.Controls.Add(this.cbFilterMakes);
            this.Name = "frmVehiclesList";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.frmVehiclesList_Load);
            this.Controls.SetChildIndex(this.cbFilterMakes, 0);
            this.Controls.SetChildIndex(this.cbFilterModels, 0);
            this.Controls.SetChildIndex(this.cbFilterCategoryName, 0);
            this.Controls.SetChildIndex(this.cbFilterFuelType, 0);
            this.Controls.SetChildIndex(this.nudYear, 0);
            this.Controls.SetChildIndex(this.cbFilterAvailable, 0);
            this.Controls.SetChildIndex(this.lblRecords, 0);
            this.Controls.SetChildIndex(this.lblFilter, 0);
            this.Controls.SetChildIndex(this.cbFilter, 0);
            this.Controls.SetChildIndex(this.btnAddNewRecord, 0);
            this.Controls.SetChildIndex(this.btnNextPage, 0);
            this.Controls.SetChildIndex(this.btnPreviousPage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DTDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbFilterMakes;
        private System.Windows.Forms.ToolStripMenuItem VehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI.WinForms.GunaComboBox cbFilterModels;
        private Guna.UI.WinForms.GunaComboBox cbFilterCategoryName;
        private Guna.UI.WinForms.GunaComboBox cbFilterFuelType;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudYear;
        private Guna.UI.WinForms.GunaComboBox cbFilterAvailable;
    }
}