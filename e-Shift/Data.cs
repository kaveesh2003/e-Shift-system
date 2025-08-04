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


        //SIGN UP AND LOGIN

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
    }
}
