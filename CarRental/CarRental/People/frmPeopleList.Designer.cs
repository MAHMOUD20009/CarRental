namespace CarRental.People
{
    partial class frmPeopleList
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

        private void InitializeInheritedControls()
        {
            InitializeDataGridView();
            InitializeFilerComboBox();
            InitializeContextMenuStrip();
        }

        private void InitializeDataGridView()
        {
            dgvDataList.CellDoubleClick += dgvPeopleList_CellDoubleClick;
        }

        private void InitializeFilerComboBox()
        {
            this.cbFilter.Items.AddRange(new object[]{
                "Person ID",
                "Name",
                "Gender",
                "Phone",
                "Email"
            });
        }

        private void InitializeContextMenuStrip()
        {
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personDetailsToolStripMenuItem,
            this.ToolStripSeparator1,
            this.RefreshToolStripMenuItem,
            this.ToolStripSeparator2,
            this.addNewPersonToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.ToolStripSeparator3,
            this.deleteToolStripMenuItem});
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterGender = new Guna.UI.WinForms.GunaComboBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.DTDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextPage
            // 
            this.btnNextPage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNextPage.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPreviousPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPreviousPage.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Image = global::CarRental.Properties.Resources.AddNewPerson32;
            this.btnAddNewRecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.ImageSize = new System.Drawing.Size(23, 23);
            this.btnAddNewRecord.Location = new System.Drawing.Point(753, 61);
            this.btnAddNewRecord.Size = new System.Drawing.Size(172, 38);
            this.btnAddNewRecord.Text = "Add New Person";
            this.btnAddNewRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // personDetailsToolStripMenuItem
            // 
            this.personDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDetailsToolStripMenuItem.Image = global::CarRental.Properties.Resources.PersonDateils24;
            this.personDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personDetailsToolStripMenuItem.Name = "personDetailsToolStripMenuItem";
            this.personDetailsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.personDetailsToolStripMenuItem.Text = "Person Details";
            this.personDetailsToolStripMenuItem.Click += new System.EventHandler(this.personDetailsToolStripMenuItem_Click);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshToolStripMenuItem.Image = global::CarRental.Properties.Resources.Refresh24;
            this.RefreshToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPersonToolStripMenuItem.Image = global::CarRental.Properties.Resources.AddNewPerson24;
            this.addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripMenuItem.Image = global::CarRental.Properties.Resources.EditPerson24;
            this.updateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::CarRental.Properties.Resources.DeletePerson24;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cbFilterGender
            // 
            this.cbFilterGender.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterGender.BaseColor = System.Drawing.Color.White;
            this.cbFilterGender.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterGender.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterGender.ForeColor = System.Drawing.Color.Black;
            this.cbFilterGender.FormattingEnabled = true;
            this.cbFilterGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbFilterGender.Location = new System.Drawing.Point(302, 69);
            this.cbFilterGender.Name = "cbFilterGender";
            this.cbFilterGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterGender.Radius = 12;
            this.cbFilterGender.Size = new System.Drawing.Size(166, 30);
            this.cbFilterGender.StartIndex = 0;
            this.cbFilterGender.TabIndex = 2;
            this.cbFilterGender.Visible = false;
            this.cbFilterGender.SelectedIndexChanged += new System.EventHandler(this.cbFilterGender_SelectedIndexChanged);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.cbFilterGender);
            this.Name = "frmPeopleList";
            this.Text = "People";
            this.Load += new System.EventHandler(this.frmPeopleList_Load);
            this.Controls.SetChildIndex(this.cbFilterGender, 0);
            this.Controls.SetChildIndex(this.lblRecords, 0);
            this.Controls.SetChildIndex(this.lblFilter, 0);
            this.Controls.SetChildIndex(this.cbFilter, 0);
            this.Controls.SetChildIndex(this.btnAddNewRecord, 0);
            this.Controls.SetChildIndex(this.btnNextPage, 0);
            this.Controls.SetChildIndex(this.btnPreviousPage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DTDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private Guna.UI.WinForms.GunaComboBox cbFilterGender;
        private System.Windows.Forms.ToolStripMenuItem personDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}