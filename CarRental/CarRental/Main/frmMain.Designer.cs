namespace CarRental.Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pbImageSidebar;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnPeople;
        private Guna.UI2.WinForms.Guna2Button btnTransactions;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnBooking;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pbImageSidebar = new System.Windows.Forms.PictureBox();
            this.btnMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.btnCurrentUserInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSidebar)).BeginInit();
            this.pnlFormTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.pnlSidebar.Controls.Add(this.pbImageSidebar);
            this.pnlSidebar.Controls.Add(this.btnMaintenance);
            this.pnlSidebar.Controls.Add(this.btnCurrentUserInfo);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnUsers);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnReturn);
            this.pnlSidebar.Controls.Add(this.btnTransactions);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnBooking);
            this.pnlSidebar.Controls.Add(this.btnPeople);
            this.pnlSidebar.Controls.Add(this.btnVehicles);
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(162, 655);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pbImageSidebar
            // 
            this.pbImageSidebar.Image = ((System.Drawing.Image)(resources.GetObject("pbImageSidebar.Image")));
            this.pbImageSidebar.Location = new System.Drawing.Point(143, 56);
            this.pbImageSidebar.Name = "pbImageSidebar";
            this.pbImageSidebar.Size = new System.Drawing.Size(35, 60);
            this.pbImageSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageSidebar.TabIndex = 2;
            this.pbImageSidebar.TabStop = false;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnMaintenance.BorderRadius = 15;
            this.btnMaintenance.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMaintenance.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMaintenance.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnMaintenance.CustomImages.CheckedImage = global::CarRental.Properties.Resources.MaintenanceBlue32;
            this.btnMaintenance.CustomImages.Image = global::CarRental.Properties.Resources.MaintenanceWhite32;
            this.btnMaintenance.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaintenance.FillColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.Location = new System.Drawing.Point(5, 473);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(149, 43);
            this.btnMaintenance.TabIndex = 8;
            this.btnMaintenance.Tag = "";
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMaintenance.TextOffset = new System.Drawing.Point(20, 0);
            this.btnMaintenance.Tile = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnCurrentUserInfo
            // 
            this.btnCurrentUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCurrentUserInfo.BorderRadius = 15;
            this.btnCurrentUserInfo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCurrentUserInfo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCurrentUserInfo.CustomImages.Image = global::CarRental.Properties.Resources.id_card;
            this.btnCurrentUserInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCurrentUserInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentUserInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentUserInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCurrentUserInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCurrentUserInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnCurrentUserInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnCurrentUserInfo.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCurrentUserInfo.Location = new System.Drawing.Point(1, 561);
            this.btnCurrentUserInfo.Margin = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            this.btnCurrentUserInfo.Size = new System.Drawing.Size(161, 43);
            this.btnCurrentUserInfo.TabIndex = 9;
            this.btnCurrentUserInfo.Tag = "131, 384";
            this.btnCurrentUserInfo.Text = "Current User";
            this.btnCurrentUserInfo.Tile = true;
            this.btnCurrentUserInfo.Click += new System.EventHandler(this.btnCurrentUserInfo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogout.CustomImages.Image = global::CarRental.Properties.Resources.logout_321;
            this.btnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(1, 607);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(161, 43);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Tag = "131, 384";
            this.btnLogout.Text = "Log out";
            this.btnLogout.Tile = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUsers.BorderRadius = 15;
            this.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUsers.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUsers.CustomImages.CheckedImage = global::CarRental.Properties.Resources.UsersBlue125_;
            this.btnUsers.CustomImages.Image = global::CarRental.Properties.Resources.UsersWhite_64;
            this.btnUsers.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Location = new System.Drawing.Point(5, 424);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(149, 43);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Tag = "";
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.TextOffset = new System.Drawing.Point(20, 0);
            this.btnUsers.Tile = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashboard.BorderRadius = 15;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashboard.CustomImages.CheckedImage = global::CarRental.Properties.Resources.dashboardBlue;
            this.btnDashboard.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.CustomImages.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(5, 66);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(149, 43);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Tag = "";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(20, 0);
            this.btnDashboard.Tile = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReturn.BorderRadius = 15;
            this.btnReturn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReturn.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReturn.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReturn.CustomImages.CheckedImage = global::CarRental.Properties.Resources.ReturnBlue;
            this.btnReturn.CustomImages.Image = global::CarRental.Properties.Resources.ReturnWhite;
            this.btnReturn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.Transparent;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnReturn.Location = new System.Drawing.Point(5, 372);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 43);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Tag = "";
            this.btnReturn.Text = "Returns";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReturn.TextOffset = new System.Drawing.Point(20, 0);
            this.btnReturn.Tile = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnTransactions.BorderRadius = 15;
            this.btnTransactions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTransactions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTransactions.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnTransactions.CustomImages.CheckedImage = global::CarRental.Properties.Resources.TransactionBlue1;
            this.btnTransactions.CustomImages.Image = global::CarRental.Properties.Resources.TransactionWhite;
            this.btnTransactions.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactions.FillColor = System.Drawing.Color.Transparent;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnTransactions.Location = new System.Drawing.Point(5, 320);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(149, 43);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Tag = "";
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransactions.TextOffset = new System.Drawing.Point(20, 0);
            this.btnTransactions.Tile = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCustomers.BorderRadius = 15;
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomers.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCustomers.CustomImages.CheckedImage = global::CarRental.Properties.Resources.CustomersBlue;
            this.btnCustomers.CustomImages.Image = global::CarRental.Properties.Resources.CustomersWhite;
            this.btnCustomers.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.Location = new System.Drawing.Point(5, 170);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(149, 43);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Tag = "";
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCustomers.Tile = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnBooking.BorderRadius = 15;
            this.btnBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBooking.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBooking.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnBooking.CustomImages.CheckedImage = global::CarRental.Properties.Resources.BookingBlue;
            this.btnBooking.CustomImages.Image = global::CarRental.Properties.Resources.BookingWhite;
            this.btnBooking.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.Color.Transparent;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnBooking.ImageSize = new System.Drawing.Size(15, 15);
            this.btnBooking.Location = new System.Drawing.Point(5, 268);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(149, 43);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Tag = "";
            this.btnBooking.Text = "Booking";
            this.btnBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooking.TextOffset = new System.Drawing.Point(20, 0);
            this.btnBooking.Tile = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPeople.BorderRadius = 15;
            this.btnPeople.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPeople.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPeople.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPeople.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage")));
            this.btnPeople.CustomImages.Image = global::CarRental.Properties.Resources.PeopleWhite;
            this.btnPeople.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPeople.FillColor = System.Drawing.Color.Transparent;
            this.btnPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.White;
            this.btnPeople.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnPeople.Location = new System.Drawing.Point(5, 118);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(149, 43);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Tag = "";
            this.btnPeople.Text = "People";
            this.btnPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.TextOffset = new System.Drawing.Point(20, 0);
            this.btnPeople.Tile = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnVehicles.BorderRadius = 15;
            this.btnVehicles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVehicles.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnVehicles.CheckedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnVehicles.CustomImages.CheckedImage = global::CarRental.Properties.Resources.VehiclesBlue_100;
            this.btnVehicles.CustomImages.Image = global::CarRental.Properties.Resources.VehilcesWhite_90;
            this.btnVehicles.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicles.FillColor = System.Drawing.Color.Transparent;
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnVehicles.Location = new System.Drawing.Point(5, 219);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(149, 43);
            this.btnVehicles.TabIndex = 3;
            this.btnVehicles.Tag = "";
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.TextOffset = new System.Drawing.Point(20, 0);
            this.btnVehicles.Tile = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(5, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.pnlFormTitle.Controls.Add(this.btnClose);
            this.pnlFormTitle.Controls.Add(this.lblFormTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(162, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(949, 32);
            this.pnlFormTitle.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 15;
            this.btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnClose.CustomIconSize = 15F;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(902, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(949, 32);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Form Title";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormTitle_MouseDown);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(162, 32);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(949, 623);
            this.pnlMain.TabIndex = 2;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 655);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFormTitle);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSidebar)).EndInit();
            this.pnlFormTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnVehicles;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnCurrentUserInfo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnMaintenance;

    }
}

