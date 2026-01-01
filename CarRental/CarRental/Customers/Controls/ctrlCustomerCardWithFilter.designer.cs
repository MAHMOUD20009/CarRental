namespace CarRental.Controls
{
    partial class ctrlCustomerCardWithFilter
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
            this.cbFilter = new Guna.UI.WinForms.GunaComboBox();
            this.btnAddNewCustomer = new Guna.UI.WinForms.GunaButton();
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.ctrlCustomerCard1 = new CarRental.Controls.ctrlCustomerCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.btnAddNewCustomer);
            this.gbFilter.Controls.Add(this.txtSearchValue);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(535, 94);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            "Customer Id",
            "Person Id"});
            this.cbFilter.Location = new System.Drawing.Point(5, 43);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilter.Radius = 12;
            this.cbFilter.Size = new System.Drawing.Size(152, 30);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 8;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCustomer.AnimationHoverSpeed = 0.07F;
            this.btnAddNewCustomer.AnimationSpeed = 0.03F;
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNewCustomer.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Image = null;
            this.btnAddNewCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewCustomer.Location = new System.Drawing.Point(380, 38);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.btnAddNewCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.OnHoverImage = null;
            this.btnAddNewCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewCustomer.Radius = 10;
            this.btnAddNewCustomer.Size = new System.Drawing.Size(149, 42);
            this.btnAddNewCustomer.TabIndex = 7;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
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
            this.txtSearchValue.Location = new System.Drawing.Point(163, 43);
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
            // ctrlCustomerCard1
            // 
            this.ctrlCustomerCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlCustomerCard1.Location = new System.Drawing.Point(6, 89);
            this.ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            this.ctrlCustomerCard1.Size = new System.Drawing.Size(756, 421);
            this.ctrlCustomerCard1.TabIndex = 2;
            // 
            // ctrlCustomerCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlCustomerCard1);
            this.Name = "ctrlCustomerCardWithFilter";
            this.Size = new System.Drawing.Size(767, 507);
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI.WinForms.GunaButton btnAddNewCustomer;
        private Guna.UI.WinForms.GunaComboBox cbFilter;
        private ctrlCustomerCard ctrlCustomerCard1;
        private CustomContorls.CustomTextBox txtSearchValue;
    }
}
