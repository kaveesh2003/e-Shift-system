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
    public partial class CustomerProfile : Form
    {
        private int _userId;
        public CustomerProfile(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                Customer cust = new Customer();
                cust.UserID = _userId;
                cust.FullName = txtFullName.Text;
                cust.NIC = txtNic.Text;
                cust.Email = txtEmail.Text;
                cust.Mobile = txtMobile.Text;
                cust.Address = txtAddress.Text;
                cust.City = txtCity.Text;
                cust.Age = int.Parse(txtAge.Text);

                cust.SaveCustomer(cust); // Save the customer to the database
                MessageBox.Show("Profile saved successfully!");

                //redirect to dashboard here
                //CustomerDashboard dashboard = new CustomerDashboard(_userId, cust.FullName);
                //dashboard.Show();
                //this.Close();
            }
        }

        private bool DataValid()
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Enter Customer Name");
                return false;
            }

            if (txtNic.Text == "")
            {
                MessageBox.Show("Enter Customer NIC");
                return false;
            }

            if (txtMobile.Text == "")
            {
                MessageBox.Show("Enter Mobile Number");
                return false;
            }

            return true;
        }
    }
}
