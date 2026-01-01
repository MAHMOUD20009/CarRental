namespace CarRental.Bookings
{
    partial class frmBookingDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Guna.UI.WinForms.GunaControlBox btnMinimizeBox;
        private Guna.UI.WinForms.GunaControlBox btnCloseBox;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblFormTitle;

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
            this.btnMinimizeBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnCloseBox = new Guna.UI.WinForms.GunaControlBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.ctrlBookingCard1 = new CarRental.Controls.ctrlBookingCard();
            this.SuspendLayout();
            // 
            // btnMinimizeBox
            // 
            this.btnMinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeBox.AnimationHoverSpeed = 0.07F;
            this.btnMinimizeBox.AnimationSpeed = 0.03F;
            this.btnMinimizeBox.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimizeBox.IconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.IconSize = 15F;
            this.btnMinimizeBox.Location = new System.Drawing.Point(894, 0);
            this.btnMinimizeBox.Name = "btnMinimizeBox";
            this.btnMinimizeBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMinimizeBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizeBox.Size = new System.Drawing.Size(45, 29);
            this.btnMinimizeBox.TabIndex = 3;
            this.btnMinimizeBox.Click += new System.EventHandler(this.btnMinimizeBox_Click);
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBox.AnimationHoverSpeed = 0.07F;
            this.btnCloseBox.AnimationSpeed = 0.03F;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconSize = 15F;
            this.btnCloseBox.Location = new System.Drawing.Point(945, 0);
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCloseBox.OnHoverIconColor = System.Drawing.Color.White;
            this.btnCloseBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseBox.Size = new System.Drawing.Size(45, 29);
            this.btnCloseBox.TabIndex = 2;
            this.btnCloseBox.Click += new System.EventHandler(this.btnCloseBox_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(990, 52);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Booking Details";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlBookingCard1_MouseDown);
            // 
            // ctrlBookingCard1
            // 
            this.ctrlBookingCard1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlBookingCard1.Location = new System.Drawing.Point(2, 55);
            this.ctrlBookingCard1.Name = "ctrlBookingCard1";
            this.ctrlBookingCard1.Size = new System.Drawing.Size(987, 433);
            this.ctrlBookingCard1.TabIndex = 5;
            // 
            // frmBookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(990, 491);
            this.Controls.Add(this.ctrlBookingCard1);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Details";
            this.Load += new System.EventHandler(this.frmBookingDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlBookingCard ctrlBookingCard1;


    }
}