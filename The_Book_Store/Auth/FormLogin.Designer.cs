namespace Book_Storee.Forms.Auth
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(151, 306);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(179, 34);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Book_Storee.Properties.Resources.close;
            this.pictureBox2.InitialImage = global::Book_Storee.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(428, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::Book_Storee.Properties.Resources.data_protection;
            this.pictureBox1.Location = new System.Drawing.Point(194, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 85);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.textPassword.CustomButton.FlatAppearance.BorderSize = 0;
            this.textPassword.CustomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.textPassword.CustomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Padding = new System.Windows.Forms.Padding(5);
            this.textPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.DisplayIcon = true;
            this.textPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textPassword.Icon = global::Book_Storee.Properties.Resources.password1;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(71, 233);
            this.textPassword.MaxLength = 32767;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.PromptText = "password";
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(332, 35);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSelectable = true;
            this.textPassword.WaterMark = "password";
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textUsername
            // 
            // 
            // 
            // 
            this.textUsername.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.textUsername.CustomButton.FlatAppearance.BorderSize = 0;
            this.textUsername.CustomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.textUsername.CustomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Padding = new System.Windows.Forms.Padding(50);
            this.textUsername.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.DisplayIcon = true;
            this.textUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textUsername.Icon = global::Book_Storee.Properties.Resources.user;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(71, 162);
            this.textUsername.MaxLength = 32767;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PromptText = "username";
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.ShortcutsEnabled = true;
            this.textUsername.Size = new System.Drawing.Size(332, 35);
            this.textUsername.TabIndex = 0;
            this.textUsername.UseSelectable = true;
            this.textUsername.WaterMark = "username";
            this.textUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(478, 511);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textUsername;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}