namespace CarRental.Controls
{
    partial class ctrlTransactionCardWithFilter
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
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.ctrlTransactionCard1 = new CarRental.Controls.ctrlTransactionCard();
            this.cbFilter = new Guna.UI.WinForms.GunaComboBox();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.txtSearchValue);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(362, 94);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            this.txtSearchValue.Location = new System.Drawing.Point(155, 41);
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
            // ctrlTransactionCard1
            // 
            this.ctrlTransactionCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTransactionCard1.Location = new System.Drawing.Point(3, 104);
            this.ctrlTransactionCard1.Name = "ctrlTransactionCard1";
            this.ctrlTransactionCard1.Size = new System.Drawing.Size(935, 240);
            this.ctrlTransactionCard1.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BaseColor = System.Drawing.Color.White;
            this.cbFilter.BorderColor = System.Drawing.Color.Silver;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Transaction Id",
            "Booking Id",
            "Return Id"});
            this.cbFilter.Location = new System.Drawing.Point(6, 47);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilter.Radius = 12;
            this.cbFilter.Size = new System.Drawing.Size(142, 30);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 9;
            // 
            // ctrlTransactionCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ctrlTransactionCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlTransactionCardWithFilter";
            this.Size = new System.Drawing.Size(942, 346);
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private CustomContorls.CustomTextBox txtSearchValue;
        private ctrlTransactionCard ctrlTransactionCard1;
        private Guna.UI.WinForms.GunaComboBox cbFilter;
    }
}
