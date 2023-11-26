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
    public partial class FormPublisherModule2 : Form
    {
        private bool isNew;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private FormManagePublisher formManagePublisher;
        public FormPublisherModule2(FormManagePublisher formManagePublisher, bool isNew)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.formManagePublisher = formManagePublisher;
            this.isNew = isNew;
        }
        private void ClearTextBox()
        {
            textBoxPublisher.Clear();
            textBoxPublisher.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this publisher?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblPublisher(Publisher) VALUES(@publisher)", cn);
                    cm.Parameters.AddWithValue("@publisher", textBoxPublisher.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Publisher has been saved successfully!");
                    ClearTextBox();
                    formManagePublisher.LoadRecords();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to upate this publisher?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPublisher SET publisher = @publisher WHERE id LIKE '" + labelID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@publisher", textBoxPublisher.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Publisher has been successfully updated!");
                    ClearTextBox();
                    formManagePublisher.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPublisherModule2_Load(object sender, EventArgs e)
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
