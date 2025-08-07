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
    public partial class AdminDashboard : Form
    {
        private User _adminUser;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            _adminUser = user;
        }

        private void lblCompletedJobs_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + _adminUser.Username;

            int totalCustomers = Data.GetTotalCount("Customers");
            lblTotalCustomers.Text = totalCustomers.ToString();

            int totalJobs = Data.GetTotalCount("Jobs");
            lblTotalJobs.Text = totalJobs.ToString();

            lblTotalCustomers.Text = "Total Customers: " + totalCustomers;
            lblTotalJobs.Text = "Total Jobs: " + totalJobs;

            //display data in grid view
            Data.LoadTableToGrid("Jobs", dgvJobRequests);
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Admin Dashboard
            ManageCustomer customerForm = new ManageCustomer();
            customerForm.FormClosed += (s, args) => this.Show(); // Show dashboard again after closing
            customerForm.Show();
        }
    }
}
