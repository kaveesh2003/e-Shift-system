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
    public partial class RequestJob : Form
    {
        private int _currentUserID;

        public RequestJob(int userID)
        {
            InitializeComponent();
            _currentUserID = userID;
            dtpRequestedDate.MinDate = DateTime.Today; 
        }

        private void btnSubmitJob_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtStartLocation.Text) ||
                string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (dtpRequestedDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Requested date cannot be in the past.");
                return;
            }

            if (txtStartLocation.Text.Trim().ToLower() == txtDestination.Text.Trim().ToLower())
            {
                MessageBox.Show("Start and destination cannot be the same.");
                return;
            }

            if (_currentUserID <= 0) // Pass from constructor or session
            {
                MessageBox.Show("Invalid user. Please log in again.");
                return;
            }

            // Step 2: Create Job object
            Jobs newJob = new Jobs
            {
                UserID = _currentUserID,
                StartLocation = txtStartLocation.Text.Trim(),
                Destination = txtDestination.Text.Trim(),
                RequestedDate = dtpRequestedDate.Value.Date
            };

            // Step 3: Save job
            if (newJob.SaveJob())
            {
                MessageBox.Show("Job request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to submit job request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            txtStartLocation.Text = "";
            txtDestination.Text = "";
            dtpRequestedDate.Value = DateTime.Today;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
