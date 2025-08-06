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
    public partial class TempDasboard : Form
    {
        private Customer _customer;

        public TempDasboard(Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            lblWelcome.Text = $"Hi, {_customer.Username}";
            lblMessage.Text = "Please complete your profile to access full system features.";
        }

        private void btnCompleteProfile_Click(object sender, EventArgs e)
        {
            using (CustomerProfile profileForm = new CustomerProfile(_customer.UserID))
            {
                this.Hide();
                profileForm.ShowDialog();
                this.Show();

                // Reload updated profile info
                _customer.LoadCustomerDetails(); //Load updated data after profile save

                // Recheck profile status after closing the form
                if (_customer.IsProfileComplete())
                {
                    CustomerDashboard dashboard = new CustomerDashboard(_customer.UserID, _customer.Username);
                    dashboard.Show();
                    this.Close(); // Close TempDashboard
                }
                else
                {
                    MessageBox.Show("Profile is still incomplete. Please complete all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TempDasboard_Load(object sender, EventArgs e)
        {
            btnReqShift.Enabled = false;
            btnMyJobs.Enabled = false;
            btnTrackJob.Enabled = false;
        }
    }
}
