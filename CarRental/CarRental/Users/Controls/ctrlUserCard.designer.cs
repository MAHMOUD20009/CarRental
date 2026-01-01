namespace CarRental.Controls
{
    partial class ctrlUserCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlUserCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbIsActive = new System.Windows.Forms.PictureBox();
            this.lblShowIsActive = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblShowUserName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEditUserInfo = new System.Windows.Forms.LinkLabel();
            this.pbPersonID = new System.Windows.Forms.PictureBox();
            this.lblShowUserD = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new CarRental.Controls.ctrlPersonCard();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbIsActive);
            this.groupBox1.Controls.Add(this.lblShowIsActive);
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblShowUserName);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblEditUserInfo);
            this.groupBox1.Controls.Add(this.pbPersonID);
            this.groupBox1.Controls.Add(this.lblShowUserD);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // pbIsActive
            // 
            this.pbIsActive.Image = global::CarRental.Properties.Resources.active_user;
            this.pbIsActive.Location = new System.Drawing.Point(581, 71);
            this.pbIsActive.Name = "pbIsActive";
            this.pbIsActive.Size = new System.Drawing.Size(33, 34);
            this.pbIsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsActive.TabIndex = 53;
            this.pbIsActive.TabStop = false;
            // 
            // lblShowIsActive
            // 
            this.lblShowIsActive.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowIsActive.ForeColor = System.Drawing.Color.White;
            this.lblShowIsActive.Location = new System.Drawing.Point(620, 73);
            this.lblShowIsActive.Name = "lblShowIsActive";
            this.lblShowIsActive.Size = new System.Drawing.Size(102, 34);
            this.lblShowIsActive.TabIndex = 52;
            this.lblShowIsActive.Text = "Inactive";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.ForeColor = System.Drawing.Color.White;
            this.lblIsActive.Location = new System.Drawing.Point(449, 71);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(103, 32);
            this.lblIsActive.TabIndex = 51;
            this.lblIsActive.Text = "Is Active";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblShowUserName
            // 
            this.lblShowUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUserName.ForeColor = System.Drawing.Color.White;
            this.lblShowUserName.Location = new System.Drawing.Point(183, 120);
            this.lblShowUserName.Name = "lblShowUserName";
            this.lblShowUserName.Size = new System.Drawing.Size(203, 34);
            this.lblShowUserName.TabIndex = 49;
            this.lblShowUserName.Text = "[?????]";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(6, 120);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(133, 32);
            this.lblUserName.TabIndex = 48;
            this.lblUserName.Text = "User Name";
            // 
            // lblEditUserInfo
            // 
            this.lblEditUserInfo.Enabled = false;
            this.lblEditUserInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUserInfo.LinkColor = System.Drawing.Color.White;
            this.lblEditUserInfo.Location = new System.Drawing.Point(579, 28);
            this.lblEditUserInfo.Name = "lblEditUserInfo";
            this.lblEditUserInfo.Size = new System.Drawing.Size(163, 39);
            this.lblEditUserInfo.TabIndex = 47;
            this.lblEditUserInfo.TabStop = true;
            this.lblEditUserInfo.Text = "Edit User Info";
            this.lblEditUserInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditUserInfo_LinkClicked);
            // 
            // pbPersonID
            // 
            this.pbPersonID.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonID.Image")));
            this.pbPersonID.Location = new System.Drawing.Point(142, 70);
            this.pbPersonID.Name = "pbPersonID";
            this.pbPersonID.Size = new System.Drawing.Size(33, 34);
            this.pbPersonID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonID.TabIndex = 37;
            this.pbPersonID.TabStop = false;
            // 
            // lblShowUserD
            // 
            this.lblShowUserD.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUserD.ForeColor = System.Drawing.Color.White;
            this.lblShowUserD.Location = new System.Drawing.Point(181, 66);
            this.lblShowUserD.Name = "lblShowUserD";
            this.lblShowUserD.Size = new System.Drawing.Size(233, 39);
            this.lblShowUserD.TabIndex = 36;
            this.lblShowUserD.Text = "[?????]";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(7, 63);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(107, 40);
            this.lblUserID.TabIndex = 35;
            this.lblUserID.Text = "User Id";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 0);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(748, 199);
            this.ctrlPersonCard1.TabIndex = 3;
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(756, 377);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lblEditUserInfo;
        private System.Windows.Forms.PictureBox pbPersonID;
        private System.Windows.Forms.Label lblShowUserD;
        private System.Windows.Forms.Label lblUserID;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.PictureBox pbIsActive;
        private System.Windows.Forms.Label lblShowIsActive;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblShowUserName;
        private System.Windows.Forms.Label lblUserName;
    }
}
