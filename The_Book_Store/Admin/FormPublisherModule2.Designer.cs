namespace The_Book_Store.Admin
{
    partial class FormPublisherModule2
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
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(242, 21);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 16;
            this.labelID.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(386, 166);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(126, 45);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(233, 166);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(126, 45);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(80, 166);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 45);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisher.Location = new System.Drawing.Point(156, 67);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(408, 26);
            this.textBoxPublisher.TabIndex = 12;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.Location = new System.Drawing.Point(37, 73);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(74, 20);
            this.labelPublisher.TabIndex = 11;
            this.labelPublisher.Text = "Publisher";
            this.labelPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPublisherModule2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 276);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.labelPublisher);
            this.MaximizeBox = false;
            this.Name = "FormPublisherModule2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPublisherModule2";
            this.Load += new System.EventHandler(this.FormPublisherModule2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label labelPublisher;
    }
}