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
    public partial class CustomerDashboard : Form
    {

        private Customer _currentCustomer;

        public CustomerDashboard(int loggedInUserId, string loggedInUserName)
        {
            InitializeComponent();

            _currentCustomer = new Customer(loggedInUserId, loggedInUserName);

            SetupRecentActivityListView();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            _currentCustomer.LoadCustomerDetails();
            lblWelcome.Text = $"Welcome, {_currentCustomer.FullName}";

            int custId = _currentCustomer.UserID;

            // Load summary cards
            lblTotalJobs.Text = GetTotalJobs(custId).ToString();
            lblActivateJobs.Text = GetActiveJobs(custId).ToString();
            lblCompletedJobs.Text = GetCompletedJobs(custId).ToString();
            

            // Load recent activity feed
            DataTable recentUpdates = GetRecentJobUpdates(custId);
            lstRecentActivity.Items.Clear();
            foreach (DataRow row in recentUpdates.Rows)
            {
                lstRecentActivity.Items.Add(row["UpdateInfo"].ToString());
            }

            LoadRecentActivity(custId);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile profileForm = new CustomerProfile(_currentCustomer.UserID);
            profileForm.ShowDialog();

            // Optionally reload updated data after profile changes
            _currentCustomer.LoadCustomerDetails();
            lblWelcome.Text = $"Welcome, {_currentCustomer.FullName}";
        }

        private void btnReqShift_Click(object sender, EventArgs e)
        {
            RequestJob requestJobForm = new RequestJob(_currentCustomer.UserID);
            requestJobForm.ShowDialog();
        }

        private void btnMyJobs_Click(object sender, EventArgs e)
        {
            MyJobs myJobsForm = new MyJobs(_currentCustomer.UserID);
            myJobsForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Loginfrm loginForm = new Loginfrm();
                loginForm.Show();
                this.Close();
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnTrackJob_Click(object sender, EventArgs e)
        {
            TrackJobForm trackJobForm = new TrackJobForm(_currentCustomer.UserID);
            trackJobForm.Show();
        }

        // Get count of all jobs for the customer
        private int GetTotalJobs(int customerId)
        {
            string query = $"SELECT COUNT(*) FROM Jobs WHERE UserID = {customerId}";
            return Data.ExecuteScalarInt(query);
        }

        // Get count of active jobs (Pending + In Transit)
        private int GetActiveJobs(int customerId)
        {
            string query = $"SELECT COUNT(*) FROM Jobs WHERE UserID = {customerId} AND Status IN ('Pending', 'In Transit')";
            return Data.ExecuteScalarInt(query);
        }

        // Get count of completed jobs
        private int GetCompletedJobs(int customerId)
        {
            string query = $"SELECT COUNT(*) FROM Jobs WHERE UserID = {customerId} AND Status = 'Completed'";
            return Data.ExecuteScalarInt(query);
        }

        // Get recent job status updates (last 5)
        private DataTable GetRecentJobUpdates(int customerId)
        {
            string query = $@"
            SELECT TOP 5
            CONCAT('Job #', JobID, ' is currently ', Status) AS UpdateInfo
            FROM Jobs
            WHERE UserID = {customerId}
            ORDER BY JobID DESC";

            return Data.GetDataTable(query);
        }

        private void SetupRecentActivityListView()
        {
            lstRecentActivity.View = View.List;
            lstRecentActivity.Columns.Clear(); 
            lstRecentActivity.HeaderStyle = ColumnHeaderStyle.None; 
        }

        private void LoadRecentActivity(int customerId)
        {
            DataTable recentUpdates = GetRecentJobUpdates(customerId);
            lstRecentActivity.Items.Clear();

            foreach (DataRow row in recentUpdates.Rows)
            {
                string updateText = row["UpdateInfo"].ToString();
                ListViewItem item = new ListViewItem(updateText);
                lstRecentActivity.Items.Add(item);
            }
        }



    }
}
