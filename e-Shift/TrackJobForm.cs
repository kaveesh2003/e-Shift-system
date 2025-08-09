using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class TrackJobForm : Form
    {
        private int customerId;
        public TrackJobForm(int custId)
        {
            InitializeComponent();
            customerId = custId;
            dgvJobs.CellContentClick += dgvJobs_CellContentClick;
        }

        private void TrackJobForm_Load(object sender, EventArgs e)
        {
            // Load only the logged-in customer's jobs
            string query = $@"
                SELECT JobID, Status, CreatedDate
                FROM Jobs
                WHERE UserID = {customerId}";

            Data.LoadDataToGrid(query, dgvJobs);

            AddTrackButtonColumn();

        }
        // Add Track button dynamically
        private void AddTrackButtonColumn()
        {
            if (!dgvJobs.Columns.Contains("btnTrack"))
            {
                DataGridViewButtonColumn btnTrack = new DataGridViewButtonColumn
                {
                    HeaderText = "Action",
                    Name = "btnTrack",
                    Text = "Track",
                    UseColumnTextForButtonValue = true
                };
                dgvJobs.Columns.Add(btnTrack);
            }
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvJobs.Columns[e.ColumnIndex].Name == "btnTrack")
            {
                string jobID = dgvJobs.Rows[e.RowIndex].Cells["JobID"].Value.ToString();

                // Load job details
                LoadJobTrackingDetails(jobID);

                // Load products for the job
                LoadJobProducts(jobID);

                // Show tracking panel
                pnlTrackingDetails.Visible = true;
            }
        }

        private void LoadJobTrackingDetails(string jobID)
        {
            string query = $@"
                SELECT JobID, RequestedStartLocation, RequestedDestination, Status
                FROM Jobs
                WHERE JobID = {jobID}";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtJobID.Text = reader["JobID"].ToString();
                    txtPickup.Text = reader["RequestedStartLocation"].ToString();
                    txtDelivery.Text = reader["RequestedDestination"].ToString();
                    txtStatus.Text = reader["Status"].ToString();

                    // Update progress bar
                    UpdateProgressBar(reader["Status"].ToString());
                }
            }
        }

        private void UpdateProgressBar(string status)
        {
            switch (status)
            {
                case "Pending":
                    pbProgress.Value = 10;
                    break;
                case "Accepted":
                    pbProgress.Value = 25;
                    break;
                case "In Progress":
                    pbProgress.Value = 50;
                    break;
                case "In Transit":
                    pbProgress.Value = 75;
                    break;
                case "Completed":
                    pbProgress.Value = 100;
                    break;
                case "Cancelled":
                case "Declined":
                    pbProgress.Value = 0;
                    break;
                default:
                    pbProgress.Value = 0; // Fallback for unexpected statuses
                    break;
            }
        }

        private void LoadJobProducts(string jobID)
        {
            string query = $@"
            SELECT P.ProductName, LP.Quantity, LP.TotalWeight
            FROM Loads L
            INNER JOIN LoadProducts LP ON L.LoadID = LP.LoadID
            INNER JOIN Products P ON LP.ProductID = P.ProductID
            WHERE L.JobID = {jobID}";

            Data.LoadDataToGrid(query, dgvProducts);
        }
    }
}
