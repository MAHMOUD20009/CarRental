namespace CarRental.Users
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblShowPersonID = new System.Windows.Forms.Label();
            this.btnSelectPerson = new Guna.UI.WinForms.GunaButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new CustomContorls.CustomTextBox();
            this.txtUserName = new CustomContorls.CustomTextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblShowUserId = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtPassword = new CustomContorls.CustomTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new CustomContorls.CustomTextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMangeVehicles = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMangeUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMangeReturns = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMangeTransactions = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMangeCustomers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMangePeople = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAllPermissions = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMangeBookings = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBox.AnimationHoverSpeed = 0.07F;
            this.btnCloseBox.AnimationSpeed = 0.03F;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconSize = 15F;
            this.btnCloseBox.Location = new System.Drawing.Point(774, 0);
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCloseBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnCloseBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseBox.Size = new System.Drawing.Size(45, 29);
            this.btnCloseBox.TabIndex = 13;
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
            this.btnMinimizeBox.Location = new System.Drawing.Point(723, 0);
            this.btnMinimizeBox.Name = "btnMinimizeBox";
            this.btnMinimizeBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMinimizeBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizeBox.Size = new System.Drawing.Size(45, 29);
            this.btnMinimizeBox.TabIndex = 14;
            this.btnMinimizeBox.Click += new System.EventHandler(this.btnMinimizeBox_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(819, 47);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Add Update User";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateUser_MouseDown);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPersonID
            // 
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(6, 397);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(163, 36);
            this.lblPersonID.TabIndex = 12;
            this.lblPersonID.Text = "Person Id";
            // 
            // lblShowPersonID
            // 
            this.lblShowPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPersonID.ForeColor = System.Drawing.Color.White;
            this.lblShowPersonID.Location = new System.Drawing.Point(280, 399);
            this.lblShowPersonID.Name = "lblShowPersonID";
            this.lblShowPersonID.Size = new System.Drawing.Size(210, 37);
            this.lblShowPersonID.TabIndex = 14;
            this.lblShowPersonID.Text = "[?????]";
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPerson.AnimationHoverSpeed = 0.07F;
            this.btnSelectPerson.AnimationSpeed = 0.03F;
            this.btnSelectPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectPerson.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnSelectPerson.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelectPerson.BorderSize = 2;
            this.btnSelectPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectPerson.FocusedColor = System.Drawing.Color.Empty;
            this.btnSelectPerson.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.Image = null;
            this.btnSelectPerson.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectPerson.Location = new System.Drawing.Point(636, 460);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSelectPerson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSelectPerson.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.OnHoverImage = null;
            this.btnSelectPerson.OnPressedColor = System.Drawing.Color.Black;
            this.btnSelectPerson.Radius = 12;
            this.btnSelectPerson.Size = new System.Drawing.Size(172, 40);
            this.btnSelectPerson.TabIndex = 4;
            this.btnSelectPerson.Text = "Select Person";
            this.btnSelectPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(6, 464);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 36);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.AllowEmpty = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderRadius = 12;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.CustomValidationMessage = "";
            this.txtName.DefaultText = "";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.InputType = CustomContorls.CustomTextBox.enInputType.TextInput;
            this.txtName.Location = new System.Drawing.Point(286, 464);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Person Name";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(292, 36);
            this.txtName.TabIndex = 18;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.ValidateInputType = false;
            // 
            // txtUserName
            // 
            this.txtUserName.AllowEmpty = false;
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.BorderRadius = 12;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.CustomValidationMessage = null;
            this.txtUserName.DefaultText = "";
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtUserName.Location = new System.Drawing.Point(286, 140);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.MaxLength = 100;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(255, 36);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.ValidateInputType = true;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(3, 140);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(161, 36);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "User Name";
            // 
            // lblShowUserId
            // 
            this.lblShowUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUserId.ForeColor = System.Drawing.Color.White;
            this.lblShowUserId.Location = new System.Drawing.Point(280, 76);
            this.lblShowUserId.Name = "lblShowUserId";
            this.lblShowUserId.Size = new System.Drawing.Size(210, 37);
            this.lblShowUserId.TabIndex = 21;
            this.lblShowUserId.Text = "[?????]";
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(2, 76);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(203, 36);
            this.lblUserID.TabIndex = 19;
            this.lblUserID.Text = "User Id";
            // 
            // txtPassword
            // 
            this.txtPassword.AllowEmpty = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 12;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.CustomValidationMessage = null;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtPassword.Location = new System.Drawing.Point(286, 200);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(255, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.ValidateInputType = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(3, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(161, 36);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AllowEmpty = true;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.BorderRadius = 12;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.CustomValidationMessage = null;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.InputType = CustomContorls.CustomTextBox.enInputType.TextOrNumberInput;
            this.txtConfirmPassword.Location = new System.Drawing.Point(286, 260);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPassword.MaxLength = 100;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(255, 36);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.ValidateInputType = true;
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 260);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(202, 36);
            this.lblConfirmPassword.TabIndex = 28;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblIsActive
            // 
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.ForeColor = System.Drawing.Color.White;
            this.lblIsActive.Location = new System.Drawing.Point(3, 320);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(113, 36);
            this.lblIsActive.TabIndex = 30;
            this.lblIsActive.Text = "Is Active";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(222, 320);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(222, 260);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(222, 200);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.user__3_;
            this.pictureBox3.Location = new System.Drawing.Point(222, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pictureBox4.Location = new System.Drawing.Point(222, 74);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRental.Properties.Resources.user__3_;
            this.pictureBox2.Location = new System.Drawing.Point(219, 464);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.ID__2_;
            this.pictureBox1.Location = new System.Drawing.Point(219, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.btnSave.Location = new System.Drawing.Point(662, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.CheckedState.Image = global::CarRental.Properties.Resources.active_user;
            this.chkIsActive.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.chkIsActive.Image = global::CarRental.Properties.Resources.inactive_user;
            this.chkIsActive.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkIsActive.ImageRotate = 0F;
            this.chkIsActive.ImageSize = new System.Drawing.Size(25, 25);
            this.chkIsActive.Location = new System.Drawing.Point(286, 320);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(44, 36);
            this.chkIsActive.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMangeVehicles);
            this.groupBox1.Controls.Add(this.chkMangeUsers);
            this.groupBox1.Controls.Add(this.chkMangeReturns);
            this.groupBox1.Controls.Add(this.chkMangeTransactions);
            this.groupBox1.Controls.Add(this.chkMangeCustomers);
            this.groupBox1.Controls.Add(this.chkMangePeople);
            this.groupBox1.Controls.Add(this.chkAllPermissions);
            this.groupBox1.Controls.Add(this.chkMangeBookings);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(552, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // chkMangeVehicles
            // 
            this.chkMangeVehicles.AutoSize = true;
            this.chkMangeVehicles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeVehicles.CheckedState.BorderRadius = 0;
            this.chkMangeVehicles.CheckedState.BorderThickness = 0;
            this.chkMangeVehicles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeVehicles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangeVehicles.ForeColor = System.Drawing.Color.White;
            this.chkMangeVehicles.Location = new System.Drawing.Point(5, 100);
            this.chkMangeVehicles.Name = "chkMangeVehicles";
            this.chkMangeVehicles.Size = new System.Drawing.Size(100, 29);
            this.chkMangeVehicles.TabIndex = 11;
            this.chkMangeVehicles.Text = "Vehicles";
            this.chkMangeVehicles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMangeVehicles.UncheckedState.BorderRadius = 0;
            this.chkMangeVehicles.UncheckedState.BorderThickness = 0;
            this.chkMangeVehicles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkMangeUsers
            // 
            this.chkMangeUsers.AutoSize = true;
            this.chkMangeUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeUsers.CheckedState.BorderRadius = 0;
            this.chkMangeUsers.CheckedState.BorderThickness = 0;
            this.chkMangeUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangeUsers.ForeColor = System.Drawing.Color.White;
            this.chkMangeUsers.Location = new System.Drawing.Point(6, 171);
            this.chkMangeUsers.Name = "chkMangeUsers";
            this.chkMangeUsers.Size = new System.Drawing.Size(77, 29);
            this.chkMangeUsers.TabIndex = 9;
            this.chkMangeUsers.Text = "Users";
            this.chkMangeUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMangeUsers.UncheckedState.BorderRadius = 0;
            this.chkMangeUsers.UncheckedState.BorderThickness = 0;
            this.chkMangeUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkMangeReturns
            // 
            this.chkMangeReturns.AutoSize = true;
            this.chkMangeReturns.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeReturns.CheckedState.BorderRadius = 0;
            this.chkMangeReturns.CheckedState.BorderThickness = 0;
            this.chkMangeReturns.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeReturns.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangeReturns.ForeColor = System.Drawing.Color.White;
            this.chkMangeReturns.Location = new System.Drawing.Point(5, 136);
            this.chkMangeReturns.Name = "chkMangeReturns";
            this.chkMangeReturns.Size = new System.Drawing.Size(94, 29);
            this.chkMangeReturns.TabIndex = 10;
            this.chkMangeReturns.Text = "Returns";
            this.chkMangeReturns.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMangeReturns.UncheckedState.BorderRadius = 0;
            this.chkMangeReturns.UncheckedState.BorderThickness = 0;
            this.chkMangeReturns.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkMangeTransactions
            // 
            this.chkMangeTransactions.AutoSize = true;
            this.chkMangeTransactions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeTransactions.CheckedState.BorderRadius = 0;
            this.chkMangeTransactions.CheckedState.BorderThickness = 0;
            this.chkMangeTransactions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeTransactions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangeTransactions.ForeColor = System.Drawing.Color.White;
            this.chkMangeTransactions.Location = new System.Drawing.Point(115, 136);
            this.chkMangeTransactions.Name = "chkMangeTransactions";
            this.chkMangeTransactions.Size = new System.Drawing.Size(135, 29);
            this.chkMangeTransactions.TabIndex = 8;
            this.chkMangeTransactions.Text = "Transactions";
            this.chkMangeTransactions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMangeTransactions.UncheckedState.BorderRadius = 0;
            this.chkMangeTransactions.UncheckedState.BorderThickness = 0;
            this.chkMangeTransactions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkMangeCustomers
            // 
            this.chkMangeCustomers.AutoSize = true;
            this.chkMangeCustomers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeCustomers.CheckedState.BorderRadius = 0;
            this.chkMangeCustomers.CheckedState.BorderThickness = 0;
            this.chkMangeCustomers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangeCustomers.ForeColor = System.Drawing.Color.White;
            this.chkMangeCustomers.Location = new System.Drawing.Point(115, 65);
            this.chkMangeCustomers.Name = "chkMangeCustomers";
            this.chkMangeCustomers.Size = new System.Drawing.Size(120, 29);
            this.chkMangeCustomers.TabIndex = 6;
            this.chkMangeCustomers.Text = "Customers";
            this.chkMangeCustomers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMangeCustomers.UncheckedState.BorderRadius = 0;
            this.chkMangeCustomers.UncheckedState.BorderThickness = 0;
            this.chkMangeCustomers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkMangePeople
            // 
            this.chkMangePeople.AutoSize = true;
            this.chkMangePeople.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangePeople.CheckedState.BorderRadius = 0;
            this.chkMangePeople.CheckedState.BorderThickness = 0;
            this.chkMangePeople.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangePeople.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangePeople.ForeColor = System.Drawing.Color.White;
            this.chkMangePeople.Location = new System.Drawing.Point(5, 65);
            this.chkMangePeople.Name = "chkMangePeople";
            this.chkMangePeople.Size = new System.Drawing.Size(88, 29);
            this.chkMangePeople.TabIndex = 5;
            this.chkMangePeople.Text = "People";
            this.chkMangePeople.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMangePeople.UncheckedState.BorderRadius = 0;
            this.chkMangePeople.UncheckedState.BorderThickness = 0;
            this.chkMangePeople.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkAllPermissions
            // 
            this.chkAllPermissions.AutoSize = true;
            this.chkAllPermissions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAllPermissions.CheckedState.BorderRadius = 0;
            this.chkAllPermissions.CheckedState.BorderThickness = 0;
            this.chkAllPermissions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAllPermissions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllPermissions.ForeColor = System.Drawing.Color.White;
            this.chkAllPermissions.Location = new System.Drawing.Point(54, 28);
            this.chkAllPermissions.Name = "chkAllPermissions";
            this.chkAllPermissions.Size = new System.Drawing.Size(162, 29);
            this.chkAllPermissions.TabIndex = 4;
            this.chkAllPermissions.Text = " All Permissions";
            this.chkAllPermissions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAllPermissions.UncheckedState.BorderRadius = 0;
            this.chkAllPermissions.UncheckedState.BorderThickness = 0;
            this.chkAllPermissions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAllPermissions.CheckedChanged += new System.EventHandler(this.chkAllPermissions_CheckedChanged);
            // 
            // chkMangeBookings
            // 
            this.chkMangeBookings.AutoSize = true;
            this.chkMangeBookings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeBookings.CheckedState.BorderRadius = 0;
            this.chkMangeBookings.CheckedState.BorderThickness = 0;
            this.chkMangeBookings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMangeBookings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangeBookings.ForeColor = System.Drawing.Color.White;
            this.chkMangeBookings.Location = new System.Drawing.Point(115, 101);
            this.chkMangeBookings.Name = "chkMangeBookings";
            this.chkMangeBookings.Size = new System.Drawing.Size(108, 29);
            this.chkMangeBookings.TabIndex = 7;
            this.chkMangeBookings.Text = "Bookings";
            this.chkMangeBookings.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMangeBookings.UncheckedState.BorderRadius = 0;
            this.chkMangeBookings.UncheckedState.BorderThickness = 0;
            this.chkMangeBookings.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // frmAddUpdateUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(819, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblShowUserId);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtName);
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
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update User";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddUpdateUser_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomContorls.CustomTextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaButton btnSelectPerson;
        private System.Windows.Forms.Label lblShowPersonID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPersonID;
        private CustomContorls.CustomTextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblShowUserId;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblUserID;
        private CustomContorls.CustomTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblPassword;
        private CustomContorls.CustomTextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblIsActive;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkIsActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox chkMangeBookings;
        private Guna.UI2.WinForms.Guna2CheckBox chkMangeCustomers;
        private Guna.UI2.WinForms.Guna2CheckBox chkMangePeople;
        private Guna.UI2.WinForms.Guna2CheckBox chkAllPermissions;
        private Guna.UI2.WinForms.Guna2CheckBox chkMangeUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkMangeReturns;
        private Guna.UI2.WinForms.Guna2CheckBox chkMangeTransactions;
        private Guna.UI2.WinForms.Guna2CheckBox chkMangeVehicles;


    }
}