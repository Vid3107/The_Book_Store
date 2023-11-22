using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Book_Store.Admin
{
    public partial class FormAdminNew : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public FormAdminNew()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            using (cn = new SqlConnection(dbcon.MyConnection()))
            {
                try
                {
                    cn.Open();
                    MessageBox.Show("Connected");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {

        }

        private void BtnManageBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageBook formManageBook = new FormManageBook();
            formManageBook.FormClosed += (s, args) => this.Show();
            formManageBook.LoadRecords();
            formManageBook.Show();
            
        }

        private void BtnManageGenre_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGenreList formGenreList = new FormGenreList();
            formGenreList.FormClosed += (s, args) => this.Show();
            formGenreList.Show();
        }

        private void BtnStockEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStockIn formStockIn = new FormStockIn();
            formStockIn.FormClosed += (s, args) => this.Show();
            formStockIn.Show();
        }

        private void BtnSaleHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSaleHistory formSaleHistory = new FormSaleHistory();
            formSaleHistory.FormClosed += (s, args) => this.Show();
            formSaleHistory.Show();
        }

        private void BtnManagePublisher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagePublisher formManagePublisher = new FormManagePublisher();
            formManagePublisher.FormClosed += (s, args) => this.Show();
            formManagePublisher.Show();
        }

        private void BtnManageUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUserSettings formUserSettings = new FormUserSettings();
            formUserSettings.FormClosed += (s, args) => this.Show();
            formUserSettings.Show();
        }

        private void FormUserSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormSecurity formSecurity = new FormSecurity();
            formSecurity.Show();
        }

        private void FormAdminNew_Load(object sender, EventArgs e)
        {

        }
    }
}
