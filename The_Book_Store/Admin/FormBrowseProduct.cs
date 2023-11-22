using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Book_Store.Admin
{
    public partial class FormBrowseProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader sqlDataReader = null;
        FormStockIn formStockIn;
        private bool okButtonClicked = false;
        public FormBrowseProduct(FormStockIn formStockIn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.formStockIn = formStockIn; 
        }

        public void LoadProduct()
        {
            int i = 0;
            dataGridViewBrowseProduct.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT bookCode, bookTitle, price,qty FROM tblBook WHERE bookTitle LIKE '" + textBoxSearch.Text + "%' ORDER BY bookTitle", cn);
            sqlDataReader = cm.ExecuteReader();
            while(sqlDataReader.Read())
            {
                i++;
                dataGridViewBrowseProduct.Rows.Add(i, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString());

            }
            sqlDataReader.Close();
            cn.Close();
        }

        private void dataGridViewBrowseProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewBrowseProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Add")
            {
                if (formStockIn.textBoxRefNo.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Reference number", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    formStockIn.textBoxRefNo.Focus();
                    return;
                }
                if (formStockIn.textBoxStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Please enter stock in by", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    formStockIn.textBoxStockInBy.Focus();
                    return;
                }
                FormInputQtyForBrowseProduct inputQty = new FormInputQtyForBrowseProduct();
                inputQty.ShowDialog();
                if (inputQty.OkButtonClicked)
                {
                    int currentQty = int.Parse(dataGridViewBrowseProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
                    int incomingQty = int.Parse(inputQty.textBoxQty.Text);
                    int totalQty = currentQty + incomingQty;
                    if (MessageBox.Show("Add this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            cn.Open();
                            cm = new SqlCommand("INSERT INTO tblStockIn (refNo, bookCode, qty, stockInDate, stockInBy) VALUES (@refNo, @bookCode, @qty, @stockInDate, @stockInBy)", cn);
                            cm.Parameters.AddWithValue("@refNo", formStockIn.textBoxRefNo.Text);
                            cm.Parameters.AddWithValue("@qty", totalQty);
                            cm.Parameters.AddWithValue("@bookCode", dataGridViewBrowseProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                            cm.Parameters.AddWithValue("@stockInDate", formStockIn.dateTimePicker1.Value);
                            cm.Parameters.AddWithValue("@stockInBy", formStockIn.textBoxStockInBy.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Successfully added!", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formStockIn.LoadStockIn();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            cn.Close();
                        }
                    }
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
