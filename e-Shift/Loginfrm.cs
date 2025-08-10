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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            if (user.Login())
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open dashboard based on role from DB
                if (user.Role == "Admin")
                {
                    AdminDashboard adminForm = new AdminDashboard(user);
                    adminForm.Show();
                }
                else if (user.Role == "Customer")
                {
                    // Create Customer object
                    Customer loggedInCustomer = new Customer(user.UserID, user.Username);

                    // Check if profile is complete
                    if (loggedInCustomer.IsProfileComplete())
                    {
                        CustomerDashboard dashboard = new CustomerDashboard(user.UserID, user.Username);
                        dashboard.Show();
                    }
                    else
                    {
                        TempDasboard tempDashboard = new TempDasboard(loggedInCustomer);
                        tempDashboard.Show();
                    }
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Signupfrm signUpForm = new Signupfrm();
            signUpForm.ShowDialog();

            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
