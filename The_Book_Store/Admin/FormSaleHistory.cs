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
    public partial class FormSaleHistory : Form
    {
        string connectionString = @"Data Source=ViD3107\SQLEXPRESS;Initial Catalog=POS_BOOK;Integrated Security=True";

        public FormSaleHistory()
        {
            InitializeComponent();
            PopulateCashiersComboBox();
        }
        
        private void PopulateCashiersComboBox()
        {
            List<string> cashiers = GetCashiers();
            cashiers.Insert(0, "All Cashiers");
            comboBoxCashiers.DataSource = cashiers;
        }
        
        private decimal GetTotalSalesByCashier(string cashierName)
        {
            decimal totalSales = 0;
            
            using (SqlConnection  conn = new SqlConnection(connectionString))
            {
                string query;
                SqlCommand command;
                if (cashierName == "All Cashiers")
                {
                    query = "SELECT SUM(total) AS TotalSales FROM tblCart WHERE status <> 'Pending'";
                    command = new SqlCommand(query, conn);
                }
                else
                {
                    query = "SELECT SUM(total) AS TotalSales FROM tblCart WHERE cashierName = @CashierName AND status <> 'Pending'";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@CashierName", cashierName);

                }
                try
                {
                    conn.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalSales = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return totalSales;
        }
        private List<string> GetCashiers()
        {
            List<string> cashiers = new List<string>();
            using (SqlConnection  con = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT cashierName FROM tblCart";
                SqlCommand command = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string cashier = reader["cashierName"].ToString();
                        cashiers.Add(cashier);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return cashiers;
        }
        private void UpdateTotalSales()
        {
            string selectedCashier = comboBoxCashiers.SelectedItem.ToString();
            decimal totalSales = GetTotalSalesByCashier(selectedCashier);
            textBoxTotalSales.Text = $"Total Sales: {totalSales:C2}";
        }
        private void comboBoxCashiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalSales();
            string selectedCashier = comboBoxCashiers.SelectedItem.ToString();
            LoadRecords(selectedCashier);
        }

        private void FormSaleHistory_Load(object sender, EventArgs e)
        {
            string selectedCashier = comboBoxCashiers.SelectedItem.ToString();

            UpdateTotalSales();
            LoadRecords(selectedCashier);
        }
        public void LoadRecords(string selectedCashier)
        {
            int i = 0;
            dataGridViewSaleHistory.Rows.Clear();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query;
                if (selectedCashier == "All Cashiers")
                {
                    query = "SELECT p.bookCode, p.bookTitle, p.bookAuthor, b.publisher, c.genre, cart.qty, p.price, cart.total " +
                    "FROM tblCart AS cart " +
                    "INNER JOIN tblBook AS p ON cart.pid = p.bookCode " +
                    "INNER JOIN tblPublisher AS b ON b.id = p.publisherID " +
                    "INNER JOIN tblGenre AS c ON c.id = p.genreID " +
                    "WHERE cart.status = 'Sold'";
                }
                else
                {
                    query = "SELECT p.bookCode, p.bookTitle, p.bookAuthor, b.publisher, c.genre, cart.qty, p.price, cart.total " +
                    "FROM tblCart AS cart " +
                    "INNER JOIN tblBook AS p ON cart.pid = p.bookCode " +
                    "INNER JOIN tblPublisher AS b ON b.id = p.publisherID " +
                    "INNER JOIN tblGenre AS c ON c.id = p.genreID " +
                    "WHERE cart.cashierName = @CashierName AND cart.status = 'Sold'";
                }
                SqlCommand cmd = new SqlCommand(query, cn);
                if (selectedCashier != "All Cashiers")
                {
                    cmd.Parameters.AddWithValue("@CashierName", selectedCashier);
                }

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    i++;
                    dataGridViewSaleHistory.Rows.Add(i, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), sqlDataReader[5].ToString(), sqlDataReader[6].ToString(), sqlDataReader[7].ToString());
                }
                sqlDataReader.Close();
                cn.Close();
            }
        }
    }
}
