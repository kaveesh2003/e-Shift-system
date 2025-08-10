using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class MyJobs : Form
    {

        private int _userID;
        private Jobs _jobHandler;

        public MyJobs(int userID)
        {
            InitializeComponent();
            _userID = userID;
            _jobHandler = new Jobs();
        }

        private void MyJobs_Load(object sender, EventArgs e)
        {
            cmbStatusFilter.Items.AddRange(new string[] { "All", "Pending", "Approved", "Cancelled", "Completed" });
            cmbStatusFilter.SelectedIndex = 0;
            LoadJobs();
        }

        private void LoadJobs(string status = "All", DateTime? filterDate = null)
        {
            DataTable jobData = _jobHandler.GetJobsByUser(_userID, status, filterDate);
            dgvJobs.DataSource = jobData;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string status = cmbStatusFilter.SelectedItem?.ToString() ?? "All";
            DateTime? filterDate = dtpFilterDate.Value.Date;
            LoadJobs(status, filterDate);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbStatusFilter.SelectedIndex = 0;
            dtpFilterDate.Value = DateTime.Now;
            LoadJobs();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int jobID = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["JobID"].Value);
                string status = dgvJobs.SelectedRows[0].Cells["Status"].Value.ToString();

                if (status == "Pending")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this job?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        bool success = _jobHandler.CancelJob(jobID);
                        if (success)
                        {
                            MessageBox.Show("Job cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadJobs();
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Only pending jobs can be cancelled.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Please select a job.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            
        }
    }
}
