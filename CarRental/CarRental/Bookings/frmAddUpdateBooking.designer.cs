namespace CarRental.Bookings
{
    partial class frmAddUpdateBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateBooking));
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblShowBookingId = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblRentStartData = new System.Windows.Forms.Label();
            this.lblRentEndData = new System.Windows.Forms.Label();
            this.tcBooking = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.ctrlCustomerCardWithFilter1 = new CarRental.Controls.ctrlCustomerCardWithFilter();
            this.tpVehicleInfo = new System.Windows.Forms.TabPage();
            this.ctrlVehicleCardWithFilter1 = new CarRental.Controls.ctrlVehicleCardWithFilter();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.txtPaidInitialTotalDueAmount = new CustomContorls.CustomTextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaymentDetails = new CustomContorls.CustomTextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowInitialRentDays = new System.Windows.Forms.Label();
            this.dtpRentEndDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpRentStartDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblShowRentPricePerDay = new System.Windows.Forms.Label();
            this.txtInitialCheckNotes = new CustomContorls.CustomTextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblInitialCheckNotes = new System.Windows.Forms.Label();
            this.lblShowInitialTotalDueAmount = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblInitialTotalDueAmount = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblRentPricePerDay = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblInitialRentDays = new System.Windows.Forms.Label();
            this.txtDropoffLocation = new CustomContorls.CustomTextBox();
            this.txtPickupLocation = new CustomContorls.CustomTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDropoffLocation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPickupLocation = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.tcBooking.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tpVehicleInfo.SuspendLayout();
            this.tpBookingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.lblFormTitle.Text = "Add Update Booking";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateBooking_MouseDown);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblShowBookingId
            // 
            this.lblShowBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowBookingId.ForeColor = System.Drawing.Color.White;
            this.lblShowBookingId.Location = new System.Drawing.Point(338, 12);
            this.lblShowBookingId.Name = "lblShowBookingId";
            this.lblShowBookingId.Size = new System.Drawing.Size(210, 37);
            this.lblShowBookingId.TabIndex = 21;
            this.lblShowBookingId.Text = "[?????]";
            // 
            // lblBookingID
            // 
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.White;
            this.lblBookingID.Location = new System.Drawing.Point(8, 12);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(203, 37);
            this.lblBookingID.TabIndex = 19;
            this.lblBookingID.Text = "Booking Id";
            // 
            // lblRentStartData
            // 
            this.lblRentStartData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentStartData.ForeColor = System.Drawing.Color.White;
            this.lblRentStartData.Location = new System.Drawing.Point(6, 68);
            this.lblRentStartData.Name = "lblRentStartData";
            this.lblRentStartData.Size = new System.Drawing.Size(200, 35);
            this.lblRentStartData.TabIndex = 26;
            this.lblRentStartData.Text = "Rent Start Date";
            this.lblRentStartData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRentEndData
            // 
            this.lblRentEndData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentEndData.ForeColor = System.Drawing.Color.White;
            this.lblRentEndData.Location = new System.Drawing.Point(6, 112);
            this.lblRentEndData.Name = "lblRentEndData";
            this.lblRentEndData.Size = new System.Drawing.Size(200, 35);
            this.lblRentEndData.TabIndex = 28;
            this.lblRentEndData.Text = "Rent End Date";
            this.lblRentEndData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcBooking
            // 
            this.tcBooking.Controls.Add(this.tpCustomerInfo);
            this.tcBooking.Controls.Add(this.tpVehicleInfo);
            this.tcBooking.Controls.Add(this.tpBookingInfo);
            this.tcBooking.ItemSize = new System.Drawing.Size(120, 40);
            this.tcBooking.Location = new System.Drawing.Point(8, 50);
            this.tcBooking.Name = "tcBooking";
            this.tcBooking.SelectedIndex = 0;
            this.tcBooking.Size = new System.Drawing.Size(825, 567);
            this.tcBooking.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcBooking.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcBooking.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBooking.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcBooking.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcBooking.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcBooking.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBooking.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBooking.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcBooking.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBooking.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcBooking.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcBooking.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBooking.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcBooking.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcBooking.TabButtonSize = new System.Drawing.Size(120, 40);
            this.tcBooking.TabIndex = 0;
            this.tcBooking.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBooking.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tpCustomerInfo.Controls.Add(this.ctrlCustomerCardWithFilter1);
            this.tpCustomerInfo.Location = new System.Drawing.Point(4, 44);
            this.tpCustomerInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Size = new System.Drawing.Size(817, 519);
            this.tpCustomerInfo.TabIndex = 0;
            this.tpCustomerInfo.Text = "Customer Info";
            // 
            // ctrlCustomerCardWithFilter1
            // 
            this.ctrlCustomerCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlCustomerCardWithFilter1.FilterEnabled = true;
            this.ctrlCustomerCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlCustomerCardWithFilter1.Name = "ctrlCustomerCardWithFilter1";
            this.ctrlCustomerCardWithFilter1.Size = new System.Drawing.Size(767, 507);
            this.ctrlCustomerCardWithFilter1.TabIndex = 1;
            this.ctrlCustomerCardWithFilter1.OnCustomerSelected += new System.Action<int>(this.ctrlCustomerCardWithFilter1_OnCustomerSelected);
            // 
            // tpVehicleInfo
            // 
            this.tpVehicleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tpVehicleInfo.Controls.Add(this.ctrlVehicleCardWithFilter1);
            this.tpVehicleInfo.Location = new System.Drawing.Point(4, 44);
            this.tpVehicleInfo.Name = "tpVehicleInfo";
            this.tpVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicleInfo.Size = new System.Drawing.Size(817, 519);
            this.tpVehicleInfo.TabIndex = 1;
            this.tpVehicleInfo.Text = "Vehicle Info";
            // 
            // ctrlVehicleCardWithFilter1
            // 
            this.ctrlVehicleCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlVehicleCardWithFilter1.FilterEnabled = true;
            this.ctrlVehicleCardWithFilter1.Location = new System.Drawing.Point(3, 6);
            this.ctrlVehicleCardWithFilter1.Name = "ctrlVehicleCardWithFilter1";
            this.ctrlVehicleCardWithFilter1.Size = new System.Drawing.Size(791, 380);
            this.ctrlVehicleCardWithFilter1.TabIndex = 2;
            this.ctrlVehicleCardWithFilter1.OnVehicleSelected += new System.Action<int>(this.ctrlVehicleCardWithFilter1_OnVehicleSelected);
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tpBookingInfo.Controls.Add(this.txtPaidInitialTotalDueAmount);
            this.tpBookingInfo.Controls.Add(this.pictureBox11);
            this.tpBookingInfo.Controls.Add(this.label2);
            this.tpBookingInfo.Controls.Add(this.txtPaymentDetails);
            this.tpBookingInfo.Controls.Add(this.pictureBox10);
            this.tpBookingInfo.Controls.Add(this.label1);
            this.tpBookingInfo.Controls.Add(this.lblShowInitialRentDays);
            this.tpBookingInfo.Controls.Add(this.dtpRentEndDate);
            this.tpBookingInfo.Controls.Add(this.dtpRentStartDate);
            this.tpBookingInfo.Controls.Add(this.lblShowRentPricePerDay);
            this.tpBookingInfo.Controls.Add(this.txtInitialCheckNotes);
            this.tpBookingInfo.Controls.Add(this.pictureBox9);
            this.tpBookingInfo.Controls.Add(this.lblInitialCheckNotes);
            this.tpBookingInfo.Controls.Add(this.lblShowInitialTotalDueAmount);
            this.tpBookingInfo.Controls.Add(this.pictureBox8);
            this.tpBookingInfo.Controls.Add(this.lblInitialTotalDueAmount);
            this.tpBookingInfo.Controls.Add(this.pictureBox7);
            this.tpBookingInfo.Controls.Add(this.lblRentPricePerDay);
            this.tpBookingInfo.Controls.Add(this.pictureBox5);
            this.tpBookingInfo.Controls.Add(this.lblInitialRentDays);
            this.tpBookingInfo.Controls.Add(this.txtDropoffLocation);
            this.tpBookingInfo.Controls.Add(this.txtPickupLocation);
            this.tpBookingInfo.Controls.Add(this.pictureBox2);
            this.tpBookingInfo.Controls.Add(this.lblDropoffLocation);
            this.tpBookingInfo.Controls.Add(this.pictureBox1);
            this.tpBookingInfo.Controls.Add(this.lblPickupLocation);
            this.tpBookingInfo.Controls.Add(this.lblShowBookingId);
            this.tpBookingInfo.Controls.Add(this.lblBookingID);
            this.tpBookingInfo.Controls.Add(this.pictureBox6);
            this.tpBookingInfo.Controls.Add(this.pictureBox4);
            this.tpBookingInfo.Controls.Add(this.lblRentEndData);
            this.tpBookingInfo.Controls.Add(this.lblRentStartData);
            this.tpBookingInfo.Controls.Add(this.pictureBox3);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 44);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingInfo.Size = new System.Drawing.Size(817, 519);
            this.tpBookingInfo.TabIndex = 2;
            this.tpBookingInfo.Text = "Booking Info";
            // 
            // txtPaidInitialTotalDueAmount
            // 
            this.txtPaidInitialTotalDueAmount.AllowEmpty = false;
            this.txtPaidInitialTotalDueAmount.BorderRadius = 12;
            this.txtPaidInitialTotalDueAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidInitialTotalDueAmount.CustomValidationMessage = null;
            this.txtPaidInitialTotalDueAmount.DefaultText = "";
            this.txtPaidInitialTotalDueAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaidInitialTotalDueAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaidInitialTotalDueAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidInitialTotalDueAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidInitialTotalDueAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaidInitialTotalDueAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPaidInitialTotalDueAmount.ForeColor = System.Drawing.Color.Black;
            this.txtPaidInitialTotalDueAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaidInitialTotalDueAmount.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtPaidInitialTotalDueAmount.Location = new System.Drawing.Point(327, 381);
            this.txtPaidInitialTotalDueAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaidInitialTotalDueAmount.MaxLength = 10;
            this.txtPaidInitialTotalDueAmount.Name = "txtPaidInitialTotalDueAmount";
            this.txtPaidInitialTotalDueAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPaidInitialTotalDueAmount.PlaceholderText = "Paid Ini Total Due Amount";
            this.txtPaidInitialTotalDueAmount.SelectedText = "";
            this.txtPaidInitialTotalDueAmount.Size = new System.Drawing.Size(245, 37);
            this.txtPaidInitialTotalDueAmount.TabIndex = 7;
            this.txtPaidInitialTotalDueAmount.ValidateInputType = true;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox11.Location = new System.Drawing.Point(270, 381);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 35);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 57;
            this.pictureBox11.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Paid Ini Total Due Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaymentDetails
            // 
            this.txtPaymentDetails.AllowEmpty = false;
            this.txtPaymentDetails.BorderRadius = 12;
            this.txtPaymentDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentDetails.CustomValidationMessage = null;
            this.txtPaymentDetails.DefaultText = "";
            this.txtPaymentDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaymentDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaymentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPaymentDetails.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentDetails.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtPaymentDetails.Location = new System.Drawing.Point(327, 426);
            this.txtPaymentDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaymentDetails.MaxLength = 255;
            this.txtPaymentDetails.Name = "txtPaymentDetails";
            this.txtPaymentDetails.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPaymentDetails.PlaceholderText = "Payment Details";
            this.txtPaymentDetails.SelectedText = "";
            this.txtPaymentDetails.Size = new System.Drawing.Size(245, 37);
            this.txtPaymentDetails.TabIndex = 8;
            this.txtPaymentDetails.ValidateInputType = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::CarRental.Properties.Resources.sticky_note;
            this.pictureBox10.Location = new System.Drawing.Point(271, 427);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 54;
            this.pictureBox10.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 53;
            this.label1.Text = "Payment Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowInitialRentDays
            // 
            this.lblShowInitialRentDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInitialRentDays.ForeColor = System.Drawing.Color.White;
            this.lblShowInitialRentDays.Location = new System.Drawing.Point(322, 246);
            this.lblShowInitialRentDays.Name = "lblShowInitialRentDays";
            this.lblShowInitialRentDays.Size = new System.Drawing.Size(235, 34);
            this.lblShowInitialRentDays.TabIndex = 51;
            this.lblShowInitialRentDays.Text = "1";
            this.lblShowInitialRentDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpRentEndDate
            // 
            this.dtpRentEndDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpRentEndDate.BaseColor = System.Drawing.Color.White;
            this.dtpRentEndDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpRentEndDate.CustomFormat = null;
            this.dtpRentEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpRentEndDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpRentEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentEndDate.ForeColor = System.Drawing.Color.Black;
            this.dtpRentEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentEndDate.Location = new System.Drawing.Point(327, 110);
            this.dtpRentEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRentEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRentEndDate.Name = "dtpRentEndDate";
            this.dtpRentEndDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpRentEndDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpRentEndDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpRentEndDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpRentEndDate.Radius = 10;
            this.dtpRentEndDate.Size = new System.Drawing.Size(176, 35);
            this.dtpRentEndDate.TabIndex = 4;
            this.dtpRentEndDate.Text = "12/23/2025";
            this.dtpRentEndDate.Value = new System.DateTime(2025, 12, 23, 18, 36, 1, 476);
            this.dtpRentEndDate.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // dtpRentStartDate
            // 
            this.dtpRentStartDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpRentStartDate.BaseColor = System.Drawing.Color.White;
            this.dtpRentStartDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpRentStartDate.CustomFormat = null;
            this.dtpRentStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpRentStartDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpRentStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentStartDate.ForeColor = System.Drawing.Color.Black;
            this.dtpRentStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentStartDate.Location = new System.Drawing.Point(327, 68);
            this.dtpRentStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRentStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRentStartDate.Name = "dtpRentStartDate";
            this.dtpRentStartDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpRentStartDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpRentStartDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpRentStartDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpRentStartDate.Radius = 10;
            this.dtpRentStartDate.Size = new System.Drawing.Size(176, 33);
            this.dtpRentStartDate.TabIndex = 3;
            this.dtpRentStartDate.Text = "12/23/2025";
            this.dtpRentStartDate.Value = new System.DateTime(2025, 12, 23, 18, 36, 1, 476);
            this.dtpRentStartDate.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // lblShowRentPricePerDay
            // 
            this.lblShowRentPricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRentPricePerDay.ForeColor = System.Drawing.Color.White;
            this.lblShowRentPricePerDay.Location = new System.Drawing.Point(322, 291);
            this.lblShowRentPricePerDay.Name = "lblShowRentPricePerDay";
            this.lblShowRentPricePerDay.Size = new System.Drawing.Size(235, 34);
            this.lblShowRentPricePerDay.TabIndex = 50;
            this.lblShowRentPricePerDay.Text = "$0";
            this.lblShowRentPricePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInitialCheckNotes
            // 
            this.txtInitialCheckNotes.AllowEmpty = true;
            this.txtInitialCheckNotes.BorderRadius = 12;
            this.txtInitialCheckNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialCheckNotes.CustomValidationMessage = null;
            this.txtInitialCheckNotes.DefaultText = "";
            this.txtInitialCheckNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialCheckNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitialCheckNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialCheckNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialCheckNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialCheckNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtInitialCheckNotes.ForeColor = System.Drawing.Color.Black;
            this.txtInitialCheckNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialCheckNotes.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtInitialCheckNotes.Location = new System.Drawing.Point(327, 471);
            this.txtInitialCheckNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInitialCheckNotes.MaxLength = 255;
            this.txtInitialCheckNotes.Name = "txtInitialCheckNotes";
            this.txtInitialCheckNotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInitialCheckNotes.PlaceholderText = "Initial Check Notes";
            this.txtInitialCheckNotes.SelectedText = "";
            this.txtInitialCheckNotes.Size = new System.Drawing.Size(245, 37);
            this.txtInitialCheckNotes.TabIndex = 9;
            this.txtInitialCheckNotes.ValidateInputType = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CarRental.Properties.Resources.sticky_note;
            this.pictureBox9.Location = new System.Drawing.Point(270, 471);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(35, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            // 
            // lblInitialCheckNotes
            // 
            this.lblInitialCheckNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialCheckNotes.ForeColor = System.Drawing.Color.White;
            this.lblInitialCheckNotes.Location = new System.Drawing.Point(11, 471);
            this.lblInitialCheckNotes.Name = "lblInitialCheckNotes";
            this.lblInitialCheckNotes.Size = new System.Drawing.Size(220, 37);
            this.lblInitialCheckNotes.TabIndex = 47;
            this.lblInitialCheckNotes.Text = "Ini Check Notes";
            this.lblInitialCheckNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowInitialTotalDueAmount
            // 
            this.lblShowInitialTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInitialTotalDueAmount.ForeColor = System.Drawing.Color.White;
            this.lblShowInitialTotalDueAmount.Location = new System.Drawing.Point(322, 333);
            this.lblShowInitialTotalDueAmount.Name = "lblShowInitialTotalDueAmount";
            this.lblShowInitialTotalDueAmount.Size = new System.Drawing.Size(235, 34);
            this.lblShowInitialTotalDueAmount.TabIndex = 46;
            this.lblShowInitialTotalDueAmount.Text = "$0";
            this.lblShowInitialTotalDueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox8.Location = new System.Drawing.Point(270, 333);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 45;
            this.pictureBox8.TabStop = false;
            // 
            // lblInitialTotalDueAmount
            // 
            this.lblInitialTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialTotalDueAmount.ForeColor = System.Drawing.Color.White;
            this.lblInitialTotalDueAmount.Location = new System.Drawing.Point(6, 336);
            this.lblInitialTotalDueAmount.Name = "lblInitialTotalDueAmount";
            this.lblInitialTotalDueAmount.Size = new System.Drawing.Size(223, 32);
            this.lblInitialTotalDueAmount.TabIndex = 44;
            this.lblInitialTotalDueAmount.Text = "Ini Total Due Amount";
            this.lblInitialTotalDueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox7.Location = new System.Drawing.Point(270, 290);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            // 
            // lblRentPricePerDay
            // 
            this.lblRentPricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPricePerDay.ForeColor = System.Drawing.Color.White;
            this.lblRentPricePerDay.Location = new System.Drawing.Point(6, 291);
            this.lblRentPricePerDay.Name = "lblRentPricePerDay";
            this.lblRentPricePerDay.Size = new System.Drawing.Size(223, 36);
            this.lblRentPricePerDay.TabIndex = 41;
            this.lblRentPricePerDay.Text = "Rent Price Per Day";
            this.lblRentPricePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CarRental.Properties.Resources.Date1;
            this.pictureBox5.Location = new System.Drawing.Point(270, 244);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // lblInitialRentDays
            // 
            this.lblInitialRentDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialRentDays.ForeColor = System.Drawing.Color.White;
            this.lblInitialRentDays.Location = new System.Drawing.Point(6, 246);
            this.lblInitialRentDays.Name = "lblInitialRentDays";
            this.lblInitialRentDays.Size = new System.Drawing.Size(200, 36);
            this.lblInitialRentDays.TabIndex = 38;
            this.lblInitialRentDays.Text = "Initial Rent Days";
            this.lblInitialRentDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDropoffLocation
            // 
            this.txtDropoffLocation.AllowEmpty = false;
            this.txtDropoffLocation.BorderRadius = 12;
            this.txtDropoffLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDropoffLocation.CustomValidationMessage = null;
            this.txtDropoffLocation.DefaultText = "";
            this.txtDropoffLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDropoffLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDropoffLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDropoffLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDropoffLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDropoffLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDropoffLocation.ForeColor = System.Drawing.Color.Black;
            this.txtDropoffLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDropoffLocation.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtDropoffLocation.Location = new System.Drawing.Point(327, 199);
            this.txtDropoffLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDropoffLocation.MaxLength = 500;
            this.txtDropoffLocation.Name = "txtDropoffLocation";
            this.txtDropoffLocation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDropoffLocation.PlaceholderText = "Dropoff Location";
            this.txtDropoffLocation.SelectedText = "";
            this.txtDropoffLocation.Size = new System.Drawing.Size(230, 36);
            this.txtDropoffLocation.TabIndex = 6;
            this.txtDropoffLocation.ValidateInputType = true;
            // 
            // txtPickupLocation
            // 
            this.txtPickupLocation.AllowEmpty = false;
            this.txtPickupLocation.BorderRadius = 12;
            this.txtPickupLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPickupLocation.CustomValidationMessage = null;
            this.txtPickupLocation.DefaultText = "";
            this.txtPickupLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPickupLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPickupLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickupLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickupLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickupLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPickupLocation.ForeColor = System.Drawing.Color.Black;
            this.txtPickupLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickupLocation.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtPickupLocation.Location = new System.Drawing.Point(327, 155);
            this.txtPickupLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPickupLocation.MaxLength = 500;
            this.txtPickupLocation.Name = "txtPickupLocation";
            this.txtPickupLocation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPickupLocation.PlaceholderText = "Pickup Location";
            this.txtPickupLocation.SelectedText = "";
            this.txtPickupLocation.Size = new System.Drawing.Size(230, 35);
            this.txtPickupLocation.TabIndex = 5;
            this.txtPickupLocation.ValidateInputType = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRental.Properties.Resources.Address;
            this.pictureBox2.Location = new System.Drawing.Point(270, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // lblDropoffLocation
            // 
            this.lblDropoffLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropoffLocation.ForeColor = System.Drawing.Color.White;
            this.lblDropoffLocation.Location = new System.Drawing.Point(6, 201);
            this.lblDropoffLocation.Name = "lblDropoffLocation";
            this.lblDropoffLocation.Size = new System.Drawing.Size(200, 36);
            this.lblDropoffLocation.TabIndex = 34;
            this.lblDropoffLocation.Text = "Dropoff Location";
            this.lblDropoffLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.Address;
            this.pictureBox1.Location = new System.Drawing.Point(270, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblPickupLocation
            // 
            this.lblPickupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickupLocation.ForeColor = System.Drawing.Color.White;
            this.lblPickupLocation.Location = new System.Drawing.Point(6, 156);
            this.lblPickupLocation.Name = "lblPickupLocation";
            this.lblPickupLocation.Size = new System.Drawing.Size(200, 36);
            this.lblPickupLocation.TabIndex = 32;
            this.lblPickupLocation.Text = "Pickup Location";
            this.lblPickupLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CarRental.Properties.Resources.booking;
            this.pictureBox6.Location = new System.Drawing.Point(270, 110);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pictureBox4.Location = new System.Drawing.Point(276, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.booking;
            this.pictureBox3.Location = new System.Drawing.Point(270, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
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
            this.btnSave.Location = new System.Drawing.Point(683, 618);
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
            // frmAddUpdateBooking
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(840, 669);
            this.Controls.Add(this.tcBooking);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Booking";
            this.Load += new System.EventHandler(this.frmAddUpdateBooking_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateBooking_MouseDown);
            this.tcBooking.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpVehicleInfo.ResumeLayout(false);
            this.tpBookingInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Label lblShowBookingId;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblRentStartData;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblRentEndData;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TabControl tcBooking;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private Controls.ctrlCustomerCardWithFilter ctrlCustomerCardWithFilter1;
        private System.Windows.Forms.TabPage tpVehicleInfo;
        private Controls.ctrlVehicleCardWithFilter ctrlVehicleCardWithFilter1;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDropoffLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPickupLocation;
        private CustomContorls.CustomTextBox txtDropoffLocation;
        private CustomContorls.CustomTextBox txtPickupLocation;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblInitialRentDays;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblRentPricePerDay;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblInitialTotalDueAmount;
        private System.Windows.Forms.Label lblShowInitialTotalDueAmount;
        private CustomContorls.CustomTextBox txtInitialCheckNotes;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblInitialCheckNotes;
        private System.Windows.Forms.Label lblShowRentPricePerDay;
        private Guna.UI.WinForms.GunaDateTimePicker dtpRentEndDate;
        private Guna.UI.WinForms.GunaDateTimePicker dtpRentStartDate;
        private System.Windows.Forms.Label lblShowInitialRentDays;
        private CustomContorls.CustomTextBox txtPaidInitialTotalDueAmount;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label2;
        private CustomContorls.CustomTextBox txtPaymentDetails;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;


    }
}