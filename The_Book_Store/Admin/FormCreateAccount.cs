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
using System.Xml.Linq;

namespace The_Book_Store.Admin
{
    public partial class FormCreateAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public FormCreateAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
        private void Clear()
        {
            textBoxName.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
            textBoxUsername.Clear();
            comboBoxRole.Items.Clear();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                {
                    MessageBox.Show("Password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("insert into tblUser (username, password, role, name) values(@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@username", textBoxUsername.Text);
                cm.Parameters.AddWithValue("@password", textBoxPassword.Text);
                cm.Parameters.AddWithValue("@role", comboBoxRole.Text);
                cm.Parameters.AddWithValue("@name", textBoxName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has been saved successfully!");
                Clear();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
