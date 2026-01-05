namespace CarRental.Controls
{
    partial class ctrlMaintenanceCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lblFitler = new System.Windows.Forms.Label();
            this.btnAddNewMaintenance = new Guna.UI.WinForms.GunaButton();
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.ctrlMaintenanceCard1 = new CarRental.Controls.ctrlMaintenanceCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.lblFitler);
            this.gbFilter.Controls.Add(this.btnAddNewMaintenance);
            this.gbFilter.Controls.Add(this.txtSearchValue);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(544, 94);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // lblFitler
            // 
            this.lblFitler.AutoSize = true;
            this.lblFitler.Location = new System.Drawing.Point(6, 43);
            this.lblFitler.Name = "lblFitler";
            this.lblFitler.Size = new System.Drawing.Size(158, 30);
            this.lblFitler.TabIndex = 8;
            this.lblFitler.Text = "Maintenance Id";
            // 
            // btnAddNewMaintenance
            // 
            this.btnAddNewMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewMaintenance.AnimationHoverSpeed = 0.07F;
            this.btnAddNewMaintenance.AnimationSpeed = 0.03F;
            this.btnAddNewMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewMaintenance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(185)))));
            this.btnAddNewMaintenance.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewMaintenance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewMaintenance.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewMaintenance.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMaintenance.Image = null;
            this.btnAddNewMaintenance.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewMaintenance.Location = new System.Drawing.Point(365, 38);
            this.btnAddNewMaintenance.Name = "btnAddNewMaintenance";
            this.btnAddNewMaintenance.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.btnAddNewMaintenance.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewMaintenance.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewMaintenance.OnHoverImage = null;
            this.btnAddNewMaintenance.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewMaintenance.Radius = 10;
            this.btnAddNewMaintenance.Size = new System.Drawing.Size(173, 42);
            this.btnAddNewMaintenance.TabIndex = 7;
            this.btnAddNewMaintenance.Text = "Add New Maintenance";
            this.btnAddNewMaintenance.Click += new System.EventHandler(this.btnAddNewMaintenance_Click);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.AllowEmpty = true;
            this.txtSearchValue.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchValue.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchValue.BorderRadius = 12;
            this.txtSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.CustomValidationMessage = "Invalid Id";
            this.txtSearchValue.DefaultText = "";
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtSearchValue.Location = new System.Drawing.Point(163, 43);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearchValue.MaxLength = 50;
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.PlaceholderText = "";
            this.txtSearchValue.SelectedText = "";
            this.txtSearchValue.Size = new System.Drawing.Size(194, 36);
            this.txtSearchValue.TabIndex = 0;
            this.txtSearchValue.ValidateInputType = true;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            // 
            // ctrlMaintenanceCard1
            // 
            this.ctrlMaintenanceCard1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlMaintenanceCard1.Location = new System.Drawing.Point(-3, 101);
            this.ctrlMaintenanceCard1.Name = "ctrlMaintenanceCard1";
            this.ctrlMaintenanceCard1.Size = new System.Drawing.Size(795, 399);
            this.ctrlMaintenanceCard1.TabIndex = 2;
            // 
            // ctrlMaintenanceCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ctrlMaintenanceCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlMaintenanceCardWithFilter";
            this.Size = new System.Drawing.Size(781, 426);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI.WinForms.GunaButton btnAddNewMaintenance;
        private CustomContorls.CustomTextBox txtSearchValue;
        private ctrlMaintenanceCard ctrlMaintenanceCard1;
        private System.Windows.Forms.Label lblFitler;
    }
}
