namespace CarRental.Vehicles
{
    partial class frmAddUpdateVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Guna.UI.WinForms.GunaControlBox btnCloseBox;
        private Guna.UI.WinForms.GunaControlBox btnMinimizeBox;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMileage;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateVehicle));
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblShowVehicleID = new System.Windows.Forms.Label();
            this.cbMake = new Guna.UI.WinForms.GunaComboBox();
            this.cbModel = new Guna.UI.WinForms.GunaComboBox();
            this.nudYear = new Guna.UI.WinForms.GunaNumeric();
            this.nudMileage = new Guna.UI.WinForms.GunaNumeric();
            this.cbFuelType = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlateNumber = new CustomContorls.CustomTextBox();
            this.cbCarCategory = new Guna.UI.WinForms.GunaComboBox();
            this.lblCarCategory = new System.Windows.Forms.Label();
            this.txtRentalPricePerDay = new CustomContorls.CustomTextBox();
            this.lblRentalPricePerDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsAvailable = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFuelType = new System.Windows.Forms.PictureBox();
            this.pbMileage = new System.Windows.Forms.PictureBox();
            this.pbYear = new System.Windows.Forms.PictureBox();
            this.pbModel = new System.Windows.Forms.PictureBox();
            this.pbMake = new System.Windows.Forms.PictureBox();
            this.pbVehicleID = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuelType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicleID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBox.AnimationHoverSpeed = 0.07F;
            this.btnCloseBox.AnimationSpeed = 0.03F;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconSize = 15F;
            this.btnCloseBox.Location = new System.Drawing.Point(912, 0);
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
            this.btnMinimizeBox.Location = new System.Drawing.Point(861, 0);
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
            this.lblFormTitle.Size = new System.Drawing.Size(957, 47);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Add Update Vehicle";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateVehicle_MouseDown);
            // 
            // lblMake
            // 
            this.lblMake.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.Color.White;
            this.lblMake.Location = new System.Drawing.Point(8, 133);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(92, 39);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(452, 134);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(113, 39);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(8, 196);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(92, 39);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year";
            // 
            // lblMileage
            // 
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.ForeColor = System.Drawing.Color.White;
            this.lblMileage.Location = new System.Drawing.Point(452, 195);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(113, 39);
            this.lblMileage.TabIndex = 11;
            this.lblMileage.Text = "Mileage";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(8, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(146, 39);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Fuel Type";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.Color.White;
            this.lblVehicleID.Location = new System.Drawing.Point(1, 70);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(157, 39);
            this.lblVehicleID.TabIndex = 18;
            this.lblVehicleID.Text = "VehicleID";
            // 
            // lblShowVehicleID
            // 
            this.lblShowVehicleID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowVehicleID.ForeColor = System.Drawing.Color.White;
            this.lblShowVehicleID.Location = new System.Drawing.Point(248, 70);
            this.lblShowVehicleID.Name = "lblShowVehicleID";
            this.lblShowVehicleID.Size = new System.Drawing.Size(132, 39);
            this.lblShowVehicleID.TabIndex = 0;
            this.lblShowVehicleID.Text = "[?????]";
            // 
            // cbMake
            // 
            this.cbMake.BackColor = System.Drawing.Color.Transparent;
            this.cbMake.BaseColor = System.Drawing.Color.White;
            this.cbMake.BorderColor = System.Drawing.Color.Silver;
            this.cbMake.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMake.FocusedColor = System.Drawing.Color.Empty;
            this.cbMake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMake.ForeColor = System.Drawing.Color.Black;
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(244, 138);
            this.cbMake.Name = "cbMake";
            this.cbMake.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMake.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMake.Radius = 10;
            this.cbMake.Size = new System.Drawing.Size(171, 30);
            this.cbMake.TabIndex = 0;
            // 
            // cbModel
            // 
            this.cbModel.BackColor = System.Drawing.Color.Transparent;
            this.cbModel.BaseColor = System.Drawing.Color.White;
            this.cbModel.BorderColor = System.Drawing.Color.Silver;
            this.cbModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FocusedColor = System.Drawing.Color.Empty;
            this.cbModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.ForeColor = System.Drawing.Color.Black;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(691, 141);
            this.cbModel.Name = "cbModel";
            this.cbModel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbModel.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbModel.Radius = 10;
            this.cbModel.Size = new System.Drawing.Size(171, 30);
            this.cbModel.TabIndex = 1;
            // 
            // nudYear
            // 
            this.nudYear.BackColor = System.Drawing.Color.Transparent;
            this.nudYear.BaseColor = System.Drawing.Color.White;
            this.nudYear.BorderColor = System.Drawing.Color.Silver;
            this.nudYear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nudYear.ButtonForeColor = System.Drawing.Color.White;
            this.nudYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.ForeColor = System.Drawing.Color.Black;
            this.nudYear.Location = new System.Drawing.Point(244, 201);
            this.nudYear.Maximum = ((long)(3000));
            this.nudYear.Minimum = ((long)(2000));
            this.nudYear.Name = "nudYear";
            this.nudYear.Radius = 10;
            this.nudYear.Size = new System.Drawing.Size(171, 30);
            this.nudYear.TabIndex = 2;
            this.nudYear.Text = "Year";
            this.nudYear.Value = ((long)(2000));
            // 
            // nudMileage
            // 
            this.nudMileage.BackColor = System.Drawing.Color.Transparent;
            this.nudMileage.BaseColor = System.Drawing.Color.White;
            this.nudMileage.BorderColor = System.Drawing.Color.Silver;
            this.nudMileage.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nudMileage.ButtonForeColor = System.Drawing.Color.White;
            this.nudMileage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMileage.ForeColor = System.Drawing.Color.Black;
            this.nudMileage.Location = new System.Drawing.Point(691, 201);
            this.nudMileage.Maximum = ((long)(1000000));
            this.nudMileage.Minimum = ((long)(0));
            this.nudMileage.Name = "nudMileage";
            this.nudMileage.Radius = 10;
            this.nudMileage.Size = new System.Drawing.Size(171, 30);
            this.nudMileage.TabIndex = 3;
            this.nudMileage.Text = "Mileage";
            this.nudMileage.Value = ((long)(0));
            // 
            // cbFuelType
            // 
            this.cbFuelType.BackColor = System.Drawing.Color.Transparent;
            this.cbFuelType.BaseColor = System.Drawing.Color.White;
            this.cbFuelType.BorderColor = System.Drawing.Color.Silver;
            this.cbFuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FocusedColor = System.Drawing.Color.Empty;
            this.cbFuelType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuelType.ForeColor = System.Drawing.Color.Black;
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(244, 260);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFuelType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFuelType.Radius = 10;
            this.cbFuelType.Size = new System.Drawing.Size(171, 30);
            this.cbFuelType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Plate Number";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.AllowEmpty = false;
            this.txtPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlateNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPlateNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtPlateNumber.BorderRadius = 10;
            this.txtPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumber.CustomValidationMessage = "Invalid Plate Number";
            this.txtPlateNumber.DefaultText = "";
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPlateNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPlateNumber.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtPlateNumber.Location = new System.Drawing.Point(691, 262);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPlateNumber.PlaceholderText = "";
            this.txtPlateNumber.SelectedText = "";
            this.txtPlateNumber.Size = new System.Drawing.Size(171, 34);
            this.txtPlateNumber.TabIndex = 5;
            this.txtPlateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlateNumber.ValidateInputType = true;
            // 
            // cbCarCategory
            // 
            this.cbCarCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCarCategory.BaseColor = System.Drawing.Color.White;
            this.cbCarCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbCarCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCarCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCarCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCarCategory.FormattingEnabled = true;
            this.cbCarCategory.Location = new System.Drawing.Point(244, 321);
            this.cbCarCategory.Name = "cbCarCategory";
            this.cbCarCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbCarCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCarCategory.Radius = 10;
            this.cbCarCategory.Size = new System.Drawing.Size(171, 30);
            this.cbCarCategory.TabIndex = 6;
            // 
            // lblCarCategory
            // 
            this.lblCarCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCategory.ForeColor = System.Drawing.Color.White;
            this.lblCarCategory.Location = new System.Drawing.Point(8, 316);
            this.lblCarCategory.Name = "lblCarCategory";
            this.lblCarCategory.Size = new System.Drawing.Size(180, 39);
            this.lblCarCategory.TabIndex = 30;
            this.lblCarCategory.Text = "Car Category";
            // 
            // txtRentalPricePerDay
            // 
            this.txtRentalPricePerDay.AllowEmpty = false;
            this.txtRentalPricePerDay.BackColor = System.Drawing.Color.Transparent;
            this.txtRentalPricePerDay.BorderColor = System.Drawing.Color.Silver;
            this.txtRentalPricePerDay.BorderRadius = 10;
            this.txtRentalPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerDay.CustomValidationMessage = "Invalid Number";
            this.txtRentalPricePerDay.DefaultText = "";
            this.txtRentalPricePerDay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRentalPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerDay.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtRentalPricePerDay.Location = new System.Drawing.Point(248, 381);
            this.txtRentalPricePerDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRentalPricePerDay.Name = "txtRentalPricePerDay";
            this.txtRentalPricePerDay.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRentalPricePerDay.PlaceholderText = "";
            this.txtRentalPricePerDay.SelectedText = "";
            this.txtRentalPricePerDay.Size = new System.Drawing.Size(171, 34);
            this.txtRentalPricePerDay.TabIndex = 8;
            this.txtRentalPricePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRentalPricePerDay.ValidateInputType = true;
            // 
            // lblRentalPricePerDay
            // 
            this.lblRentalPricePerDay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPricePerDay.ForeColor = System.Drawing.Color.White;
            this.lblRentalPricePerDay.Location = new System.Drawing.Point(5, 381);
            this.lblRentalPricePerDay.Name = "lblRentalPricePerDay";
            this.lblRentalPricePerDay.Size = new System.Drawing.Size(202, 39);
            this.lblRentalPricePerDay.TabIndex = 32;
            this.lblRentalPricePerDay.Text = "Ren Price Per Day";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 311);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(184, 39);
            this.label2.TabIndex = 35;
            this.label2.Text = "Is Available";
            // 
            // chkIsAvailable
            // 
            this.chkIsAvailable.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.chkIsAvailable.CheckedState.ImageSize = new System.Drawing.Size(28, 28);
            this.chkIsAvailable.Image = ((System.Drawing.Image)(resources.GetObject("chkIsAvailable.Image")));
            this.chkIsAvailable.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkIsAvailable.ImageRotate = 0F;
            this.chkIsAvailable.ImageSize = new System.Drawing.Size(28, 28);
            this.chkIsAvailable.Location = new System.Drawing.Point(705, 320);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Size = new System.Drawing.Size(43, 30);
            this.chkIsAvailable.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(652, 316);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(205, 381);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRental.Properties.Resources.car_name321;
            this.pictureBox2.Location = new System.Drawing.Point(205, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.car_name321;
            this.pictureBox1.Location = new System.Drawing.Point(652, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pbFuelType
            // 
            this.pbFuelType.Image = ((System.Drawing.Image)(resources.GetObject("pbFuelType.Image")));
            this.pbFuelType.Location = new System.Drawing.Point(205, 256);
            this.pbFuelType.Name = "pbFuelType";
            this.pbFuelType.Size = new System.Drawing.Size(33, 34);
            this.pbFuelType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuelType.TabIndex = 25;
            this.pbFuelType.TabStop = false;
            // 
            // pbMileage
            // 
            this.pbMileage.Image = global::CarRental.Properties.Resources.mileage;
            this.pbMileage.Location = new System.Drawing.Point(652, 200);
            this.pbMileage.Name = "pbMileage";
            this.pbMileage.Size = new System.Drawing.Size(33, 34);
            this.pbMileage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMileage.TabIndex = 24;
            this.pbMileage.TabStop = false;
            // 
            // pbYear
            // 
            this.pbYear.Image = ((System.Drawing.Image)(resources.GetObject("pbYear.Image")));
            this.pbYear.Location = new System.Drawing.Point(205, 197);
            this.pbYear.Name = "pbYear";
            this.pbYear.Size = new System.Drawing.Size(33, 34);
            this.pbYear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYear.TabIndex = 23;
            this.pbYear.TabStop = false;
            // 
            // pbModel
            // 
            this.pbModel.Image = global::CarRental.Properties.Resources.model;
            this.pbModel.Location = new System.Drawing.Point(652, 138);
            this.pbModel.Name = "pbModel";
            this.pbModel.Size = new System.Drawing.Size(33, 34);
            this.pbModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModel.TabIndex = 22;
            this.pbModel.TabStop = false;
            // 
            // pbMake
            // 
            this.pbMake.Image = global::CarRental.Properties.Resources.car_name321;
            this.pbMake.Location = new System.Drawing.Point(205, 134);
            this.pbMake.Name = "pbMake";
            this.pbMake.Size = new System.Drawing.Size(33, 34);
            this.pbMake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMake.TabIndex = 21;
            this.pbMake.TabStop = false;
            // 
            // pbVehicleID
            // 
            this.pbVehicleID.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pbVehicleID.Location = new System.Drawing.Point(195, 75);
            this.pbVehicleID.Name = "pbVehicleID";
            this.pbVehicleID.Size = new System.Drawing.Size(33, 34);
            this.pbVehicleID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVehicleID.TabIndex = 20;
            this.pbVehicleID.TabStop = false;
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
            this.btnSave.Location = new System.Drawing.Point(800, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(957, 452);
            this.Controls.Add(this.chkIsAvailable);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRentalPricePerDay);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblRentalPricePerDay);
            this.Controls.Add(this.cbCarCategory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCarCategory);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.nudMileage);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.pbFuelType);
            this.Controls.Add(this.pbMileage);
            this.Controls.Add(this.pbYear);
            this.Controls.Add(this.pbModel);
            this.Controls.Add(this.pbMake);
            this.Controls.Add(this.pbVehicleID);
            this.Controls.Add(this.lblShowVehicleID);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Vehicle";
            this.Load += new System.EventHandler(this.frmAddUpdateVehicle_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateVehicle_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuelType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Label lblShowVehicleID;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.PictureBox pbFuelType;
        private System.Windows.Forms.PictureBox pbMileage;
        private System.Windows.Forms.PictureBox pbYear;
        private System.Windows.Forms.PictureBox pbModel;
        private System.Windows.Forms.PictureBox pbMake;
        private System.Windows.Forms.PictureBox pbVehicleID;
        private Guna.UI.WinForms.GunaComboBox cbMake;
        private Guna.UI.WinForms.GunaComboBox cbModel;
        private Guna.UI.WinForms.GunaNumeric nudYear;
        private Guna.UI.WinForms.GunaNumeric nudMileage;
        private Guna.UI.WinForms.GunaComboBox cbFuelType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomContorls.CustomTextBox txtPlateNumber;
        private Guna.UI.WinForms.GunaComboBox cbCarCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCarCategory;
        private CustomContorls.CustomTextBox txtRentalPricePerDay;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblRentalPricePerDay;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkIsAvailable;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;


    }
}