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
    public partial class FormInputQtyForBrowseProduct : Form
    {
        public bool OkButtonClicked { get; private set; }
        public FormInputQtyForBrowseProduct()
        {
            InitializeComponent();
        }
         
        private void FormInputQtyForBrowseProduct_Load(object sender, EventArgs e)
        {

        }

        private void FormInputQtyForBrowseProduct_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnOK.PerformClick();
                OkButtonClicked = true;
            }else if (e.KeyChar == (char)Keys.Escape)
            {
                BtnCancel.PerformClick();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            OkButtonClicked = true;
            this.Close();
        }
    }
}
