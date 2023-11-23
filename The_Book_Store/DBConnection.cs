using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Book_Store
{
     class DBConnection
    {
        public String MyConnection()
        {
            string con = "Data Source=SOKUNPANHA\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
            return con;
        }
    }
}
