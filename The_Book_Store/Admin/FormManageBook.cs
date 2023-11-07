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
    public partial class FormManageBook : Form
    {
        public FormManageBook()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                dataGridView1.Rows.Add(i, i*2, "The Leader In You" + i, "MindBook", "Non-Fiction", i*9/2, i*3);
            }
        }
    }
}
