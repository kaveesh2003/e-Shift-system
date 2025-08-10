using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shift
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        //Sign Up Method
        public bool SignUp()
        {
            // Password validation
            if (!IsValidPassword(this.Password))
            {
                return false;
            }

            string checkQuery = "SELECT * FROM [Users] WHERE Username = @Username";
            SqlParameter[] checkParams =
            {
                new SqlParameter("@Username", this.Username)
            };

            DataTable result = Data.GetDataTable(checkQuery, checkParams);

            if (result.Rows.Count > 0)
            {
                return false;
            }

            //Insert new user

            string insertQuery = "INSERT INTO [Users] (Username, Password, Role) VALUES (@Username, @Password, @Role)";
            SqlParameter[] insertParams =
            {
                new SqlParameter("@Username", this.Username),
                new SqlParameter("@Password", this.Password),
                new SqlParameter("@Role", this.Role)
            };
            try
            {
                Data.ExecuteQuery(insertQuery, insertParams);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Login Method
        public bool Login()
        {
            string query = "SELECT UserID, Role FROM [Users] WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", this.Username),
                new SqlParameter("@Password", this.Password)
            };

            DataTable dt = Data.GetDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                this.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                this.Role = dt.Rows[0]["Role"].ToString();  
                return true;
            }

            return false;
        }

        // Password validation helper
        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 8) return false; // Minimum 8 characters
            if (!password.Any(char.IsUpper)) return false; // At least one uppercase
            if (!password.Any(char.IsLower)) return false; // At least one lowercase
            if (!password.Any(char.IsDigit)) return false; // At least one digit
            if (!password.Any(ch => "!@#$%^&*()_-+=<>?".Contains(ch))) return false; // At least one special char
            return true;
        }
    }
}
