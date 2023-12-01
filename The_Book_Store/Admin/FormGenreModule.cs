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
            if (!string.IsNullOrWhiteSpace(textBoxGenre.Text))
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT COUNT(*) FROM tblGenre WHERE Genre = @genre", cn);
                    cm.Parameters.AddWithValue("@genre", textBoxGenre.Text);
                    int count = (int)cm.ExecuteScalar();
                    cn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("This genre already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Genre name must be filled!", "Failed Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxGenre.Text))
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT COUNT(*) FROM tblGenre WHERE Genre = @genre", cn);
                    cm.Parameters.AddWithValue("@genre", textBoxGenre.Text);
                    int count = (int)cm.ExecuteScalar();
                    cn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("This genre already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Genre name must be filled!", "Failed Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBoxGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (isNew)
                {
                    BtnSave.PerformClick();
                }
                else
                {
                    BtnUpdate.PerformClick();
                }
            }
        }
    }
}
