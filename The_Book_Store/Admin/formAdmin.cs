using Book_Storee.Forms.AdminForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Storee
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            formPushlisherList formPushlisherList = new formPushlisherList();
            formPushlisherList.TopLevel = false;
            panelAdmin.Controls.Add(formPushlisherList);
            formPushlisherList.BringToFront();
            formPushlisherList.Show();
        }
    }
}
