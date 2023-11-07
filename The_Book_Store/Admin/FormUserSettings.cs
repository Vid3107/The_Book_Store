using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Book_Store.Admin
{
    public partial class FormUserSettings : Form
    {
        public FormUserSettings()
        {
            InitializeComponent();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateAccount formChangePassword = new FormCreateAccount();
            formChangePassword.FormClosed += (s, args) => this.Show();
            formChangePassword.Show();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.FormClosed += (s, args) => this.Show();
            formChangePassword.Show();
        }

        private void BtnActivateDeactivate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormActivateDeactivate formActivateDeactivate = new FormActivateDeactivate();
            formActivateDeactivate.FormClosed += (s, args) => this.Show();
            formActivateDeactivate.Show();
        }
    }
}
