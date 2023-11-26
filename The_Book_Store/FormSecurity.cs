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
using The_Book_Store.Admin;

namespace The_Book_Store
{
    
    public partial class FormSecurity : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public FormSecurity()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _roles = "", _name = "";
            bool isAccountActive = false;
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("select * from tblUser where username=@username and password=@password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr=cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _roles = dr["role"].ToString();
                    _name = dr["name"].ToString();
                    isAccountActive = Convert.ToBoolean(dr["isActive"]);
                }
                else
                {
                    found = false;
                }
                dr.Close();                
                cn.Close();
                if (found && isAccountActive)
                {
                    if (_roles == "Cashier")
                    {
                        MessageBox.Show("Welcome "  + _name + "!","Access Grand", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        this.Hide();
                        FormCashier fcs = new FormCashier();
                        fcs.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + "!","Access Grand", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        this.Hide();
                        FormAdminNew fan = new FormAdminNew();
                        fan.ShowDialog();
                    }
                }
                else if (found && !isAccountActive)
                {
                    MessageBox.Show("Your account is deactivated. Please contact an administrator.", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Access Denied",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex) {
                cn.Close();
                MessageBox.Show(ex.Message, "Errorjjj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
