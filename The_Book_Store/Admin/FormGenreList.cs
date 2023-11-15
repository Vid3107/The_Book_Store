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
using MySql.Data.MySqlClient;

namespace The_Book_Store.Admin
{
    public partial class FormGenreList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader mySqlDataReader = null;
        public FormGenreList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
        }

        private void BtnNewGenre_Click(object sender, EventArgs e)
        {
            FormGenreModule formGenreModule = new FormGenreModule(this, true);
            formGenreModule.ShowDialog();
        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridViewGenre.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblGenre WHERE genre LIKE '" + textBoxSearch.Text + "%' ORDER BY genre", cn);
            mySqlDataReader = cm.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                i++;
                dataGridViewGenre.Rows.Add(i, mySqlDataReader["id"].ToString(), mySqlDataReader["genre"].ToString());
            }
            mySqlDataReader.Close();
            cn.Close();
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewGenre.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormGenreModule formGenreModule = new FormGenreModule(this, false);
                formGenreModule.labelID.Text = dataGridViewGenre[1, e.RowIndex].Value.ToString();
                formGenreModule.textBoxGenre.Text = dataGridViewGenre[2, e.RowIndex].Value.ToString();
                formGenreModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblPublisher WHERE id LIKE '" + dataGridViewGenre[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Publisher has been successfully deleted!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}
