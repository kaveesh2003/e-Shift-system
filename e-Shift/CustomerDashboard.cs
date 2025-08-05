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
    }
}
