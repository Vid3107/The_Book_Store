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
    public partial class FormGenreList : Form
    {
        public FormGenreList()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                dataGridView1.Rows.Add(i, "1", "Fiction");
            }
        }
    }
}
