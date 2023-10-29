using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Storee.Forms.AdminForm
{
    public partial class formPushlisherList : Form
    {
        public formPushlisherList()
        {
            InitializeComponent();
            for(int i = 1; i <= 40; i++)
            {
                dataGridView1.Rows.Add(i, "1", "Brand" + i);
            }
        }
    }
}
