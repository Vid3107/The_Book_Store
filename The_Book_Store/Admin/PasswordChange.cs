using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Book_Store.Admin
{
    public class PasswordChange
    {
        string connectionString = @"Data Source=ViD3107\SQLEXPRESS;Initial Catalog=POS_BOOK;Integrated Security=True";
        public bool ChangePassword(string username, string currentPassword, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT password FROM tblUser WHERE username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["password"].ToString();
                            if (storedPassword == currentPassword)
                            {
                                reader.Close();
                                string updateQuery = "UPDATE tblUser SET password = @NewPassword WHERE username = @Username";
                                using (SqlCommand updateCommand  = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                                    updateCommand.Parameters.AddWithValue("@Username", username);
                                    int rowsAffected = updateCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }
    }
}
