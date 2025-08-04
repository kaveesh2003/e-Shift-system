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
            lblWelcome.Text = $"Welcome, {_currentCustomer.Name}";
            HandleProfileCheck();
        }

        private void HandleProfileCheck()
        {
            if (!_currentCustomer.IsProfileComplete())
            {
                grpJobSummary.Visible = false;

                DialogResult result = MessageBox.Show(
                    "⚠ Your profile is incomplete. Please complete it to access full system features.",
                    "Complete Profile Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    RedirectToProfileForm();
                }
            }
            else
            {
                grpJobSummary.Visible = true;
            }
        }
        private void RedirectToProfileForm()
        {
            using (CustomerProfile profileForm = new CustomerProfile(_currentCustomer.Id))
            {
                this.Hide();
                profileForm.ShowDialog();
                this.Show();

                // Recheck after profile update
                if (_currentCustomer.IsProfileComplete())
                {
                    grpJobSummary.Visible = true;
                }
            }
        }
    }
}
