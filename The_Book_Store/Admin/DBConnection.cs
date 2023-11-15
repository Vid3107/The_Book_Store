using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Book_Store.Admin
{
    public class DBConnection
    {
        public string MyConnection ()
        {
            string con = @"Data Source=ViD3107\SQLEXPRESS;Initial Catalog=POS_BOOK;Integrated Security=True";
            //MySQL Connection String : string con = "SERVER=52.76.27.242;PORT=3306;DATABASE=sql12660867;UID=sql12660867;PASSWORD=YJt8MxxP15";
            return con;
        }
    }
}
