namespace CarRental.Controls
{
    partial class ctrlCustomerCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCustomerCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEditCustomerInfo = new System.Windows.Forms.LinkLabel();
            this.lblShowDriverLicenseNumber = new System.Windows.Forms.Label();
            this.lblDriverLicenseNumber = new System.Windows.Forms.Label();
            this.pbPersonID = new System.Windows.Forms.PictureBox();
            this.lblShowCustomerD = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new CarRental.Controls.ctrlPersonCard();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblEditCustomerInfo);
            this.groupBox1.Controls.Add(this.lblShowDriverLicenseNumber);
            this.groupBox1.Controls.Add(this.lblDriverLicenseNumber);
            this.groupBox1.Controls.Add(this.pbPersonID);
            this.groupBox1.Controls.Add(this.lblShowCustomerD);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.VehiclesBlue_100;
            this.pictureBox1.Location = new System.Drawing.Point(277, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // lblEditCustomerInfo
            // 
            this.lblEditCustomerInfo.Enabled = false;
            this.lblEditCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomerInfo.LinkColor = System.Drawing.Color.White;
            this.lblEditCustomerInfo.Location = new System.Drawing.Point(579, 28);
            this.lblEditCustomerInfo.Name = "lblEditCustomerInfo";
            this.lblEditCustomerInfo.Size = new System.Drawing.Size(163, 39);
            this.lblEditCustomerInfo.TabIndex = 47;
            this.lblEditCustomerInfo.TabStop = true;
            this.lblEditCustomerInfo.Text = "Edit Customer Info";
            this.lblEditCustomerInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditCustomerInfo_LinkClicked);
            // 
            // lblShowDriverLicenseNumber
            // 
            this.lblShowDriverLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDriverLicenseNumber.ForeColor = System.Drawing.Color.White;
            this.lblShowDriverLicenseNumber.Location = new System.Drawing.Point(328, 116);
            this.lblShowDriverLicenseNumber.Name = "lblShowDriverLicenseNumber";
            this.lblShowDriverLicenseNumber.Size = new System.Drawing.Size(414, 34);
            this.lblShowDriverLicenseNumber.TabIndex = 43;
            this.lblShowDriverLicenseNumber.Text = "?????";
            // 
            // lblDriverLicenseNumber
            // 
            this.lblDriverLicenseNumber.AutoSize = true;
            this.lblDriverLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverLicenseNumber.ForeColor = System.Drawing.Color.White;
            this.lblDriverLicenseNumber.Location = new System.Drawing.Point(9, 116);
            this.lblDriverLicenseNumber.Name = "lblDriverLicenseNumber";
            this.lblDriverLicenseNumber.Size = new System.Drawing.Size(259, 32);
            this.lblDriverLicenseNumber.TabIndex = 41;
            this.lblDriverLicenseNumber.Text = "Driver License Number";
            // 
            // pbPersonID
            // 
            this.pbPersonID.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonID.Image")));
            this.pbPersonID.Location = new System.Drawing.Point(204, 63);
            this.pbPersonID.Name = "pbPersonID";
            this.pbPersonID.Size = new System.Drawing.Size(33, 34);
            this.pbPersonID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonID.TabIndex = 37;
            this.pbPersonID.TabStop = false;
            // 
            // lblShowCustomerD
            // 
            this.lblShowCustomerD.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCustomerD.ForeColor = System.Drawing.Color.White;
            this.lblShowCustomerD.Location = new System.Drawing.Point(242, 58);
            this.lblShowCustomerD.Name = "lblShowCustomerD";
            this.lblShowCustomerD.Size = new System.Drawing.Size(206, 39);
            this.lblShowCustomerD.TabIndex = 36;
            this.lblShowCustomerD.Text = "[?????]";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.White;
            this.lblCustomerID.Location = new System.Drawing.Point(8, 58);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(173, 40);
            this.lblCustomerID.TabIndex = 35;
            this.lblCustomerID.Text = "Customer Id";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 0);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(748, 196);
            this.ctrlPersonCard1.TabIndex = 3;
            // 
            // ctrlCustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlCustomerCard";
            this.Size = new System.Drawing.Size(756, 360);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lblEditCustomerInfo;
        private System.Windows.Forms.Label lblShowDriverLicenseNumber;
        private System.Windows.Forms.Label lblDriverLicenseNumber;
        private System.Windows.Forms.PictureBox pbPersonID;
        private System.Windows.Forms.Label lblShowCustomerD;
        private System.Windows.Forms.Label lblCustomerID;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
