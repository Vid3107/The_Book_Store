using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Book_Store.Cashier.Popup
{
    public partial class Popup : Form
    {
        private string bookCode {  get; set; }
        private string bookTitle { get; set; } = string.Empty;
        private double Price {  get; set; }
        private int Qty { get; set; }

        //private int 

        public Popup(double price)
        {
            InitializeComponent();
            this.Price = price;
        }

        private void btnSave_order_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            //int num;
            //bool succ = int.TryParse(txtQty.Text, out num);
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                this.Qty = int.Parse(txtQty.Text);
                txtTotal.Text = (this.Qty * this.Price).ToString();
            }
            else
            {
                txtTotal.Text = "0.00";
            }
            
        }

        private void Popup_Load(object sender, EventArgs e)
        {
            txtQty.Text = "1";
            this.Qty = 1;
        }
    }
}
