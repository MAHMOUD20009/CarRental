namespace CarRental.Users
{
    partial class frmUsersList
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
            dgvDataList.CellDoubleClick += dgvUsersList_CellDoubleClick;
        }

        private void InitializeFilerComboBox()
        {
            this.cbFilter.Items.AddRange(new object[] {
            "User ID",
            "Person ID",
            "User Name",
            "Name",
            "Is Active"});
        }

        private void InitializeContextMenuStrip()
        {
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserDetailsToolStripMenuItem,
            this.ToolStripSeparator1,
            this.RefreshToolStripMenuItem,
            this.ToolStripSeparator2,
            this.addNewUserToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIsActive = new Guna.UI.WinForms.GunaComboBox();
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
            this.btnAddNewRecord.Image = global::CarRental.Properties.Resources.AddNewUser32;
            this.btnAddNewRecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.ImageSize = new System.Drawing.Size(23, 23);
            this.btnAddNewRecord.Location = new System.Drawing.Point(766, 61);
            this.btnAddNewRecord.Size = new System.Drawing.Size(159, 38);
            this.btnAddNewRecord.Text = "Add New User";
            this.btnAddNewRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRecord.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // UserDetailsToolStripMenuItem
            // 
            this.UserDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDetailsToolStripMenuItem.Image = global::CarRental.Properties.Resources.UserDetails;
            this.UserDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UserDetailsToolStripMenuItem.Name = "UserDetailsToolStripMenuItem";
            this.UserDetailsToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.UserDetailsToolStripMenuItem.Text = "User Details";
            this.UserDetailsToolStripMenuItem.Click += new System.EventHandler(this.UserDetailsToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 6);
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
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserToolStripMenuItem.Image = global::CarRental.Properties.Resources.AddNewUser24;
            this.addNewUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripMenuItem.Image = global::CarRental.Properties.Resources.UpdateUser;
            this.updateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::CarRental.Properties.Resources.Delete;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.BaseColor = System.Drawing.Color.White;
            this.cbIsActive.BorderColor = System.Drawing.Color.Silver;
            this.cbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FocusedColor = System.Drawing.Color.Empty;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.ForeColor = System.Drawing.Color.Black;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.cbIsActive.Location = new System.Drawing.Point(302, 70);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbIsActive.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbIsActive.Radius = 12;
            this.cbIsActive.Size = new System.Drawing.Size(166, 30);
            this.cbIsActive.StartIndex = 0;
            this.cbIsActive.TabIndex = 5;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.cbIsActive);
            this.Name = "frmUsersList";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            this.Controls.SetChildIndex(this.cbIsActive, 0);
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
        private System.Windows.Forms.ToolStripMenuItem UserDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI.WinForms.GunaComboBox cbIsActive;
    }
}