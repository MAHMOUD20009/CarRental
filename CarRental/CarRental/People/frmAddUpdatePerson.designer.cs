namespace CarRental.People
{
    partial class frmAddUpdatePerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Guna.UI.WinForms.GunaControlBox btnCloseBox;
        private Guna.UI.WinForms.GunaControlBox btnMinimizeBox;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI.WinForms.GunaRadioButton rbMale;
        private Guna.UI.WinForms.GunaRadioButton rbFemale;
        private System.Windows.Forms.Label lblDateOfBirth;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new Guna.UI.WinForms.GunaRadioButton();
            this.rbFemale = new Guna.UI.WinForms.GunaRadioButton();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblShowPersonID = new System.Windows.Forms.Label();
            this.pbPersonID = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.pbGender = new System.Windows.Forms.PictureBox();
            this.pbDateOfBirth = new System.Windows.Forms.PictureBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.txtName = new CustomContorls.CustomTextBox();
            this.txtPhone = new CustomContorls.CustomTextBox();
            this.txtEmail = new CustomContorls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBox.AnimationHoverSpeed = 0.07F;
            this.btnCloseBox.AnimationSpeed = 0.03F;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconSize = 15F;
            this.btnCloseBox.Location = new System.Drawing.Point(745, 0);
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
            this.btnMinimizeBox.Location = new System.Drawing.Point(694, 0);
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
            this.lblFormTitle.Size = new System.Drawing.Size(790, 47);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Add Update Person";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 39);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(12, 186);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(113, 39);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.BaseColor = System.Drawing.SystemColors.Control;
            this.rbMale.Checked = true;
            this.rbMale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbMale.CheckedOnColor = System.Drawing.Color.MediumAquamarine;
            this.rbMale.FillColor = System.Drawing.Color.White;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(242, 200);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(67, 25);
            this.rbMale.TabIndex = 3;
            this.rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            this.rbFemale.BaseColor = System.Drawing.SystemColors.Control;
            this.rbFemale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbFemale.CheckedOnColor = System.Drawing.Color.MediumAquamarine;
            this.rbFemale.FillColor = System.Drawing.Color.White;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(315, 200);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(83, 25);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.Text = "Female";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 246);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(170, 39);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.BaseColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateOfBirth.CustomFormat = "dd, MMMM, yyyy";
            this.dtpDateOfBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfBirth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(242, 251);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(0);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateOfBirth.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateOfBirth.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(223, 30);
            this.dtpDateOfBirth.TabIndex = 5;
            this.dtpDateOfBirth.Text = "11, September, 2025";
            this.dtpDateOfBirth.Value = new System.DateTime(2025, 9, 11, 15, 10, 56, 344);
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(12, 306);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(113, 39);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(12, 366);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(113, 39);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
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
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(633, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(1, 70);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(157, 39);
            this.lblPersonID.TabIndex = 18;
            this.lblPersonID.Text = "PersonID";
            // 
            // lblShowPersonID
            // 
            this.lblShowPersonID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPersonID.ForeColor = System.Drawing.Color.White;
            this.lblShowPersonID.Location = new System.Drawing.Point(248, 70);
            this.lblShowPersonID.Name = "lblShowPersonID";
            this.lblShowPersonID.Size = new System.Drawing.Size(194, 39);
            this.lblShowPersonID.TabIndex = 0;
            this.lblShowPersonID.Text = "[?????]";
            // 
            // pbPersonID
            // 
            this.pbPersonID.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonID.Image")));
            this.pbPersonID.Location = new System.Drawing.Point(195, 75);
            this.pbPersonID.Name = "pbPersonID";
            this.pbPersonID.Size = new System.Drawing.Size(33, 34);
            this.pbPersonID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonID.TabIndex = 20;
            this.pbPersonID.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.Image = ((System.Drawing.Image)(resources.GetObject("pbName.Image")));
            this.pbName.Location = new System.Drawing.Point(194, 133);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(33, 34);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbName.TabIndex = 21;
            this.pbName.TabStop = false;
            // 
            // pbGender
            // 
            this.pbGender.Image = ((System.Drawing.Image)(resources.GetObject("pbGender.Image")));
            this.pbGender.Location = new System.Drawing.Point(195, 191);
            this.pbGender.Name = "pbGender";
            this.pbGender.Size = new System.Drawing.Size(33, 34);
            this.pbGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGender.TabIndex = 22;
            this.pbGender.TabStop = false;
            // 
            // pbDateOfBirth
            // 
            this.pbDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("pbDateOfBirth.Image")));
            this.pbDateOfBirth.Location = new System.Drawing.Point(195, 247);
            this.pbDateOfBirth.Name = "pbDateOfBirth";
            this.pbDateOfBirth.Size = new System.Drawing.Size(33, 34);
            this.pbDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDateOfBirth.TabIndex = 23;
            this.pbDateOfBirth.TabStop = false;
            // 
            // pbPhone
            // 
            this.pbPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbPhone.Image")));
            this.pbPhone.Location = new System.Drawing.Point(195, 306);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(33, 34);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhone.TabIndex = 24;
            this.pbPhone.TabStop = false;
            // 
            // pbEmail
            // 
            this.pbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbEmail.Image")));
            this.pbEmail.Location = new System.Drawing.Point(195, 371);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(33, 34);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmail.TabIndex = 25;
            this.pbEmail.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.AllowEmpty = false;
            this.txtName.BorderRadius = 12;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.CustomValidationMessage = null;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.InputType = CustomContorls.CustomTextBox.enInputType.TextInput;
            this.txtName.Location = new System.Drawing.Point(242, 133);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(200, 34);
            this.txtName.TabIndex = 26;
            this.txtName.ValidateInputType = true;
            // 
            // txtPhone
            // 
            this.txtPhone.AllowEmpty = false;
            this.txtPhone.BorderRadius = 12;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.CustomValidationMessage = "Invalid Number!";
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtPhone.Location = new System.Drawing.Point(242, 306);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(200, 34);
            this.txtPhone.TabIndex = 27;
            this.txtPhone.ValidateInputType = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowEmpty = false;
            this.txtEmail.BorderRadius = 12;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.CustomValidationMessage = null;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.InputType = CustomContorls.CustomTextBox.enInputType.FormatEmail;
            this.txtEmail.Location = new System.Drawing.Point(242, 366);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(200, 34);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.ValidateInputType = true;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.pbPhone);
            this.Controls.Add(this.pbDateOfBirth);
            this.Controls.Add(this.pbGender);
            this.Controls.Add(this.pbName);
            this.Controls.Add(this.pbPersonID);
            this.Controls.Add(this.lblShowPersonID);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Person";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdatePerson_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Label lblShowPersonID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pbDateOfBirth;
        private System.Windows.Forms.PictureBox pbGender;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.PictureBox pbPersonID;
        private CustomContorls.CustomTextBox txtName;
        private CustomContorls.CustomTextBox txtEmail;
        private CustomContorls.CustomTextBox txtPhone;


    }
}