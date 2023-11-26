using Book_Storee.Forms.ChasierForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Book_Store.Admin;

namespace The_Book_Store.Cashier
{
    public partial class FormQty : Form
    {


        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        formCashier formPos;
        private string pcode;
        private double price;
        private string transno;
        private string name;
          
        public FormQty(formCashier formc)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            formPos = formc;
        }
        public void ProductDetails(string pcode, string price, string transno, string name)
        {
            this.pcode = pcode;
            this.price = double.Parse(price);
            this.transno = transno;
            this.name = name;
        }
        private void FormPos_Load(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (e.KeyChar == 13 && txtQty.Text != string.Empty)
            {
                cn.Open();
                cm = new SqlCommand("insert into tblCart (transno, pid, price, qty, sdate, cashierName) values(@transno, @pid, @price, @qty, @sdate, @cashierName)", cn);
                cm.Parameters.AddWithValue("@transno", transno);
                cm.Parameters.AddWithValue("@pid", pcode);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashierName", name);
                cm.ExecuteNonQuery();
                txtQty.Text = String.Empty;
                cn.Close();
                formPos.loadCart();
                this.Close();
            }
        }
    }
}
