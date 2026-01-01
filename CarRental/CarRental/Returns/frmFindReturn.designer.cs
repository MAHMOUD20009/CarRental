namespace CarRental.Returns
{
    partial class frmFindReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Guna.UI.WinForms.GunaControlBox btnMinimizeForm;
        private Guna.UI.WinForms.GunaControlBox btnCloseForm;
        private System.Windows.Forms.Label lblFormTitle;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnConfirm;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindReturn));
            this.btnMinimizeForm = new Guna.UI.WinForms.GunaControlBox();
            this.btnCloseForm = new Guna.UI.WinForms.GunaControlBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnConfirm = new Guna.UI.WinForms.GunaButton();
            this.ctrlReturnCardWithFilter1 = new CarRental.Controls.ctrlReturnCardWithFilter();
            this.SuspendLayout();
            // 
            // btnMinimizeForm
            // 
            resources.ApplyResources(this.btnMinimizeForm, "btnMinimizeForm");
            this.btnMinimizeForm.AnimationHoverSpeed = 0.07F;
            this.btnMinimizeForm.AnimationSpeed = 0.03F;
            this.btnMinimizeForm.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimizeForm.IconColor = System.Drawing.Color.White;
            this.btnMinimizeForm.IconSize = 15F;
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMinimizeForm.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimizeForm.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizeForm.Click += new System.EventHandler(this.btnMinimizeForm_Click);
            // 
            // btnCloseForm
            // 
            resources.ApplyResources(this.btnCloseForm, "btnCloseForm");
            this.btnCloseForm.AnimationHoverSpeed = 0.07F;
            this.btnCloseForm.AnimationSpeed = 0.03F;
            this.btnCloseForm.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.IconSize = 15F;
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCloseForm.OnHoverIconColor = System.Drawing.Color.White;
            this.btnCloseForm.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblFormTitle, "lblFormTitle");
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFindReturn_MouseDown);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.AnimationHoverSpeed = 0.07F;
            this.btnConfirm.AnimationSpeed = 0.03F;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirm.OnHoverImage = null;
            this.btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirm.Radius = 15;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ctrlReturnCardWithFilter1
            // 
            this.ctrlReturnCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlReturnCardWithFilter1.FilterEnabled = true;
            resources.ApplyResources(this.ctrlReturnCardWithFilter1, "ctrlReturnCardWithFilter1");
            this.ctrlReturnCardWithFilter1.Name = "ctrlReturnCardWithFilter1";
            this.ctrlReturnCardWithFilter1.OnReturnSelected += new System.Action<int>(this.ctrlReturnCardWithFilter1_OnReturnSelected);
            // 
            // frmFindReturn
            // 
            this.AcceptButton = this.btnConfirm;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.ctrlReturnCardWithFilter1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnMinimizeForm);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindReturn";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFindReturn_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlReturnCardWithFilter ctrlReturnCardWithFilter1;

    }
}