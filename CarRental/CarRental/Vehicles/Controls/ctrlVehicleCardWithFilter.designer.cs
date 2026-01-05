namespace CarRental.Controls
{
    partial class ctrlVehicleCardWithFilter
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
            this.btnAddNewVehicle = new Guna.UI.WinForms.GunaButton();
            this.txtSearchValue = new CustomContorls.CustomTextBox();
            this.ctrlVehicleCard1 = new CarRental.Controls.ctrlVehicleCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.btnAddNewVehicle);
            this.gbFilter.Controls.Add(this.txtSearchValue);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(459, 94);
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
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vehicle Id";
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewVehicle.AnimationHoverSpeed = 0.07F;
            this.btnAddNewVehicle.AnimationSpeed = 0.03F;
            this.btnAddNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewVehicle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(185)))));
            this.btnAddNewVehicle.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewVehicle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewVehicle.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.Image = null;
            this.btnAddNewVehicle.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewVehicle.Location = new System.Drawing.Point(322, 35);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.btnAddNewVehicle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewVehicle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.OnHoverImage = null;
            this.btnAddNewVehicle.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewVehicle.Radius = 10;
            this.btnAddNewVehicle.Size = new System.Drawing.Size(131, 42);
            this.btnAddNewVehicle.TabIndex = 7;
            this.btnAddNewVehicle.Text = "Add New Vehicle";
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
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
            // ctrlVehicleCard1
            // 
            this.ctrlVehicleCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlVehicleCard1.Location = new System.Drawing.Point(4, 104);
            this.ctrlVehicleCard1.Name = "ctrlVehicleCard1";
            this.ctrlVehicleCard1.Size = new System.Drawing.Size(767, 275);
            this.ctrlVehicleCard1.TabIndex = 2;
            // 
            // ctrlVehicleCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.ctrlVehicleCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlVehicleCardWithFilter";
            this.Size = new System.Drawing.Size(786, 384);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private CustomContorls.CustomTextBox txtSearchValue;
        private Guna.UI.WinForms.GunaButton btnAddNewVehicle;
        private System.Windows.Forms.Label label1;
        private ctrlVehicleCard ctrlVehicleCard1;
    }
}
