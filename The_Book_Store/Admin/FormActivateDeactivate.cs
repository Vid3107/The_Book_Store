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
    public partial class FormActivateDeactivate : Form
    {
        //string connectionString = @"Data Source=ViD3107\SQLEXPRESS;Initial Catalog=POS_BOOK;Integrated Security=True";
        DBConnection connectionString = new DBConnection();
        
        public FormActivateDeactivate()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            textBoxUsername.Clear();
        }
        private bool UpdateAccountStatus(string username, bool isActive)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString.MyConnection()))
                {
                    conn.Open();
                    string updateQuery = "UPDATE tblUser SET isActive = @IsActive WHERE username = @Username";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IsActive", isActive);
                        cmd.Parameters.AddWithValue("@Username", username);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            bool isActive = checkBoxIsActive.Checked;
            bool updatedStatus = UpdateAccountStatus(username, isActive);   
            if (updatedStatus)
            {
                MessageBox.Show($"Account {username} is now {(isActive ? "activated" : "deactivated")}.");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Failed to update account status.");
            }
            
        }
    }
}
