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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            textBoxUsername.Clear();
            textBoxOldPassword.Clear();
            textBoxNewPassword.Clear();
            textBoxConfirmPassword.Clear();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string oldPassword = textBoxOldPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            if (newPassword == confirmPassword)
            {
                PasswordChange passwordChanger = new PasswordChange();
                bool passwordChanged = passwordChanger.ChangePassword(username, oldPassword, newPassword);
                if (passwordChanged)
                {
                    MessageBox.Show("Password changed successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to change password. Please check your credentials.", "User Settings",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("New password and confirm password do not match.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
