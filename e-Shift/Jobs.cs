using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
                MessageBox.Show("Error while saving job: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        //methods for my jobs form

        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["dbcon"].ToString();

        public DataTable GetJobsByUser(int userID, string status = "All", DateTime? date = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT JobID, RequestedDate AS [RequestedDate], Status, RequestedStartLocation AS [Start_Location], RequestedDestination AS [Destination]
                                 FROM Jobs
                                 WHERE UserID = @UserID";

                if (status != "All")
                    query += " AND Status = @Status";

                if (date != null)
                    query += " AND CAST(RequestedDate AS DATE) = @RequestedDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    if (status != "All")
                        cmd.Parameters.AddWithValue("@Status", status);
                    if (date != null)
                        cmd.Parameters.AddWithValue("@RequestedDate", date.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public bool CancelJob(int jobID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Jobs SET Status = 'Cancelled' WHERE JobID = @JobID AND Status = 'Pending'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@JobID", jobID);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        //admin dashboard -----------------------------------------------------------------------
        
        //change job status
        public static void UpdateJobStatus(int jobId, string newStatus)
        {
            string sql = "UPDATE Jobs SET Status = @status WHERE JobID = @jobId";
            SqlParameter[] parameters = {
                new SqlParameter("@status", newStatus),
                new SqlParameter("@jobId", jobId)
            };

            Data.ExecuteNonQuery(sql, parameters);
        }
    }
}
