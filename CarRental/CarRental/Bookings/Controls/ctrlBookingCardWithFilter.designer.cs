namespace CarRental.Controls
{
    partial class ctrlBookingCardWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewBooking = new Guna.UI.WinForms.GunaButton();
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.ctrlBookingCard1 = new CarRental.Controls.ctrlBookingCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.btnAddNewBooking);
            this.gbFilter.Controls.Add(this.txtSearchValue);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(490, 94);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Booking Id";
            // 
            // btnAddNewBooking
            // 
            this.btnAddNewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewBooking.AnimationHoverSpeed = 0.07F;
            this.btnAddNewBooking.AnimationSpeed = 0.03F;
            this.btnAddNewBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewBooking.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(185)))));
            this.btnAddNewBooking.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewBooking.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewBooking.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewBooking.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooking.Image = null;
            this.btnAddNewBooking.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewBooking.Location = new System.Drawing.Point(342, 38);
            this.btnAddNewBooking.Name = "btnAddNewBooking";
            this.btnAddNewBooking.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.btnAddNewBooking.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewBooking.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewBooking.OnHoverImage = null;
            this.btnAddNewBooking.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewBooking.Radius = 10;
            this.btnAddNewBooking.Size = new System.Drawing.Size(142, 42);
            this.btnAddNewBooking.TabIndex = 7;
            this.btnAddNewBooking.Text = "Add New Booking";
            this.btnAddNewBooking.Click += new System.EventHandler(this.btnAddNewBooking_Click);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.AllowEmpty = true;
            this.txtSearchValue.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchValue.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchValue.BorderRadius = 12;
            this.txtSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.CustomValidationMessage = "Invalid Id";
            this.txtSearchValue.DefaultText = "";
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtSearchValue.Location = new System.Drawing.Point(140, 41);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearchValue.MaxLength = 50;
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.PlaceholderText = "";
            this.txtSearchValue.SelectedText = "";
            this.txtSearchValue.Size = new System.Drawing.Size(194, 36);
            this.txtSearchValue.TabIndex = 0;
            this.txtSearchValue.ValidateInputType = true;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            // 
            // ctrlBookingCard1
            // 
            this.ctrlBookingCard1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlBookingCard1.Location = new System.Drawing.Point(-1, 104);
            this.ctrlBookingCard1.Name = "ctrlBookingCard1";
            this.ctrlBookingCard1.Size = new System.Drawing.Size(972, 432);
            this.ctrlBookingCard1.TabIndex = 2;
            // 
            // ctrlBookingCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.ctrlBookingCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlBookingCardWithFilter";
            this.Size = new System.Drawing.Size(971, 536);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private CustomContorls.CustomTextBox txtSearchValue;
        private Guna.UI.WinForms.GunaButton btnAddNewBooking;
        private System.Windows.Forms.Label label1;
        private ctrlBookingCard ctrlBookingCard1;
    }
}
