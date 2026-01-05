namespace CarRental.Returns
{
    partial class frmAddUpdateReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateReturn));
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tcReturn = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.ctrlBookingCardWithFilter1 = new CarRental.Controls.ctrlBookingCardWithFilter();
            this.tpReturnInfo = new System.Windows.Forms.TabPage();
            this.lblShowTotalRefundedAmount = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblTotalRefundedAmount = new System.Windows.Forms.Label();
            this.lblShowTotalRemaining = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblTotalRemaining = new System.Windows.Forms.Label();
            this.nudMileage = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblShowActualTotalDueAmount = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblActualTotalDueAmount = new System.Windows.Forms.Label();
            this.txtAdditionalCharges = new CustomContorls.CustomTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFinalCheckNotes = new CustomContorls.CustomTextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblFinalCheckNotes = new System.Windows.Forms.Label();
            this.lblShowConsumedMileage = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblConsumedMileage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowActualRentalDays = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblActualRentalDays = new System.Windows.Forms.Label();
            this.lblShowReturnID = new System.Windows.Forms.Label();
            this.dtpActualReturnDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActualReturnDate = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.tcReturn.SuspendLayout();
            this.tpBookingInfo.SuspendLayout();
            this.tpReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnCloseBox.Location = new System.Drawing.Point(965, 0);
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
            this.btnMinimizeBox.Location = new System.Drawing.Point(914, 0);
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
            this.lblFormTitle.Size = new System.Drawing.Size(1010, 47);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Add Update Return";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateReturn_MouseDown);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // tcReturn
            // 
            this.tcReturn.Controls.Add(this.tpBookingInfo);
            this.tcReturn.Controls.Add(this.tpReturnInfo);
            this.tcReturn.ItemSize = new System.Drawing.Size(120, 40);
            this.tcReturn.Location = new System.Drawing.Point(8, 56);
            this.tcReturn.Name = "tcReturn";
            this.tcReturn.SelectedIndex = 0;
            this.tcReturn.Size = new System.Drawing.Size(997, 589);
            this.tcReturn.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcReturn.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcReturn.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReturn.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcReturn.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcReturn.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcReturn.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcReturn.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReturn.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcReturn.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcReturn.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcReturn.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcReturn.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReturn.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcReturn.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcReturn.TabButtonSize = new System.Drawing.Size(120, 40);
            this.tcReturn.TabIndex = 12;
            this.tcReturn.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcReturn.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tpBookingInfo.Controls.Add(this.ctrlBookingCardWithFilter1);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 44);
            this.tpBookingInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Size = new System.Drawing.Size(989, 541);
            this.tpBookingInfo.TabIndex = 0;
            this.tpBookingInfo.Text = "Booking Info";
            // 
            // ctrlBookingCardWithFilter1
            // 
            this.ctrlBookingCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlBookingCardWithFilter1.FilterEnabled = true;
            this.ctrlBookingCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlBookingCardWithFilter1.Name = "ctrlBookingCardWithFilter1";
            this.ctrlBookingCardWithFilter1.Size = new System.Drawing.Size(983, 537);
            this.ctrlBookingCardWithFilter1.TabIndex = 0;
            this.ctrlBookingCardWithFilter1.OnBookingSelected += new System.Action<int>(this.ctrlBookingCardWithFilter1_OnBookingSelected);
            // 
            // tpReturnInfo
            // 
            this.tpReturnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tpReturnInfo.Controls.Add(this.lblShowTotalRefundedAmount);
            this.tpReturnInfo.Controls.Add(this.pictureBox10);
            this.tpReturnInfo.Controls.Add(this.lblTotalRefundedAmount);
            this.tpReturnInfo.Controls.Add(this.lblShowTotalRemaining);
            this.tpReturnInfo.Controls.Add(this.pictureBox9);
            this.tpReturnInfo.Controls.Add(this.lblTotalRemaining);
            this.tpReturnInfo.Controls.Add(this.nudMileage);
            this.tpReturnInfo.Controls.Add(this.lblShowActualTotalDueAmount);
            this.tpReturnInfo.Controls.Add(this.pictureBox8);
            this.tpReturnInfo.Controls.Add(this.lblActualTotalDueAmount);
            this.tpReturnInfo.Controls.Add(this.txtAdditionalCharges);
            this.tpReturnInfo.Controls.Add(this.pictureBox7);
            this.tpReturnInfo.Controls.Add(this.label3);
            this.tpReturnInfo.Controls.Add(this.txtFinalCheckNotes);
            this.tpReturnInfo.Controls.Add(this.pictureBox6);
            this.tpReturnInfo.Controls.Add(this.lblFinalCheckNotes);
            this.tpReturnInfo.Controls.Add(this.lblShowConsumedMileage);
            this.tpReturnInfo.Controls.Add(this.pictureBox5);
            this.tpReturnInfo.Controls.Add(this.lblConsumedMileage);
            this.tpReturnInfo.Controls.Add(this.pictureBox3);
            this.tpReturnInfo.Controls.Add(this.label2);
            this.tpReturnInfo.Controls.Add(this.lblShowActualRentalDays);
            this.tpReturnInfo.Controls.Add(this.pictureBox2);
            this.tpReturnInfo.Controls.Add(this.lblActualRentalDays);
            this.tpReturnInfo.Controls.Add(this.lblShowReturnID);
            this.tpReturnInfo.Controls.Add(this.dtpActualReturnDate);
            this.tpReturnInfo.Controls.Add(this.pictureBox1);
            this.tpReturnInfo.Controls.Add(this.pictureBox4);
            this.tpReturnInfo.Controls.Add(this.label1);
            this.tpReturnInfo.Controls.Add(this.lblActualReturnDate);
            this.tpReturnInfo.Location = new System.Drawing.Point(4, 44);
            this.tpReturnInfo.Name = "tpReturnInfo";
            this.tpReturnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReturnInfo.Size = new System.Drawing.Size(989, 541);
            this.tpReturnInfo.TabIndex = 1;
            this.tpReturnInfo.Text = "Return Info";
            // 
            // lblShowTotalRefundedAmount
            // 
            this.lblShowTotalRefundedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotalRefundedAmount.ForeColor = System.Drawing.Color.White;
            this.lblShowTotalRefundedAmount.Location = new System.Drawing.Point(805, 471);
            this.lblShowTotalRefundedAmount.Name = "lblShowTotalRefundedAmount";
            this.lblShowTotalRefundedAmount.Size = new System.Drawing.Size(178, 34);
            this.lblShowTotalRefundedAmount.TabIndex = 49;
            this.lblShowTotalRefundedAmount.Text = "?????";
            this.lblShowTotalRefundedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox10.Location = new System.Drawing.Point(758, 471);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 36);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            // 
            // lblTotalRefundedAmount
            // 
            this.lblTotalRefundedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRefundedAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalRefundedAmount.Location = new System.Drawing.Point(514, 471);
            this.lblTotalRefundedAmount.Name = "lblTotalRefundedAmount";
            this.lblTotalRefundedAmount.Size = new System.Drawing.Size(242, 36);
            this.lblTotalRefundedAmount.TabIndex = 47;
            this.lblTotalRefundedAmount.Text = "Total Refunded Amount";
            this.lblTotalRefundedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowTotalRemaining
            // 
            this.lblShowTotalRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotalRemaining.ForeColor = System.Drawing.Color.White;
            this.lblShowTotalRemaining.Location = new System.Drawing.Point(315, 471);
            this.lblShowTotalRemaining.Name = "lblShowTotalRemaining";
            this.lblShowTotalRemaining.Size = new System.Drawing.Size(193, 36);
            this.lblShowTotalRemaining.TabIndex = 46;
            this.lblShowTotalRemaining.Text = "?????";
            this.lblShowTotalRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox9.Location = new System.Drawing.Point(267, 471);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 36);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 45;
            this.pictureBox9.TabStop = false;
            // 
            // lblTotalRemaining
            // 
            this.lblTotalRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRemaining.ForeColor = System.Drawing.Color.White;
            this.lblTotalRemaining.Location = new System.Drawing.Point(6, 469);
            this.lblTotalRemaining.Name = "lblTotalRemaining";
            this.lblTotalRemaining.Size = new System.Drawing.Size(255, 36);
            this.lblTotalRemaining.TabIndex = 44;
            this.lblTotalRemaining.Text = "Total Remaining";
            this.lblTotalRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMileage
            // 
            this.nudMileage.BackColor = System.Drawing.Color.Transparent;
            this.nudMileage.BorderRadius = 6;
            this.nudMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMileage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudMileage.Location = new System.Drawing.Point(320, 184);
            this.nudMileage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMileage.Name = "nudMileage";
            this.nudMileage.Size = new System.Drawing.Size(163, 36);
            this.nudMileage.TabIndex = 43;
            this.nudMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMileage.ValueChanged += new System.EventHandler(this.nudMileage_ValueChanged);
            // 
            // lblShowActualTotalDueAmount
            // 
            this.lblShowActualTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowActualTotalDueAmount.ForeColor = System.Drawing.Color.White;
            this.lblShowActualTotalDueAmount.Location = new System.Drawing.Point(315, 408);
            this.lblShowActualTotalDueAmount.Name = "lblShowActualTotalDueAmount";
            this.lblShowActualTotalDueAmount.Size = new System.Drawing.Size(193, 36);
            this.lblShowActualTotalDueAmount.TabIndex = 42;
            this.lblShowActualTotalDueAmount.Text = "?????";
            this.lblShowActualTotalDueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox8.Location = new System.Drawing.Point(267, 408);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 41;
            this.pictureBox8.TabStop = false;
            // 
            // lblActualTotalDueAmount
            // 
            this.lblActualTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualTotalDueAmount.ForeColor = System.Drawing.Color.White;
            this.lblActualTotalDueAmount.Location = new System.Drawing.Point(6, 408);
            this.lblActualTotalDueAmount.Name = "lblActualTotalDueAmount";
            this.lblActualTotalDueAmount.Size = new System.Drawing.Size(255, 36);
            this.lblActualTotalDueAmount.TabIndex = 40;
            this.lblActualTotalDueAmount.Text = "Actual Total Due Amount";
            this.lblActualTotalDueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.AllowEmpty = false;
            this.txtAdditionalCharges.BorderRadius = 10;
            this.txtAdditionalCharges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalCharges.CustomValidationMessage = "Invalid Additional Charges";
            this.txtAdditionalCharges.DefaultText = "";
            this.txtAdditionalCharges.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalCharges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalCharges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalCharges.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalCharges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAdditionalCharges.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalCharges.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtAdditionalCharges.Location = new System.Drawing.Point(320, 352);
            this.txtAdditionalCharges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdditionalCharges.MaxLength = 10;
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAdditionalCharges.PlaceholderText = "Additional Charges";
            this.txtAdditionalCharges.SelectedText = "";
            this.txtAdditionalCharges.Size = new System.Drawing.Size(195, 36);
            this.txtAdditionalCharges.TabIndex = 2;
            this.txtAdditionalCharges.ValidateInputType = true;
            this.txtAdditionalCharges.TextChanged += new System.EventHandler(this.txtAdditionalCharges_TextChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CarRental.Properties.Resources.dollar;
            this.pictureBox7.Location = new System.Drawing.Point(267, 352);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 36);
            this.label3.TabIndex = 37;
            this.label3.Text = "Additional Charges";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFinalCheckNotes
            // 
            this.txtFinalCheckNotes.AllowEmpty = true;
            this.txtFinalCheckNotes.BorderRadius = 10;
            this.txtFinalCheckNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinalCheckNotes.CustomValidationMessage = "";
            this.txtFinalCheckNotes.DefaultText = "";
            this.txtFinalCheckNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalCheckNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinalCheckNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalCheckNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalCheckNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFinalCheckNotes.ForeColor = System.Drawing.Color.Black;
            this.txtFinalCheckNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtFinalCheckNotes.Location = new System.Drawing.Point(320, 296);
            this.txtFinalCheckNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinalCheckNotes.MaxLength = 500;
            this.txtFinalCheckNotes.Name = "txtFinalCheckNotes";
            this.txtFinalCheckNotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFinalCheckNotes.PlaceholderText = "Final Check Notes";
            this.txtFinalCheckNotes.SelectedText = "";
            this.txtFinalCheckNotes.Size = new System.Drawing.Size(195, 36);
            this.txtFinalCheckNotes.TabIndex = 1;
            this.txtFinalCheckNotes.ValidateInputType = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CarRental.Properties.Resources.sticky_note;
            this.pictureBox6.Location = new System.Drawing.Point(267, 296);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // lblFinalCheckNotes
            // 
            this.lblFinalCheckNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCheckNotes.ForeColor = System.Drawing.Color.White;
            this.lblFinalCheckNotes.Location = new System.Drawing.Point(6, 296);
            this.lblFinalCheckNotes.Name = "lblFinalCheckNotes";
            this.lblFinalCheckNotes.Size = new System.Drawing.Size(247, 36);
            this.lblFinalCheckNotes.TabIndex = 34;
            this.lblFinalCheckNotes.Text = "Final Check Notes";
            this.lblFinalCheckNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowConsumedMileage
            // 
            this.lblShowConsumedMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowConsumedMileage.ForeColor = System.Drawing.Color.White;
            this.lblShowConsumedMileage.Location = new System.Drawing.Point(315, 240);
            this.lblShowConsumedMileage.Name = "lblShowConsumedMileage";
            this.lblShowConsumedMileage.Size = new System.Drawing.Size(193, 36);
            this.lblShowConsumedMileage.TabIndex = 33;
            this.lblShowConsumedMileage.Text = "?????";
            this.lblShowConsumedMileage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CarRental.Properties.Resources.mileage;
            this.pictureBox5.Location = new System.Drawing.Point(267, 240);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // lblConsumedMileage
            // 
            this.lblConsumedMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumedMileage.ForeColor = System.Drawing.Color.White;
            this.lblConsumedMileage.Location = new System.Drawing.Point(6, 240);
            this.lblConsumedMileage.Name = "lblConsumedMileage";
            this.lblConsumedMileage.Size = new System.Drawing.Size(247, 36);
            this.lblConsumedMileage.TabIndex = 31;
            this.lblConsumedMileage.Text = "Consumed Mileage";
            this.lblConsumedMileage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.mileage;
            this.pictureBox3.Location = new System.Drawing.Point(267, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mileage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowActualRentalDays
            // 
            this.lblShowActualRentalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowActualRentalDays.ForeColor = System.Drawing.Color.White;
            this.lblShowActualRentalDays.Location = new System.Drawing.Point(315, 126);
            this.lblShowActualRentalDays.Name = "lblShowActualRentalDays";
            this.lblShowActualRentalDays.Size = new System.Drawing.Size(163, 36);
            this.lblShowActualRentalDays.TabIndex = 27;
            this.lblShowActualRentalDays.Text = "?????";
            this.lblShowActualRentalDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRental.Properties.Resources.Date1;
            this.pictureBox2.Location = new System.Drawing.Point(267, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lblActualRentalDays
            // 
            this.lblActualRentalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualRentalDays.ForeColor = System.Drawing.Color.White;
            this.lblActualRentalDays.Location = new System.Drawing.Point(6, 128);
            this.lblActualRentalDays.Name = "lblActualRentalDays";
            this.lblActualRentalDays.Size = new System.Drawing.Size(247, 36);
            this.lblActualRentalDays.TabIndex = 25;
            this.lblActualRentalDays.Text = "Actual Rental Days";
            this.lblActualRentalDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowReturnID
            // 
            this.lblShowReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowReturnID.ForeColor = System.Drawing.Color.White;
            this.lblShowReturnID.Location = new System.Drawing.Point(314, 15);
            this.lblShowReturnID.Name = "lblShowReturnID";
            this.lblShowReturnID.Size = new System.Drawing.Size(163, 36);
            this.lblShowReturnID.TabIndex = 24;
            this.lblShowReturnID.Text = "[?????]";
            this.lblShowReturnID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpActualReturnDate.BaseColor = System.Drawing.Color.White;
            this.dtpActualReturnDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpActualReturnDate.CustomFormat = null;
            this.dtpActualReturnDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpActualReturnDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpActualReturnDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActualReturnDate.ForeColor = System.Drawing.Color.Black;
            this.dtpActualReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActualReturnDate.Location = new System.Drawing.Point(320, 72);
            this.dtpActualReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpActualReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpActualReturnDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpActualReturnDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpActualReturnDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpActualReturnDate.Radius = 10;
            this.dtpActualReturnDate.Size = new System.Drawing.Size(163, 36);
            this.dtpActualReturnDate.TabIndex = 23;
            this.dtpActualReturnDate.Text = "12/28/2025";
            this.dtpActualReturnDate.Value = new System.DateTime(2025, 12, 28, 16, 26, 58, 430);
            this.dtpActualReturnDate.ValueChanged += new System.EventHandler(this.dtpActualReturnDate_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.Date1;
            this.pictureBox1.Location = new System.Drawing.Point(267, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pictureBox4.Location = new System.Drawing.Point(267, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActualReturnDate
            // 
            this.lblActualReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualReturnDate.ForeColor = System.Drawing.Color.White;
            this.lblActualReturnDate.Location = new System.Drawing.Point(6, 72);
            this.lblActualReturnDate.Name = "lblActualReturnDate";
            this.lblActualReturnDate.Size = new System.Drawing.Size(247, 36);
            this.lblActualReturnDate.TabIndex = 0;
            this.lblActualReturnDate.Text = "Actual Return Date";
            this.lblActualReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSave.Location = new System.Drawing.Point(853, 651);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1010, 697);
            this.Controls.Add(this.tcReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Return";
            this.Load += new System.EventHandler(this.frmAddUpdateReturn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateReturn_MouseDown);
            this.tcReturn.ResumeLayout(false);
            this.tpBookingInfo.ResumeLayout(false);
            this.tpReturnInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI2.WinForms.Guna2TabControl tcReturn;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private Controls.ctrlBookingCardWithFilter ctrlBookingCardWithFilter1;
        private System.Windows.Forms.TabPage tpReturnInfo;
        private System.Windows.Forms.Label lblActualReturnDate;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblShowActualRentalDays;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblActualRentalDays;
        private System.Windows.Forms.Label lblShowReturnID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowConsumedMileage;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblConsumedMileage;
        private CustomContorls.CustomTextBox txtFinalCheckNotes;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblFinalCheckNotes;
        private CustomContorls.CustomTextBox txtAdditionalCharges;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblActualTotalDueAmount;
        private System.Windows.Forms.Label lblShowActualTotalDueAmount;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMileage;
        private System.Windows.Forms.Label lblShowTotalRefundedAmount;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblTotalRefundedAmount;
        private System.Windows.Forms.Label lblShowTotalRemaining;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblTotalRemaining;


    }
}