using Book_Storee.Forms.ChasierForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Book_Store.Admin;

namespace The_Book_Store.Cashier
{
    public partial class FormSearchProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader sqlDataReader = null;
        formCashier formca = null;
        //private string pcode;
        //private double price;
        //private string transno;
        //private string name;
        public FormSearchProduct(formCashier formca)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadProduct();
            this.formca = formca;

        }
        public void LoadProduct()
        {
            int i = 0;
            dataGridViewSearchBook.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT bookCode, bookTitle, price,qty FROM tblBook WHERE bookTitle LIKE '" + textBoxSearch.Text + "%' ORDER BY bookTitle", cn);
            sqlDataReader = cm.ExecuteReader();
            while (sqlDataReader.Read())
            {
                i++;
                dataGridViewSearchBook.Rows.Add(i, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString());

            }
            sqlDataReader.Close();
            cn.Close();
        }
        private void dataGridViewSearchBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewSearchBook.Columns[e.ColumnIndex].Name;
            if (colName == "Add")
            {
                bool confirm = MessageBox.Show("Add this product to cart?", "Adding Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (confirm)
                {
                    string bookCode = dataGridViewSearchBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string price = dataGridViewSearchBook.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string transno = labelTransno.Text;
                    string name = formca.lblUsername.Text;
                    FormQty formQty = new FormQty(formca);
                    formQty.ProductDetails(bookCode, price, transno, name);
                    formQty.ShowDialog();
                }

            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
