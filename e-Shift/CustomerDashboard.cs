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
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            _currentCustomer.LoadCustomerDetails();
            lblWelcome.Text = $"Welcome, {_currentCustomer.FullName}";

            // Show job summary now since profile is guaranteed to be complete
            grpJobSummary.Visible = true;
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
            // Create an instance of the MyJobs form
            MyJobs myJobsForm = new MyJobs(_currentCustomer.UserID);

            // Optional: If you want to pass the logged-in user ID to MyJobs form
            //myJobsForm.LoggedInUserId = this.LoggedInUserId;

            // Show the form
            myJobsForm.Show();
        }
    }
}
