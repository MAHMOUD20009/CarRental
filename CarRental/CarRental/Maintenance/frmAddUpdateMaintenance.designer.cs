namespace CarRental.Maintenance
{
    partial class frmAddUpdateMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Guna.UI.WinForms.GunaControlBox btnCloseBox;
        private Guna.UI.WinForms.GunaControlBox btnMinimizeBox;
        private System.Windows.Forms.Label lblFormTitle;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnSave;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateMaintenance));
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.tcMaintenanceInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpVehicleInfo = new System.Windows.Forms.TabPage();
            this.ctrlVehicleCardWithFilter1 = new CarRental.Controls.ctrlVehicleCardWithFilter();
            this.tpMaintenanceInfo = new System.Windows.Forms.TabPage();
            this.txtCost = new CustomContorls.CustomTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblShowMaintenanceDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMaintenanceDate = new System.Windows.Forms.Label();
            this.lblShowMaintenanceId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMaintenanceID = new System.Windows.Forms.Label();
            this.txtDescription = new CustomContorls.CustomTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tcMaintenanceInfo.SuspendLayout();
            this.tpVehicleInfo.SuspendLayout();
            this.tpMaintenanceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBox.AnimationHoverSpeed = 0.07F;
            this.btnCloseBox.AnimationSpeed = 0.03F;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconSize = 15F;
            this.btnCloseBox.Location = new System.Drawing.Point(795, 0);
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCloseBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnCloseBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseBox.Size = new System.Drawing.Size(45, 29);
            this.btnCloseBox.TabIndex = 10;
            this.btnCloseBox.Click += new System.EventHandler(this.btnCloseBox_Click);
            // 
            // btnMinimizeBox
            // 
            this.btnMinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeBox.AnimationHoverSpeed = 0.07F;
            this.btnMinimizeBox.AnimationSpeed = 0.03F;
            this.btnMinimizeBox.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimizeBox.IconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.IconSize = 15F;
            this.btnMinimizeBox.Location = new System.Drawing.Point(744, 0);
            this.btnMinimizeBox.Name = "btnMinimizeBox";
            this.btnMinimizeBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMinimizeBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizeBox.Size = new System.Drawing.Size(45, 29);
            this.btnMinimizeBox.TabIndex = 11;
            this.btnMinimizeBox.Click += new System.EventHandler(this.btnMinimizeBox_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(840, 47);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Add Update Maintenance";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateMaintenance_MouseDown);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(687, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcMaintenanceInfo
            // 
            this.tcMaintenanceInfo.Controls.Add(this.tpVehicleInfo);
            this.tcMaintenanceInfo.Controls.Add(this.tpMaintenanceInfo);
            this.tcMaintenanceInfo.ItemSize = new System.Drawing.Size(120, 40);
            this.tcMaintenanceInfo.Location = new System.Drawing.Point(12, 50);
            this.tcMaintenanceInfo.Name = "tcMaintenanceInfo";
            this.tcMaintenanceInfo.SelectedIndex = 0;
            this.tcMaintenanceInfo.Size = new System.Drawing.Size(816, 428);
            this.tcMaintenanceInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintenanceInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMaintenanceInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintenanceInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMaintenanceInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMaintenanceInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintenanceInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMaintenanceInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintenanceInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcMaintenanceInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMaintenanceInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintenanceInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcMaintenanceInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintenanceInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMaintenanceInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcMaintenanceInfo.TabButtonSize = new System.Drawing.Size(120, 40);
            this.tcMaintenanceInfo.TabIndex = 12;
            this.tcMaintenanceInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMaintenanceInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpVehicleInfo
            // 
            this.tpVehicleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tpVehicleInfo.Controls.Add(this.ctrlVehicleCardWithFilter1);
            this.tpVehicleInfo.Location = new System.Drawing.Point(4, 44);
            this.tpVehicleInfo.Name = "tpVehicleInfo";
            this.tpVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicleInfo.Size = new System.Drawing.Size(808, 380);
            this.tpVehicleInfo.TabIndex = 0;
            this.tpVehicleInfo.Text = "Vehicle Info";
            // 
            // ctrlVehicleCardWithFilter1
            // 
            this.ctrlVehicleCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlVehicleCardWithFilter1.FilterEnabled = true;
            this.ctrlVehicleCardWithFilter1.Location = new System.Drawing.Point(3, 0);
            this.ctrlVehicleCardWithFilter1.Name = "ctrlVehicleCardWithFilter1";
            this.ctrlVehicleCardWithFilter1.Size = new System.Drawing.Size(791, 381);
            this.ctrlVehicleCardWithFilter1.TabIndex = 0;
            this.ctrlVehicleCardWithFilter1.OnVehicleSelected += new System.Action<int>(this.ctrlVehicleCardWithFilter1_OnVehicleSelected);
            // 
            // tpMaintenanceInfo
            // 
            this.tpMaintenanceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tpMaintenanceInfo.Controls.Add(this.txtDescription);
            this.tpMaintenanceInfo.Controls.Add(this.pictureBox2);
            this.tpMaintenanceInfo.Controls.Add(this.lblDescription);
            this.tpMaintenanceInfo.Controls.Add(this.txtCost);
            this.tpMaintenanceInfo.Controls.Add(this.pictureBox4);
            this.tpMaintenanceInfo.Controls.Add(this.lblCost);
            this.tpMaintenanceInfo.Controls.Add(this.lblShowMaintenanceDate);
            this.tpMaintenanceInfo.Controls.Add(this.pictureBox3);
            this.tpMaintenanceInfo.Controls.Add(this.lblMaintenanceDate);
            this.tpMaintenanceInfo.Controls.Add(this.lblShowMaintenanceId);
            this.tpMaintenanceInfo.Controls.Add(this.pictureBox1);
            this.tpMaintenanceInfo.Controls.Add(this.lblMaintenanceID);
            this.tpMaintenanceInfo.Location = new System.Drawing.Point(4, 44);
            this.tpMaintenanceInfo.Name = "tpMaintenanceInfo";
            this.tpMaintenanceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaintenanceInfo.Size = new System.Drawing.Size(808, 380);
            this.tpMaintenanceInfo.TabIndex = 1;
            this.tpMaintenanceInfo.Text = "Maintenance Info";
            // 
            // txtCost
            // 
            this.txtCost.AllowEmpty = false;
            this.txtCost.BorderRadius = 12;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.CustomValidationMessage = null;
            this.txtCost.DefaultText = "";
            this.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.Black;
            this.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtCost.Location = new System.Drawing.Point(281, 129);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCost.PlaceholderText = "Cost";
            this.txtCost.SelectedText = "";
            this.txtCost.Size = new System.Drawing.Size(145, 36);
            this.txtCost.TabIndex = 11;
            this.txtCost.ValidateInputType = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox4.Location = new System.Drawing.Point(228, 129);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(6, 129);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(142, 39);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "Cost";
            // 
            // lblShowMaintenanceDate
            // 
            this.lblShowMaintenanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMaintenanceDate.ForeColor = System.Drawing.Color.White;
            this.lblShowMaintenanceDate.Location = new System.Drawing.Point(275, 76);
            this.lblShowMaintenanceDate.Name = "lblShowMaintenanceDate";
            this.lblShowMaintenanceDate.Size = new System.Drawing.Size(194, 34);
            this.lblShowMaintenanceDate.TabIndex = 8;
            this.lblShowMaintenanceDate.Text = "?????";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.Date;
            this.pictureBox3.Location = new System.Drawing.Point(228, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lblMaintenanceDate
            // 
            this.lblMaintenanceDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceDate.ForeColor = System.Drawing.Color.White;
            this.lblMaintenanceDate.Location = new System.Drawing.Point(6, 76);
            this.lblMaintenanceDate.Name = "lblMaintenanceDate";
            this.lblMaintenanceDate.Size = new System.Drawing.Size(216, 39);
            this.lblMaintenanceDate.TabIndex = 6;
            this.lblMaintenanceDate.Text = "Maintenance Date";
            // 
            // lblShowMaintenanceId
            // 
            this.lblShowMaintenanceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMaintenanceId.ForeColor = System.Drawing.Color.White;
            this.lblShowMaintenanceId.Location = new System.Drawing.Point(275, 21);
            this.lblShowMaintenanceId.Name = "lblShowMaintenanceId";
            this.lblShowMaintenanceId.Size = new System.Drawing.Size(167, 34);
            this.lblShowMaintenanceId.TabIndex = 2;
            this.lblShowMaintenanceId.Text = "[?????]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pictureBox1.Location = new System.Drawing.Point(228, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblMaintenanceID
            // 
            this.lblMaintenanceID.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceID.ForeColor = System.Drawing.Color.White;
            this.lblMaintenanceID.Location = new System.Drawing.Point(6, 18);
            this.lblMaintenanceID.Name = "lblMaintenanceID";
            this.lblMaintenanceID.Size = new System.Drawing.Size(216, 39);
            this.lblMaintenanceID.TabIndex = 0;
            this.lblMaintenanceID.Text = "Maintenance Id";
            // 
            // txtDescription
            // 
            this.txtDescription.AllowEmpty = false;
            this.txtDescription.BorderRadius = 12;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.CustomValidationMessage = null;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtDescription.Location = new System.Drawing.Point(281, 183);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(247, 36);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.ValidateInputType = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRental.Properties.Resources.sticky_note;
            this.pictureBox2.Location = new System.Drawing.Point(228, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(6, 183);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(142, 39);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // frmAddUpdateMaintenance
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(840, 525);
            this.Controls.Add(this.tcMaintenanceInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Maintenance";
            this.Load += new System.EventHandler(this.frmAddUpdateMaintenance_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateMaintenance_MouseDown);
            this.tcMaintenanceInfo.ResumeLayout(false);
            this.tpVehicleInfo.ResumeLayout(false);
            this.tpMaintenanceInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMaintenanceInfo;
        private System.Windows.Forms.TabPage tpVehicleInfo;
        private System.Windows.Forms.TabPage tpMaintenanceInfo;
        private Controls.ctrlVehicleCardWithFilter ctrlVehicleCardWithFilter1;
        private System.Windows.Forms.Label lblShowMaintenanceId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMaintenanceID;
        private System.Windows.Forms.Label lblShowMaintenanceDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private CustomContorls.CustomTextBox txtCost;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCost;
        private CustomContorls.CustomTextBox txtDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescription;
    }
}