namespace The_Book_Store.Admin
{
    partial class FormGenreModule
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
            this.labelID = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(208, 38);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 22;
            this.labelID.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(399, 183);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(126, 45);
            this.BtnCancel.TabIndex = 19;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(246, 183);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(126, 45);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(93, 183);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 45);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenre.Location = new System.Drawing.Point(169, 84);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(408, 26);
            this.textBoxGenre.TabIndex = 18;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(50, 90);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(54, 20);
            this.labelGenre.TabIndex = 17;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGenreModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 328);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.MaximizeBox = false;
            this.Name = "FormGenreModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGenreModule";
            this.Load += new System.EventHandler(this.FormGenreModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
    }
}