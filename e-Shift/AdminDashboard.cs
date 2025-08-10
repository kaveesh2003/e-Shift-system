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

            int totalCompletedJobs = Data.GetTotalCountWhere("Jobs", "Status = 'Completed'");
            lblCompletedJobs.Text = "Completed Jobs: " + totalCompletedJobs;

            int totalLoads = Data.GetTotalCount("Loads");
            lblTotalLoads.Text = "Total Loads: " + totalLoads;

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
            this.Hide(); 
            ManageCustomer customerForm = new ManageCustomer();
            customerForm.FormClosed += (s, args) => this.Show(); 
            customerForm.Show();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            JobsForm jobsform = new JobsForm();
            jobsform.FormClosed += (s, args) => this.Show(); 
            jobsform.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.FormClosed += (s, args) => this.Show(); 
            manageProducts.Show();
        }

        private void btnTransportUnit_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            TransportUnit transportUnit = new TransportUnit();
            transportUnit.FormClosed += (s, args) => this.Show(); 
            transportUnit.Show();
        }

        private void btnLoads_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            LoadsForm loadsForm = new LoadsForm();
            loadsForm.FormClosed += (s, args) => this.Show(); 
            loadsForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            FormReports reportsForm = new FormReports();
            reportsForm.FormClosed += (s, args) => this.Show(); 
            reportsForm.Show();
        }

        private void btnAdminSettings_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            AdminSettingsForm adminSettings = new AdminSettingsForm(_adminUser);
            adminSettings.FormClosed += (s, args) => this.Show(); 
            adminSettings.Show();
        }

        private void lblTotalCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
