using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using The_Book_Store;
using The_Book_Store.Cashier;
using Book_Storee.Forms.Auth;

namespace Book_Storee.Forms.ChasierForm
{

    public partial class formCashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        FormLogin form;
        public formCashier()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formCashier_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            GetTransNo();
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }
        public void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("select top 1 transno from tblCart where transno like '" + sdate + "%' order by id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbl_transactionNo.Text = sdate + (count + 1);

                }
                else
                {
                    transno = sdate + "1001";
                    lbl_transactionNo.Text = transno;


                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void loadCart()
        {
            try
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                double total = 0;
                cn.Open();
                cm = new SqlCommand("select c.id, c.pid,p.bookCode, p.bookTitle, c.price, c.qty, c.total  from tblCart as c inner join tblBook as p on c.pid = p.bookCode where transno like '" + lbl_transactionNo.Text +"' and c.status like 'Pending'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += double.Parse(dr["total"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(),dr["bookCode"].ToString(), dr["bookTitle"].ToString(), dr["qty"].ToString(), dr["price"].ToString(), dr["total"].ToString());

                }

                lblSubTotal.Text = total.ToString();
                lblTotal.Text = total.ToString("#,##0");
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty) { return; }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("select * from tblBook where bookCode like '"+txtSearch.Text+"'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if( dr.HasRows) {
                        FormQty formPos= new FormQty(this);
                        formPos.ProductDetails(dr["bookCode"].ToString(), dr["price"].ToString(), lbl_transactionNo.Text);
                        dr.Close();
                        cn.Close() ;
                        formPos.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        cn.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?","Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblCart where id like '"+ dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"'", cn);
                    cm.ExecuteNonQuery();   
                    cn.Close();
                    MessageBox.Show("Item has successfully removed!");
                    loadCart();
                }
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            formSettle form = new formSettle(this);
            form.txtSale.Text = lblTotal.Text;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Hide();
            form.ShowDialog();

        }
    }
}