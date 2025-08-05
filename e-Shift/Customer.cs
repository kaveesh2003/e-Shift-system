using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace e_Shift
{
    public class Customer
    {
        private IDatabase Database;

        // Properties for Customer table
        public int UserID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string NIC { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        //Default constructor
        public Customer() { }

        public Customer(int userId, string username)
        {
            this.UserID = userId;
            this.Username = username;
        }

        // Simulate profile completeness check (you can update this to query DB)
        public bool IsProfileComplete()
        {
            // Ideally, check DB fields like Mobile, City, Age etc.
            return Data.IsCustomerProfileComplete(UserID);
        }

        //Save customer details ------------------------------------------------------------------------
        public void SaveCustomer(Customer customer)
        {
            // Check for duplicate NIC or Email
            string checkSql = $"SELECT COUNT(*) FROM Customers WHERE NIC = '{customer.NIC}' OR Email = '{customer.Email}'";

            using (SqlConnection con = new SqlConnection(Data.cs))
            using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
            {
                con.Open();
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("A customer with this NIC or Email already exists.", "Duplicate Entry");
                    return; // Stop further execution
                }
            }

            string sql = "INSERT INTO Customers (UserID, FullName, NIC, Email, Mobile, Address, City, Age) VALUES (" +
                 $"'{customer.UserID}', '{customer.FullName}', '{customer.NIC}', '{customer.Email}', '{customer.Mobile}', " +
                 $"'{customer.Address}', '{customer.City}', {customer.Age})";

            Data.ExecuteQuery(sql);
        }

        public void LoadCustomerDetails()
        {
            using (SqlConnection con = new SqlConnection(Data.cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT FullName, NIC, Email, Mobile, Address, City, Age FROM Customers WHERE UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", this.UserID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.FullName = reader["FullName"].ToString();
                        this.NIC = reader["NIC"].ToString();
                        this.Email = reader["Email"].ToString();
                        this.Mobile = reader["Mobile"].ToString();
                        this.Address = reader["Address"].ToString();
                        this.City = reader["City"].ToString();
                        this.Age = Convert.ToInt32(reader["Age"]);
                    }
                }
            }
        }

    }

    public interface IDatabase
    {
        void ExecuteQuery(string query);
    }
}
