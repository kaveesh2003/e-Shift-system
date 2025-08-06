using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public class Jobs
    {
        public int JobID { get; set; }
        public int UserID { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; } = "Pending";

        //Save the job
        public bool SaveJob()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Data.cs))
                {
                    conn.Open();
                    string query = "INSERT INTO Jobs (UserID, RequestedStartLocation, RequestedDestination, RequestedDate, Status) " +
                                   "VALUES (@UserID, @RequestedStartLocation, @RequestedDestination, @RequestedDate, @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", this.UserID);
                    cmd.Parameters.AddWithValue("@RequestedStartLocation", this.StartLocation);
                    cmd.Parameters.AddWithValue("@RequestedDestination", this.Destination);
                    cmd.Parameters.AddWithValue("@RequestedDate", this.RequestedDate);
                    cmd.Parameters.AddWithValue("@Status", this.Status);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving job: " + ex.Message);
                return false;
            }
        }
    }
}
