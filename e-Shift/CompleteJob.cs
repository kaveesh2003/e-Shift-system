using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class CompleteJob : Form
    {
        private int currentJobId;
        private decimal unitPrice;
        public CompleteJob(int jobId)
        {
            InitializeComponent();
            currentJobId = jobId;
        }

        private void btnCompleteJob_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDistance.Text, out decimal distance))
            {
                MessageBox.Show("Please enter a valid distance.");
                return;
            }

            if (!decimal.TryParse(txtTotalCost.Text, out decimal totalCost))
            {
                MessageBox.Show("Please calculate the total cost before completing the job.");
                return;
            }

            using (SqlConnection con = new SqlConnection(Data.cs))
            {
                con.Open();
                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        // 1. Update Jobs status to Completed
                        string updateJobSql = @"
                    UPDATE Jobs
                    SET Status = 'Completed'
                    WHERE JobID = @jobId";

                        using (SqlCommand cmd = new SqlCommand(updateJobSql, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@jobId", currentJobId);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Insert into JobCompletionDetails
                        string insertCompletionSql = @"
                    INSERT INTO JobCompletionDetails (JobID, TravelDistance, TotalCost)
                    VALUES (@jobId, @distance, @totalCost)";

                        using (SqlCommand cmd = new SqlCommand(insertCompletionSql, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@jobId", currentJobId);
                            cmd.Parameters.AddWithValue("@distance", distance);
                            cmd.Parameters.AddWithValue("@totalCost", totalCost);
                            cmd.ExecuteNonQuery();
                        }

                        // 3. Update Load status to Delivered (via LoadID from JobID)
                        string updateLoadSql = @"
                    UPDATE Loads
                    SET Status = 'Delivered'
                    WHERE JobID = @jobId";

                        using (SqlCommand cmd = new SqlCommand(updateLoadSql, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@jobId", currentJobId);
                            cmd.ExecuteNonQuery();
                        }

                        // 4. Set availabilities (driver, assistant, container, lorry) to Available
                        // First get the TransportUnit details related to this JobID
                        string getTU = @"
                    SELECT tu.TransportUnitID, tu.LorryID, tu.DriverID, tu.AssistantID, tu.ContainerID
                    FROM TransportUnits tu
                    INNER JOIN Loads l ON tu.LoadID = l.LoadID
                    WHERE l.JobID = @jobId";

                        int lorryId = 0, driverId = 0, assistantId = 0, containerId = 0;

                        using (SqlCommand cmd = new SqlCommand(getTU, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@jobId", currentJobId);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lorryId = Convert.ToInt32(reader["LorryID"]);
                                    driverId = Convert.ToInt32(reader["DriverID"]);
                                    assistantId = Convert.ToInt32(reader["AssistantID"]);
                                    containerId = Convert.ToInt32(reader["ContainerID"]);
                                }
                                else
                                {
                                    throw new Exception("Related transport unit not found.");
                                }
                            }
                        }

                        // Now update availability for each to 'Available'
                        string updateAvailSql = @"
                    UPDATE Lorries SET Availability = 'Available' WHERE LorryID = @lorryId;
                    UPDATE Drivers SET Availability = 'Available' WHERE DriverID = @driverId;
                    UPDATE Assistants SET Availability = 'Available' WHERE AssistantID = @assistantId;
                    UPDATE Containers SET Availability = 'Available' WHERE ContainerID = @containerId;";

                        using (SqlCommand cmd = new SqlCommand(updateAvailSql, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@lorryId", lorryId);
                            cmd.Parameters.AddWithValue("@driverId", driverId);
                            cmd.Parameters.AddWithValue("@assistantId", assistantId);
                            cmd.Parameters.AddWithValue("@containerId", containerId);
                            cmd.ExecuteNonQuery();
                        }

                        tran.Commit();

                        MessageBox.Show("Job completed successfully!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error completing job: " + ex.Message);
                    }
                }
            }
        }

        private void CompleteJob_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Data.cs))
            {
                con.Open();

                // Get job details + related lorry ID and unit price
                string sql = @"
    SELECT j.JobID, j.RequestedStartLocation, j.RequestedDestination, j.Status,
           tu.LorryID, lt.UnitPrice
    FROM Jobs j
    INNER JOIN Loads l ON j.JobID = l.JobID
    INNER JOIN TransportUnits tu ON l.LoadID = tu.LoadID
    INNER JOIN Lorries lo ON tu.LorryID = lo.LorryID
    INNER JOIN LorryTypes lt ON lo.TypeID = lt.TypeID
    WHERE j.JobID = @jobId";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@jobId", currentJobId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string status = reader["Status"].ToString();

                            if (status != "In Transit")
                            {
                                MessageBox.Show("Selected job is not in 'In Transit' status. Cannot complete.");
                                this.Close();
                                return;
                            }

                            txtJobID.Text = reader["JobID"].ToString();
                            txtStartLocation.Text = reader["RequestedStartLocation"].ToString();
                            txtDestination.Text = reader["RequestedDestination"].ToString();

                            // Save unit price for later
                            unitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                        }
                        else
                        {
                            MessageBox.Show("Job details not found.");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDistance.Text, out decimal distance))
            {
                MessageBox.Show("Please enter a valid numeric distance.");
                return;
            }

            decimal totalCost = distance * unitPrice;
            txtTotalCost.Text = totalCost.ToString("0.00");
        }

    }
}
