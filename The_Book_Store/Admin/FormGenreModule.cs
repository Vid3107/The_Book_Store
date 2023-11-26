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
    public partial class FormGenreModule : Form
    {
        private bool isNew;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private FormGenreList formGenreList;
        public FormGenreModule(FormGenreList formGenreList, bool isNew)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.formGenreList = formGenreList;
            this.isNew = isNew;
        }
        private void ClearTextBox()
        {
            textBoxGenre.Clear();
            textBoxGenre.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (textBoxGenre.Text != "")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to save this genre?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblGenre(Genre) VALUES(@genre)", cn);
                        cm.Parameters.AddWithValue("@genre", textBoxGenre.Text);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Genre has been saved successfully!");
                        ClearTextBox();
                        formGenreList.LoadRecords();
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to upate this publisher?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblGenre SET genre = @genre WHERE id LIKE '" + labelID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@genre", textBoxGenre.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Genre has been successfully updated!");
                    ClearTextBox();
                    formGenreList.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormGenreModule_Load(object sender, EventArgs e)
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
