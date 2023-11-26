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

namespace The_Book_Store.Admin
{
    public partial class FormManageBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader sqlDataReader = null;
        public FormManageBook()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }

        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            FormProductModule formProductModule = new FormProductModule(this, true);
            formProductModule.LoadGenre();
            formProductModule.LoadPublisher();
            formProductModule.ShowDialog();
        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridViewManageBook.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.bookCode, p.bookTitle, p.bookAuthor, b.publisher, c.genre, p.price, p.qty FROM tblBook AS p INNER JOIN tblPublisher AS b ON b.id = p.publisherID INNER JOIN tblGenre AS c ON c.id = p.genreID WHERE p.bookTitle LIKE '" + textBoxSearch.Text + "%'", cn);
            sqlDataReader = cm.ExecuteReader();
            while(sqlDataReader.Read())
            {
                i++;
                dataGridViewManageBook.Rows.Add(i, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), sqlDataReader[5].ToString(), sqlDataReader[6].ToString());
            }
            cn.Close();
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void dataGridViewManageBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewManageBook.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormProductModule formProductModule = new FormProductModule(this, false);
                formProductModule.LoadGenre();
                formProductModule.LoadPublisher();
                formProductModule.textBoxBookCode.Text = dataGridViewManageBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                formProductModule.textBoxTitle.Text = dataGridViewManageBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                formProductModule.textBoxAuthor.Text = dataGridViewManageBook.Rows[e.RowIndex].Cells[3].Value.ToString();
                formProductModule.comboBoxPublisher.SelectedItem = dataGridViewManageBook.Rows[e.RowIndex].Cells[4].Value.ToString();
                formProductModule.comboBoxGenre.SelectedItem = dataGridViewManageBook.Rows[e.RowIndex].Cells[5].Value.ToString();
             
                formProductModule.textBoxPrice.Text = dataGridViewManageBook.Rows[e.RowIndex].Cells[6].Value.ToString();
                formProductModule.textBoxQty.Text = dataGridViewManageBook.Rows[e.RowIndex].Cells[7].Value.ToString();
                formProductModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblBook WHERE bookCode like '" + dataGridViewManageBook.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadRecords();
                }
            }
        }
    }
}
