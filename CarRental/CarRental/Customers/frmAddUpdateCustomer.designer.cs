namespace CarRental.Customers
{
    partial class frmAddUpdateCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Guna.UI.WinForms.GunaControlBox btnCloseBox;
        private Guna.UI.WinForms.GunaControlBox btnMinimizeBox;
        private System.Windows.Forms.Label lblFormTitle;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateCustomer));
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblShowPersonID = new System.Windows.Forms.Label();
            this.btnSelectPerson = new Guna.UI.WinForms.GunaButton();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowCustomerId = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtDriverLicenseNumber = new CustomContorls.CustomTextBox();
            this.txtName = new CustomContorls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBox.AnimationHoverSpeed = 0.07F;
            this.btnCloseBox.AnimationSpeed = 0.03F;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconSize = 15F;
            this.btnCloseBox.Location = new System.Drawing.Point(712, 0);
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCloseBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnCloseBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseBox.Size = new System.Drawing.Size(45, 29);
            this.btnCloseBox.TabIndex = 3;
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
            this.btnMinimizeBox.Location = new System.Drawing.Point(661, 0);
            this.btnMinimizeBox.Name = "btnMinimizeBox";
            this.btnMinimizeBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMinimizeBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizeBox.Size = new System.Drawing.Size(45, 29);
            this.btnMinimizeBox.TabIndex = 4;
            this.btnMinimizeBox.Click += new System.EventHandler(this.btnMinimizeBox_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(757, 47);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Add Update Customer";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.Location = new System.Drawing.Point(600, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(15, 209);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(163, 36);
            this.lblPersonID.TabIndex = 12;
            this.lblPersonID.Text = "Person Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pictureBox1.Location = new System.Drawing.Point(228, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblShowPersonID
            // 
            this.lblShowPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPersonID.ForeColor = System.Drawing.Color.White;
            this.lblShowPersonID.Location = new System.Drawing.Point(297, 211);
            this.lblShowPersonID.Name = "lblShowPersonID";
            this.lblShowPersonID.Size = new System.Drawing.Size(210, 37);
            this.lblShowPersonID.TabIndex = 14;
            this.lblShowPersonID.Text = "[?????]";
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.AnimationHoverSpeed = 0.07F;
            this.btnSelectPerson.AnimationSpeed = 0.03F;
            this.btnSelectPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectPerson.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnSelectPerson.BorderColor = System.Drawing.Color.Black;
            this.btnSelectPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectPerson.FocusedColor = System.Drawing.Color.Empty;
            this.btnSelectPerson.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.Image = null;
            this.btnSelectPerson.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectPerson.Location = new System.Drawing.Point(572, 272);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSelectPerson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSelectPerson.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.OnHoverImage = null;
            this.btnSelectPerson.OnPressedColor = System.Drawing.Color.Black;
            this.btnSelectPerson.Radius = 12;
            this.btnSelectPerson.Size = new System.Drawing.Size(172, 40);
            this.btnSelectPerson.TabIndex = 0;
            this.btnSelectPerson.Text = "Select Person";
            this.btnSelectPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(15, 276);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(163, 36);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRental.Properties.Resources.user__3_;
            this.pictureBox2.Location = new System.Drawing.Point(228, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.VehiclesBlue_100;
            this.pictureBox3.Location = new System.Drawing.Point(327, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Driver License Number";
            // 
            // lblShowCustomerId
            // 
            this.lblShowCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCustomerId.ForeColor = System.Drawing.Color.White;
            this.lblShowCustomerId.Location = new System.Drawing.Point(396, 76);
            this.lblShowCustomerId.Name = "lblShowCustomerId";
            this.lblShowCustomerId.Size = new System.Drawing.Size(210, 37);
            this.lblShowCustomerId.TabIndex = 21;
            this.lblShowCustomerId.Text = "[?????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pictureBox4.Location = new System.Drawing.Point(327, 74);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.White;
            this.lblCustomerID.Location = new System.Drawing.Point(15, 76);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(203, 36);
            this.lblCustomerID.TabIndex = 19;
            this.lblCustomerID.Text = "Customer Id";
            // 
            // txtDriverLicenseNumber
            // 
            this.txtDriverLicenseNumber.AllowEmpty = false;
            this.txtDriverLicenseNumber.Animated = true;
            this.txtDriverLicenseNumber.AutoRoundedCorners = true;
            this.txtDriverLicenseNumber.BorderRadius = 17;
            this.txtDriverLicenseNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverLicenseNumber.CustomValidationMessage = "Invalid License Number!";
            this.txtDriverLicenseNumber.DefaultText = "";
            this.txtDriverLicenseNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverLicenseNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverLicenseNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverLicenseNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverLicenseNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverLicenseNumber.ForeColor = System.Drawing.Color.Black;
            this.txtDriverLicenseNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverLicenseNumber.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtDriverLicenseNumber.Location = new System.Drawing.Point(392, 140);
            this.txtDriverLicenseNumber.Name = "txtDriverLicenseNumber";
            this.txtDriverLicenseNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDriverLicenseNumber.PlaceholderText = "Driver License Number";
            this.txtDriverLicenseNumber.SelectedText = "";
            this.txtDriverLicenseNumber.Size = new System.Drawing.Size(281, 36);
            this.txtDriverLicenseNumber.TabIndex = 0;
            this.txtDriverLicenseNumber.ValidateInputType = true;
            // 
            // txtName
            // 
            this.txtName.AllowEmpty = false;
            this.txtName.Animated = true;
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderRadius = 17;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.CustomValidationMessage = "No Selected Person";
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtName.Location = new System.Drawing.Point(303, 276);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Name";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 36);
            this.txtName.TabIndex = 25;
            this.txtName.ValidateInputType = false;
            // 
            // frmAddUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(757, 394);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDriverLicenseNumber);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShowCustomerId);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSelectPerson);
            this.Controls.Add(this.lblShowPersonID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Customer";
            this.Load += new System.EventHandler(this.frmAddUpdateCustomer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateCustomer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaButton btnSelectPerson;
        private System.Windows.Forms.Label lblShowPersonID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowCustomerId;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCustomerID;
        private CustomContorls.CustomTextBox txtDriverLicenseNumber;
        private CustomContorls.CustomTextBox txtName;


    }
}