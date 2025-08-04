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
    }
}
