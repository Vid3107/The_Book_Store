namespace Book_Storee.Forms.ChasierForm
{
    partial class formCashier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_transaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cahsier_image = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label_transactionNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cahsier_image)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_transaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(834, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 779);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::The_Book_Store.Properties.Resources.search1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(0, 72);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(365, 72);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Search Product";
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(266, 671);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(74, 47);
            this.button15.TabIndex = 13;
            this.button15.Text = "00";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(266, 618);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(74, 47);
            this.button14.TabIndex = 12;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(266, 565);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 47);
            this.button11.TabIndex = 9;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(186, 565);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 47);
            this.button10.TabIndex = 8;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(186, 618);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 47);
            this.button7.TabIndex = 8;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 671);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(106, 565);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 47);
            this.button9.TabIndex = 7;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(106, 618);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 47);
            this.button6.TabIndex = 7;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 671);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(26, 565);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 47);
            this.button8.TabIndex = 5;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 618);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_transaction
            // 
            this.btn_transaction.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_transaction.FlatAppearance.BorderSize = 0;
            this.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaction.ForeColor = System.Drawing.Color.White;
            this.btn_transaction.Image = ((System.Drawing.Image)(resources.GetObject("btn_transaction.Image")));
            this.btn_transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transaction.Location = new System.Drawing.Point(0, 0);
            this.btn_transaction.Margin = new System.Windows.Forms.Padding(4);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(365, 72);
            this.btn_transaction.TabIndex = 5;
            this.btn_transaction.Text = "New Transaction";
            this.btn_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_transaction.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.cahsier_image);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 72);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cahsier_image
            // 
            this.cahsier_image.Image = ((System.Drawing.Image)(resources.GetObject("cahsier_image.Image")));
            this.cahsier_image.InitialImage = null;
            this.cahsier_image.Location = new System.Drawing.Point(4, 4);
            this.cahsier_image.Margin = new System.Windows.Forms.Padding(4);
            this.cahsier_image.Name = "cahsier_image";
            this.cahsier_image.Size = new System.Drawing.Size(63, 64);
            this.cahsier_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cahsier_image.TabIndex = 2;
            this.cahsier_image.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.label_transactionNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 80);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "0000000000";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(16, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(99, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Transaction No";
            // 
            // label_transactionNo
            // 
            this.label_transactionNo.AutoSize = true;
            this.label_transactionNo.Location = new System.Drawing.Point(156, 3);
            this.label_transactionNo.Name = "label_transactionNo";
            this.label_transactionNo.Size = new System.Drawing.Size(77, 16);
            this.label_transactionNo.TabIndex = 1;
            this.label_transactionNo.Text = "0000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnID,
            this.ColumnBrand,
            this.order_qty,
            this.order_price,
            this.order_total,
            this.ColumnDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 410);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "#";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Width = 125;
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 56;
            // 
            // ColumnBrand
            // 
            this.ColumnBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBrand.HeaderText = "Description";
            this.ColumnBrand.MinimumWidth = 6;
            this.ColumnBrand.Name = "ColumnBrand";
            // 
            // order_qty
            // 
            this.order_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.order_qty.HeaderText = "QTY";
            this.order_qty.MinimumWidth = 6;
            this.order_qty.Name = "order_qty";
            this.order_qty.Width = 76;
            // 
            // order_price
            // 
            this.order_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.order_price.HeaderText = "Price";
            this.order_price.MinimumWidth = 6;
            this.order_price.Name = "order_price";
            this.order_price.Width = 80;
            // 
            // order_total
            // 
            this.order_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.order_total.HeaderText = "Total";
            this.order_total.MinimumWidth = 6;
            this.order_total.Name = "order_total";
            this.order_total.Width = 78;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
            this.ColumnDelete.MinimumWidth = 6;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 565);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 214);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(834, 410);
            this.panel5.TabIndex = 6;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 720);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 208);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub-Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tax Base";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "VAT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Total Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Bar Code";
            // 
            // formCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 779);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "formCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cahsier_image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cahsier_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_transactionNo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_total;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}