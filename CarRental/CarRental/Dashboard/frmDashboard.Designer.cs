namespace CarRental.Dashboard
{
    partial class frmDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pnlShowTotalPeople = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalPeople = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlShowTotalCustomers = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlShowTotalUsers = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlShowTotalVehicles = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalVehicles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlShowTotalBookings = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalBookings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlShowTotalReturns = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalReturns = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblVehicleNotAvailabe = new System.Windows.Forms.Label();
            this.lblVehicleAvailabe = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prbVehicleAvailable = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cmsServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlShowTotalPeople.SuspendLayout();
            this.pnlShowTotalCustomers.SuspendLayout();
            this.pnlShowTotalUsers.SuspendLayout();
            this.pnlShowTotalVehicles.SuspendLayout();
            this.pnlShowTotalBookings.SuspendLayout();
            this.pnlShowTotalReturns.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.cmsServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(18, 65);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(102, 30);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Hi Admin";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(17, 104);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(221, 37);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "Welcome Back";
            // 
            // pnlShowTotalPeople
            // 
            this.pnlShowTotalPeople.BorderRadius = 15;
            this.pnlShowTotalPeople.Controls.Add(this.lblTotalPeople);
            this.pnlShowTotalPeople.Controls.Add(this.label1);
            this.pnlShowTotalPeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pnlShowTotalPeople.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlShowTotalPeople.Location = new System.Drawing.Point(38, 219);
            this.pnlShowTotalPeople.Name = "pnlShowTotalPeople";
            this.pnlShowTotalPeople.Size = new System.Drawing.Size(179, 106);
            this.pnlShowTotalPeople.TabIndex = 4;
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPeople.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalPeople.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPeople.ForeColor = System.Drawing.Color.White;
            this.lblTotalPeople.Location = new System.Drawing.Point(0, 63);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(179, 43);
            this.lblTotalPeople.TabIndex = 5;
            this.lblTotalPeople.Text = "0";
            this.lblTotalPeople.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlShowTotalCustomers
            // 
            this.pnlShowTotalCustomers.BorderRadius = 15;
            this.pnlShowTotalCustomers.Controls.Add(this.lblTotalCustomers);
            this.pnlShowTotalCustomers.Controls.Add(this.label3);
            this.pnlShowTotalCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pnlShowTotalCustomers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlShowTotalCustomers.Location = new System.Drawing.Point(277, 219);
            this.pnlShowTotalCustomers.Name = "pnlShowTotalCustomers";
            this.pnlShowTotalCustomers.Size = new System.Drawing.Size(179, 106);
            this.pnlShowTotalCustomers.TabIndex = 6;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.White;
            this.lblTotalCustomers.Location = new System.Drawing.Point(0, 63);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(179, 43);
            this.lblTotalCustomers.TabIndex = 5;
            this.lblTotalCustomers.Text = "0";
            this.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlShowTotalUsers
            // 
            this.pnlShowTotalUsers.BorderRadius = 15;
            this.pnlShowTotalUsers.Controls.Add(this.lblTotalUsers);
            this.pnlShowTotalUsers.Controls.Add(this.label4);
            this.pnlShowTotalUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pnlShowTotalUsers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlShowTotalUsers.Location = new System.Drawing.Point(516, 219);
            this.pnlShowTotalUsers.Name = "pnlShowTotalUsers";
            this.pnlShowTotalUsers.Size = new System.Drawing.Size(179, 106);
            this.pnlShowTotalUsers.TabIndex = 7;
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.ForeColor = System.Drawing.Color.White;
            this.lblTotalUsers.Location = new System.Drawing.Point(0, 63);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(179, 43);
            this.lblTotalUsers.TabIndex = 5;
            this.lblTotalUsers.Text = "0";
            this.lblTotalUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "Users";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlShowTotalVehicles
            // 
            this.pnlShowTotalVehicles.BorderRadius = 15;
            this.pnlShowTotalVehicles.Controls.Add(this.lblTotalVehicles);
            this.pnlShowTotalVehicles.Controls.Add(this.label5);
            this.pnlShowTotalVehicles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pnlShowTotalVehicles.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlShowTotalVehicles.Location = new System.Drawing.Point(38, 378);
            this.pnlShowTotalVehicles.Name = "pnlShowTotalVehicles";
            this.pnlShowTotalVehicles.Size = new System.Drawing.Size(179, 106);
            this.pnlShowTotalVehicles.TabIndex = 8;
            // 
            // lblTotalVehicles
            // 
            this.lblTotalVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVehicles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalVehicles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVehicles.ForeColor = System.Drawing.Color.White;
            this.lblTotalVehicles.Location = new System.Drawing.Point(0, 63);
            this.lblTotalVehicles.Name = "lblTotalVehicles";
            this.lblTotalVehicles.Size = new System.Drawing.Size(179, 43);
            this.lblTotalVehicles.TabIndex = 5;
            this.lblTotalVehicles.Text = "0";
            this.lblTotalVehicles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 44);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vehicles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlShowTotalBookings
            // 
            this.pnlShowTotalBookings.BorderRadius = 15;
            this.pnlShowTotalBookings.Controls.Add(this.lblTotalBookings);
            this.pnlShowTotalBookings.Controls.Add(this.label6);
            this.pnlShowTotalBookings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pnlShowTotalBookings.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlShowTotalBookings.Location = new System.Drawing.Point(277, 378);
            this.pnlShowTotalBookings.Name = "pnlShowTotalBookings";
            this.pnlShowTotalBookings.Size = new System.Drawing.Size(179, 106);
            this.pnlShowTotalBookings.TabIndex = 9;
            // 
            // lblTotalBookings
            // 
            this.lblTotalBookings.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBookings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalBookings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBookings.ForeColor = System.Drawing.Color.White;
            this.lblTotalBookings.Location = new System.Drawing.Point(0, 63);
            this.lblTotalBookings.Name = "lblTotalBookings";
            this.lblTotalBookings.Size = new System.Drawing.Size(179, 43);
            this.lblTotalBookings.TabIndex = 5;
            this.lblTotalBookings.Text = "0";
            this.lblTotalBookings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bookings";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlShowTotalReturns
            // 
            this.pnlShowTotalReturns.BorderRadius = 15;
            this.pnlShowTotalReturns.Controls.Add(this.lblTotalReturns);
            this.pnlShowTotalReturns.Controls.Add(this.label7);
            this.pnlShowTotalReturns.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pnlShowTotalReturns.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlShowTotalReturns.Location = new System.Drawing.Point(516, 378);
            this.pnlShowTotalReturns.Name = "pnlShowTotalReturns";
            this.pnlShowTotalReturns.Size = new System.Drawing.Size(179, 106);
            this.pnlShowTotalReturns.TabIndex = 10;
            // 
            // lblTotalReturns
            // 
            this.lblTotalReturns.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalReturns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalReturns.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReturns.ForeColor = System.Drawing.Color.White;
            this.lblTotalReturns.Location = new System.Drawing.Point(0, 63);
            this.lblTotalReturns.Name = "lblTotalReturns";
            this.lblTotalReturns.Size = new System.Drawing.Size(179, 43);
            this.lblTotalReturns.TabIndex = 5;
            this.lblTotalReturns.Text = "0";
            this.lblTotalReturns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 44);
            this.label7.TabIndex = 5;
            this.label7.Text = "Returns";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDate.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(0, 520);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(933, 50);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.Controls.Add(this.lblVehicleNotAvailabe);
            this.guna2GradientPanel1.Controls.Add(this.lblVehicleAvailabe);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.panel2);
            this.guna2GradientPanel1.Controls.Add(this.panel1);
            this.guna2GradientPanel1.Controls.Add(this.prbVehicleAvailable);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(724, 219);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(197, 265);
            this.guna2GradientPanel1.TabIndex = 8;
            // 
            // lblVehicleNotAvailabe
            // 
            this.lblVehicleNotAvailabe.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNotAvailabe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNotAvailabe.ForeColor = System.Drawing.Color.Yellow;
            this.lblVehicleNotAvailabe.Location = new System.Drawing.Point(133, 216);
            this.lblVehicleNotAvailabe.Name = "lblVehicleNotAvailabe";
            this.lblVehicleNotAvailabe.Size = new System.Drawing.Size(64, 31);
            this.lblVehicleNotAvailabe.TabIndex = 16;
            this.lblVehicleNotAvailabe.Text = "%100";
            this.lblVehicleNotAvailabe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVehicleAvailabe
            // 
            this.lblVehicleAvailabe.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleAvailabe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleAvailabe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblVehicleAvailabe.Location = new System.Drawing.Point(130, 167);
            this.lblVehicleAvailabe.Name = "lblVehicleAvailabe";
            this.lblVehicleAvailabe.Size = new System.Drawing.Size(64, 31);
            this.lblVehicleAvailabe.TabIndex = 12;
            this.lblVehicleAvailabe.Text = "%100";
            this.lblVehicleAvailabe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Not Available";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Available";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(7, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 20);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(7, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 20);
            this.panel1.TabIndex = 13;
            // 
            // prbVehicleAvailable
            // 
            this.prbVehicleAvailable.Animated = true;
            this.prbVehicleAvailable.AnimationSpeed = 0.05F;
            this.prbVehicleAvailable.BackColor = System.Drawing.Color.Transparent;
            this.prbVehicleAvailable.Backwards = true;
            this.prbVehicleAvailable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prbVehicleAvailable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prbVehicleAvailable.ForeColor = System.Drawing.SystemColors.Window;
            this.prbVehicleAvailable.InnerColor = System.Drawing.Color.Transparent;
            this.prbVehicleAvailable.Location = new System.Drawing.Point(31, 12);
            this.prbVehicleAvailable.Minimum = 0;
            this.prbVehicleAvailable.Name = "prbVehicleAvailable";
            this.prbVehicleAvailable.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.prbVehicleAvailable.ProgressColor2 = System.Drawing.Color.RoyalBlue;
            this.prbVehicleAvailable.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prbVehicleAvailable.Size = new System.Drawing.Size(139, 139);
            this.prbVehicleAvailable.TabIndex = 12;
            this.prbVehicleAvailable.Text = "guna2CircleProgressBar1";
            this.prbVehicleAvailable.Value = 90;
            // 
            // cmsServices
            // 
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.cmsServices.Name = "cmsServices";
            this.cmsServices.Size = new System.Drawing.Size(122, 34);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::CarRental.Properties.Resources.Refresh24;
            this.refreshToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(121, 30);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.ContextMenuStrip = this.cmsServices;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pnlShowTotalReturns);
            this.Controls.Add(this.pnlShowTotalBookings);
            this.Controls.Add(this.pnlShowTotalVehicles);
            this.Controls.Add(this.pnlShowTotalUsers);
            this.Controls.Add(this.pnlShowTotalCustomers);
            this.Controls.Add(this.pnlShowTotalPeople);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlShowTotalPeople.ResumeLayout(false);
            this.pnlShowTotalCustomers.ResumeLayout(false);
            this.pnlShowTotalUsers.ResumeLayout(false);
            this.pnlShowTotalVehicles.ResumeLayout(false);
            this.pnlShowTotalBookings.ResumeLayout(false);
            this.pnlShowTotalReturns.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.cmsServices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlShowTotalPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPeople;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlShowTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlShowTotalUsers;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlShowTotalVehicles;
        private System.Windows.Forms.Label lblTotalVehicles;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlShowTotalBookings;
        private System.Windows.Forms.Label lblTotalBookings;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlShowTotalReturns;
        private System.Windows.Forms.Label lblTotalReturns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prbVehicleAvailable;
        private System.Windows.Forms.Label lblVehicleNotAvailabe;
        private System.Windows.Forms.Label lblVehicleAvailabe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmsServices;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}