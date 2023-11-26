namespace The_Book_Store.Admin
{
    partial class FormUserSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnActivateDeactivate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 95);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Settings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateAccount.BackColor = System.Drawing.Color.White;
            this.BtnCreateAccount.FlatAppearance.BorderSize = 0;
            this.BtnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.BtnCreateAccount.Image = ((System.Drawing.Image)(resources.GetObject("BtnCreateAccount.Image")));
            this.BtnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreateAccount.Location = new System.Drawing.Point(48, 47);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCreateAccount.Size = new System.Drawing.Size(240, 51);
            this.BtnCreateAccount.TabIndex = 13;
            this.BtnCreateAccount.Text = "        Create Account";
            this.BtnCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreateAccount.UseVisualStyleBackColor = false;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangePassword.FlatAppearance.BorderSize = 0;
            this.BtnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.BtnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("BtnChangePassword.Image")));
            this.BtnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChangePassword.Location = new System.Drawing.Point(375, 47);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnChangePassword.Size = new System.Drawing.Size(270, 51);
            this.BtnChangePassword.TabIndex = 13;
            this.BtnChangePassword.Text = "        Change Password";
            this.BtnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // BtnActivateDeactivate
            // 
            this.BtnActivateDeactivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActivateDeactivate.FlatAppearance.BorderSize = 0;
            this.BtnActivateDeactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivateDeactivate.ForeColor = System.Drawing.Color.Black;
            this.BtnActivateDeactivate.Image = ((System.Drawing.Image)(resources.GetObject("BtnActivateDeactivate.Image")));
            this.BtnActivateDeactivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActivateDeactivate.Location = new System.Drawing.Point(179, 141);
            this.BtnActivateDeactivate.Name = "BtnActivateDeactivate";
            this.BtnActivateDeactivate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnActivateDeactivate.Size = new System.Drawing.Size(342, 51);
            this.BtnActivateDeactivate.TabIndex = 13;
            this.BtnActivateDeactivate.Text = "        Activate/Deactivate Account";
            this.BtnActivateDeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActivateDeactivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActivateDeactivate.UseVisualStyleBackColor = true;
            this.BtnActivateDeactivate.Click += new System.EventHandler(this.BtnActivateDeactivate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnChangePassword);
            this.panel2.Controls.Add(this.BtnActivateDeactivate);
            this.panel2.Controls.Add(this.BtnCreateAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 269);
            this.panel2.TabIndex = 13;
            // 
            // FormUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Button BtnActivateDeactivate;
        private System.Windows.Forms.Panel panel2;
    }
}