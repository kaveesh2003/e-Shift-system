using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace e_Shift
{
    internal class Data
    {
        // Connection string from App.config
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();


        //SIGN UP AND LOGIN ---------------------------------------------------------------------------

        //Execute query for signup and login
        public static void ExecuteQuery(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
        }

        //Execute parameterized SQL SELECT Queries and return the result as a DataTable
        public static DataTable GetDataTable(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddRange(parameters);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    return table;
                }
            }
        }

        //LOGGING AND LOADING THE DASHBOARD ------------------------------------------------------------
        public static bool IsCustomerProfileComplete(int userId)
        {
            string sql = "SELECT NIC, Email, Mobile, City FROM Customers WHERE UserID = @UserID";

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nic = reader["NIC"]?.ToString();
                    string email = reader["Email"]?.ToString();
                    string mobile = reader["Mobile"]?.ToString();
                    string city = reader["City"]?.ToString();

                    return !string.IsNullOrWhiteSpace(nic) &&
                           !string.IsNullOrWhiteSpace(email) &&
                           !string.IsNullOrWhiteSpace(mobile) &&
                           !string.IsNullOrWhiteSpace(city);
                }

                return false;
            }
        }


        //Customer registration process -----------------------------------------------------------------

        //ExecuteQuery for customer registration
        // Generic method to execute INSERT, UPDATE, DELETE queries
        public static void ExecuteQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
