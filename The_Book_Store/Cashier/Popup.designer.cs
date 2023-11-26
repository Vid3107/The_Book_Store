namespace The_Book_Store.Cashier.Popup
{
    partial class Popup
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
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.txtQty = new Krypton.Toolkit.KryptonTextBox();
            this.btnSave_order = new Krypton.Toolkit.KryptonButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom2;
            this.kryptonTextBox1.Location = new System.Drawing.Point(90, 105);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(188, 0);
            this.kryptonTextBox1.TabIndex = 0;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(108, 81);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(159, 47);
            this.txtQty.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.TabIndex = 1;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // btnSave_order
            // 
            this.btnSave_order.CornerRoundingRadius = -1F;
            this.btnSave_order.Location = new System.Drawing.Point(269, 208);
            this.btnSave_order.Name = "btnSave_order";
            this.btnSave_order.Size = new System.Drawing.Size(90, 25);
            this.btnSave_order.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_order.TabIndex = 2;
            this.btnSave_order.Values.Text = "Save";
            this.btnSave_order.Click += new System.EventHandler(this.btnSave_order_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(78, 208);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 206);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(45, 24);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Total";
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 294);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnSave_order);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.kryptonTextBox1);
            this.Name = "Popup";
            this.Text = "Popup";
            this.Load += new System.EventHandler(this.Popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox txtQty;
        private Krypton.Toolkit.KryptonButton btnSave_order;
        private System.Windows.Forms.TextBox txtTotal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}