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
    public partial class FormProductModule : Form
    {
        private bool isNew;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader sqlDataReader = null;
        private FormManageBook formManageBook;
        public FormProductModule(FormManageBook formManageBook, bool isNew)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.isNew = isNew;
            this.formManageBook = formManageBook;
        }
        public void LoadGenre()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT genre FROM tblGenre", cn);
                sqlDataReader = cm.ExecuteReader();
                comboBoxGenre.Items.Clear();
                while (sqlDataReader.Read())
                {
                    comboBoxGenre.Items.Add(sqlDataReader[0].ToString());
                }
                sqlDataReader.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadPublisher()
        {
            comboBoxPublisher.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT publisher FROM tblPublisher", cn);
            sqlDataReader = cm.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBoxPublisher.Items.Add(sqlDataReader[0].ToString());
            }
            sqlDataReader.Close();
            cn.Close();
        }
        public void Clear()
        {
            textBoxBookCode.Clear();
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            comboBoxGenre.Items.Clear();
            comboBoxPublisher.Items.Clear();
            textBoxPrice.Clear();
            textBoxQty.Clear();
            textBoxBookCode.Focus();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this book?", "Save Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string genreId = "", publisherId = "";
                    cn.Open();
                    cm = new SqlCommand("SELECT id from tblGenre WHERE genre like '" + comboBoxGenre.Text + "'", cn);
                    sqlDataReader = cm.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows)
                    {
                        genreId = sqlDataReader[0].ToString();
                    }
                    sqlDataReader.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("SELECT id from tblPublisher WHERE publisher like '" + comboBoxPublisher.Text + "'", cn);
                    sqlDataReader = cm.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows)
                    {
                        publisherId = sqlDataReader[0].ToString();
                    }
                    sqlDataReader.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBook(bookCode, bookTitle, bookAuthor, publisherID, genreID, price, qty) VALUES (@bookCode, @bookTitle, @bookAuthor, @publisherID, @genreID, @price, @qty)", cn);
                    cm.Parameters.AddWithValue("@bookCode", textBoxBookCode.Text);
                    cm.Parameters.AddWithValue("@bookTitle", textBoxTitle.Text);
                    cm.Parameters.AddWithValue("@bookAuthor", textBoxAuthor.Text);
                    cm.Parameters.AddWithValue("@publisherID", publisherId);
                    cm.Parameters.AddWithValue("@genreID", genreId); 
                    cm.Parameters.AddWithValue("@price", textBoxPrice.Text);
                    cm.Parameters.AddWithValue("@qty", textBoxQty.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Book has been saved successfully!");
                    Clear();
                    formManageBook.LoadRecords();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormProductModule_Load(object sender, EventArgs e)
        {
            if (isNew)
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnSave.Enabled = false;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this book?", "Update Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string genreId = "", publisherId = "";
                    cn.Open();
                    cm = new SqlCommand("SELECT id from tblGenre WHERE genre like '" + comboBoxGenre.Text + "'", cn);
                    sqlDataReader = cm.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows)
                    {
                        genreId = sqlDataReader[0].ToString();
                    }
                    sqlDataReader.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("SELECT id from tblPublisher WHERE publisher like '" + comboBoxPublisher.Text + "'", cn);
                    sqlDataReader = cm.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows)
                    {
                        publisherId = sqlDataReader[0].ToString();
                    }
                    sqlDataReader.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblBook SET bookTitle = @bookTitle, bookAuthor = @bookAuthor, publisherID=@publisherID, genreID=@genreID, price=@price, qty=@qty WHERE bookCode LIKE @bookCode", cn);
                    cm.Parameters.AddWithValue("@bookCode", textBoxBookCode.Text);
                    cm.Parameters.AddWithValue("@bookTitle", textBoxTitle.Text);
                    cm.Parameters.AddWithValue("@bookAuthor", textBoxAuthor.Text);
                    cm.Parameters.AddWithValue("@publisherID", publisherId);
                    cm.Parameters.AddWithValue("@genreID", genreId);
                    cm.Parameters.AddWithValue("@price", textBoxPrice.Text);
                    cm.Parameters.AddWithValue("@qty", textBoxQty.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Book has been updated successfully!");
                    Clear();
                    formManageBook.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                BtnSave.PerformClick();
            }
        }
    }
}
