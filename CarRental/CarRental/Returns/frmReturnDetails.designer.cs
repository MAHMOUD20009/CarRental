namespace CarRental.Returns
{
    partial class frmReturnDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Guna.UI.WinForms.GunaControlBox btnMinimizeBox;
        private Guna.UI.WinForms.GunaControlBox btnCloseBox;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblFormTitle;
        private Controls.ctrlReturnCard ctrlReturnCard1;

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
            this.ctrlReturnCard1 = new CarRental.Controls.ctrlReturnCard();
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
            this.btnMinimizeBox.Location = new System.Drawing.Point(856, 0);
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
            this.btnCloseBox.Location = new System.Drawing.Point(907, 0);
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
            this.lblFormTitle.Size = new System.Drawing.Size(952, 49);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Return Details";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlReturnCard1_MouseDown);
            // 
            // ctrlReturnCard1
            // 
            this.ctrlReturnCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlReturnCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlReturnCard1.Location = new System.Drawing.Point(0, 60);
            this.ctrlReturnCard1.Name = "ctrlReturnCard1";
            this.ctrlReturnCard1.Size = new System.Drawing.Size(952, 223);
            this.ctrlReturnCard1.TabIndex = 5;
            this.ctrlReturnCard1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlReturnCard1_MouseDown);
            // 
            // frmReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(952, 283);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.ctrlReturnCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Details";
            this.Load += new System.EventHandler(this.frmReturnDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion


    }
}