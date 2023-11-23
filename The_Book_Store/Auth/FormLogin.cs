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
using The_Book_Store;
using System.Data.SqlClient;
using Book_Storee.Forms.ChasierForm;

namespace Book_Storee.Forms.Auth
{
    public partial class FormLogin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public FormLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string role = "";
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("select * from tblUser where username = @username and password = @password ", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) {

                    found = true;
                    role = dr["role"].ToString();
                }
                else { found = false; }

                if (found)
                {

                    if (role == "Cashier")
                    {
                        this.Hide();
                      /*  formCashier form = new formCashier(this);*/
                    /*    form.lblUsername.Text = txtUsername.Text;
                        form.lblRole.Text = role;
                        form.ShowDialog();*/
                    }
                    else if (role == "Admin")
                    {
                        this.Hide();
                        formAdmin form = new formAdmin();
                        form.ShowDialog();

                    }
                }else
                {
                    MessageBox.Show("wrong credential!");
                }
            dr.Close();
            cn.Close();

       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
