using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

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

        //for the Admin dashboard ---------------------------------------------------------------
        public static int GetTotalCount(string tableName)
        {
            int count = 0;
            using (SqlConnection conn = GetConnection())
            {
                string query = $"SELECT COUNT(*) FROM {tableName}";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }


        //Data Grid View method
        public static void LoadTableToGrid(string tableName, DataGridView grid)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = $"SELECT * FROM {tableName}";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    grid.DataSource = dt;
                }
            }
        }

        //Save method
        public static void ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Delete method
        public static void DeleteById(string tableName, string idColumn, int id)
        {
            string sql = $"DELETE FROM {tableName} WHERE {idColumn} = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", id) };
            ExecuteNonQuery(sql, parameters);
        }

        //Search method
        public static DataTable SearchMultipleColumns(string tableName, string[] columnNames, string searchText)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                // Build dynamic WHERE clause: (col1 LIKE @search OR col2 LIKE @search ...)
                string whereClause = string.Join(" OR ", columnNames.Select(col => $"{col} LIKE @search"));

                string sql = $"SELECT * FROM {tableName} WHERE {whereClause}";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        //Fill combo box
        public static void FillComboBox(string query, ComboBox comboBox, string displayMember, string valueMember)
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox.DataSource = dt;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
            }
        }

        //fill text boxes from the grid view
        public static void FillTextBoxesFromGrid(DataGridView grid, int rowIndex, Dictionary<TextBox, string> mapping)
        {
            if (rowIndex >= 0 && rowIndex < grid.Rows.Count)
            {
                DataGridViewRow row = grid.Rows[rowIndex];

                foreach (var pair in mapping)
                {
                    // Defensive check: if the column name exists
                    if (row.Cells.Contains(row.Cells[pair.Value]))
                    {
                        pair.Key.Text = row.Cells[pair.Value]?.Value?.ToString();
                    }
                }
            }
        }

        //update/edit method
        public static void UpdateRecord(string tableName, string keyColumn, object keyValue, Dictionary<string, object> data)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                
                string setClause = string.Join(", ", data.Keys.Select(col => $"{col} = @{col}"));

                string sql = $"UPDATE {tableName} SET {setClause} WHERE {keyColumn} = @keyValue";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Add parameters for columns
                    foreach (var item in data)
                    {
                        cmd.Parameters.AddWithValue($"@{item.Key}", item.Value ?? DBNull.Value);
                    }

                    // Add key column value
                    cmd.Parameters.AddWithValue("@keyValue", keyValue);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //load data to grid view
        public static void LoadDataToGrid(string query, DataGridView grid)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grid.DataSource = dt;
            }
        }

        //search lorries method 
        public static DataTable SearchLorries(string searchText)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sql = @"
                SELECT l.LorryID, l.PlateNumber, l.Availability, t.TypeName, t.UnitPrice
                FROM Lorries l
                INNER JOIN LorryTypes t ON l.TypeID = t.TypeID
                WHERE l.PlateNumber LIKE @search
                    OR l.Availability LIKE @search
                    OR t.TypeName LIKE @search";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            conn.Open();
                            adapter.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            // Optional: Log error or show message
                            throw new Exception("Database error: " + ex.Message);
                        }
                        return dt;
                    }
                }
            }
        }



    }
}
