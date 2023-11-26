using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static The_Book_Store.Cashier.lookupForm.Search;
using static The_Book_Store.Cashier.Popup.Popup;
using The_Book_Store.Cashier.Popup;
using The_Book_Store.Admin;

namespace The_Book_Store.Cashier.lookupForm
{
    public partial class Search : Form
    {
        //public string Constring = "Data Source=DESKTOP-L1EMTF4\\SQLEXPRESS;Initial Catalog=Book_Store;Integrated Security=True";
        public class Books
        {
            //public int Id { get; set; }
            public string bookCode { get; set; }
            public string bookTitle { get; set; }
            public int publisherID { get; set; }

            public int genreID { get; set; }
            public double Price {  get; set; }
            public int Qty {  get; set; }

            public Books(string bookCode, string bookTitle, int publisherID, int genreID, double price, int qty)
            {
                //this.Id = id;
                this.bookCode = bookCode;
                this.bookTitle = bookTitle;
                this.publisherID = publisherID;
                this.genreID = genreID;
                this.Price = price;
                this.Qty = qty;
            }
        }

        public List<Books> books = new List<Books>();
        DBConnection dbcon = new DBConnection();

        public Search()
        {
            InitializeComponent();
            dgvSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvSearch_CellDoubleClick);

        }


        private void Search_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
            BindDataToDataGridView();
        }
        //Load Data 
        private void LoadDataFromDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbcon.MyConnection()))
                {
                    connection.Open();

                    // Replace 'YourQuery' with your actual SQL query to retrieve data from the database.
                    string query = "SELECT * FROM tblBook";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Books book = new Books(
                                    reader["bookCode"].ToString(),
                                    reader["bookTitle"].ToString(),
                                    Convert.ToInt32(reader["publisherID"]),
                                    Convert.ToInt32(reader["genreID"]),
                                    Convert.ToDouble(reader["price"]),
                                    Convert.ToInt32(reader["qty"])
                                );

                                books.Add(book);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from the database: " + ex.Message);
            }
        }

        //Binding 
        private void BindDataToDataGridView()
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = books;
                dgvSearch.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error binding data to DataGridView: " + ex.Message);
            }
        }

        //Click  Row 
        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookCode = dgvSearch.Rows[e.RowIndex].Cells["bookCode"].Value.ToString();
            string bookTitle = dgvSearch.Rows[e.RowIndex].Cells["bookTitle"].Value.ToString();
            double Price = Convert.ToDouble(dgvSearch.Rows[e.RowIndex].Cells["Price"].Value);
            int qty = Convert.ToInt32(dgvSearch.Rows[e.RowIndex].Cells["Qty"].Value);
            //string 
            //Form2 form2 = new Form2(bookCode, bookTitle);
            //form2.Show();
            //MessageBox.Show(bookTitle);
            The_Book_Store.Cashier.Popup.Popup pop = new Popup.Popup(Price);
            pop.Show();
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            //Console.WriteLine(searchText);
            textBox1.Text = searchText;
            if(searchText.Length > 0 )
            {
                var searchResults = books.Where(item => item.bookTitle.ToLower().Contains(searchText)).ToList();

                // Update the data source to show search results
                dgvSearch.DataSource = searchResults;
            }
            else
            {
               // BindingSource bs = new BindingSource();
                //bs.DataSource = st;
                dgvSearch.DataSource = books;
            }
            

        }
    }
}
