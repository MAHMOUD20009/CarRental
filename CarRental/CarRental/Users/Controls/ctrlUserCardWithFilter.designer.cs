namespace CarRental.Controls
{
    partial class ctrlUserCardWithFilter
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
            this.btnAddNewUser = new Guna.UI.WinForms.GunaButton();
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.ctrlUserCard1 = new CarRental.Controls.ctrlUserCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.btnAddNewUser);
            this.gbFilter.Controls.Add(this.txtSearchValue);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(491, 94);
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
            "User Id",
            "Person Id",
            "User Name"});
            this.cbFilter.Location = new System.Drawing.Point(5, 43);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilter.Radius = 12;
            this.cbFilter.Size = new System.Drawing.Size(152, 30);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 8;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewUser.AnimationHoverSpeed = 0.07F;
            this.btnAddNewUser.AnimationSpeed = 0.03F;
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(185)))));
            this.btnAddNewUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Image = null;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewUser.Location = new System.Drawing.Point(368, 38);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.btnAddNewUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.OnHoverImage = null;
            this.btnAddNewUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Radius = 10;
            this.btnAddNewUser.Size = new System.Drawing.Size(117, 42);
            this.btnAddNewUser.TabIndex = 7;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.AllowEmpty = true;
            this.txtSearchValue.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchValue.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchValue.BorderRadius = 12;
            this.txtSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.CustomValidationMessage = null;
            this.txtSearchValue.DefaultText = "";
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txtSearchValue.InputType = CustomContorls.CustomTextBox.enInputType.NumberInput;
            this.txtSearchValue.Location = new System.Drawing.Point(164, 41);
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
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlUserCard1.Location = new System.Drawing.Point(4, 104);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(756, 425);
            this.ctrlUserCard1.TabIndex = 2;
            // 
            // ctrlUserCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlUserCardWithFilter";
            this.Size = new System.Drawing.Size(767, 533);
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI.WinForms.GunaButton btnAddNewUser;
        private Guna.UI.WinForms.GunaComboBox cbFilter;
        private ctrlUserCard ctrlUserCard1;
        private CustomContorls.CustomTextBox txtSearchValue;
    }
}
