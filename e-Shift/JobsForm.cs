using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class JobsForm : Form
    {
        public JobsForm()
        {
            InitializeComponent();
        }

        private void JobsForm_Load(object sender, EventArgs e)
        {
            //display data in grid view
            Data.LoadTableToGrid("Jobs", dgvRequestedJobs);
        }

        private void btnAcceptJob_Click(object sender, EventArgs e)
        {
            if (dgvRequestedJobs.SelectedRows.Count > 0)
            {
                int jobId = Convert.ToInt32(dgvRequestedJobs.SelectedRows[0].Cells["JobID"].Value);
                string status = dgvRequestedJobs.SelectedRows[0].Cells["Status"].Value.ToString();

                if (status == "Pending")
                {
                    Jobs.UpdateJobStatus(jobId, "Accepted");
                    MessageBox.Show("Job accepted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadJobData(); // Refresh grid
                }
                else
                {
                    MessageBox.Show("Only pending jobs can be accepted.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a job to accept.");
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dgvRequestedJobs.SelectedRows.Count > 0)
            {
                int jobId = Convert.ToInt32(dgvRequestedJobs.SelectedRows[0].Cells["JobID"].Value);
                string status = dgvRequestedJobs.SelectedRows[0].Cells["Status"].Value.ToString();

                if (status == "Pending")
                {
                    Jobs.UpdateJobStatus(jobId, "Declined");
                    MessageBox.Show("Job declined successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadJobData(); // Refresh grid
                }
                else
                {
                    MessageBox.Show("Only pending jobs can be declined.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a job to decline.");
            }
        }

        private void LoadJobData()
        {
            string sql = "SELECT JobID, UserID, RequestedStartLocation, RequestedDestination, Status FROM Jobs";
            DataTable dt = Data.GetDataTable(sql, new SqlParameter[0]);
            dgvRequestedJobs.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Check if user entered something
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // Define the columns to search
            string[] columnsToSearch = { "RequestedStartLocation", "RequestedDestination", "Status" };

            // Call your Data class method
            DataTable result = Data.SearchMultipleColumns("Jobs", columnsToSearch, searchText);

            // Bind results to DataGridView
            dgvRequestedJobs.DataSource = result;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            CompleteJob completeJob = new CompleteJob();
            completeJob.Show();
        }
    }
}
