namespace CarRental.Controls
{
    partial class ctrlPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new Guna.UI.WinForms.GunaButton();
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.ctrlPersonCard1 = new CarRental.Controls.ctrlPersonCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.btnAddNewPerson);
            this.gbFilter.Controls.Add(this.txtSearchValue);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(489, 94);
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
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Person Id";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.AnimationHoverSpeed = 0.07F;
            this.btnAddNewPerson.AnimationSpeed = 0.03F;
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(185)))));
            this.btnAddNewPerson.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewPerson.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.Image")));
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewPerson.Location = new System.Drawing.Point(315, 37);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.btnAddNewPerson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.OnHoverImage = null;
            this.btnAddNewPerson.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.Radius = 10;
            this.btnAddNewPerson.Size = new System.Drawing.Size(168, 42);
            this.btnAddNewPerson.TabIndex = 7;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
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
            this.txtSearchValue.Location = new System.Drawing.Point(111, 40);
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
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(2, 104);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(748, 194);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(753, 299);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CarRental.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private CustomContorls.CustomTextBox txtSearchValue;
        private Guna.UI.WinForms.GunaButton btnAddNewPerson;
        private System.Windows.Forms.Label label1;
    }
}
