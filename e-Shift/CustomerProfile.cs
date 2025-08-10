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
        private Customer _customer;

        public CustomerProfile(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadCustomerData();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            LoadDataToTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                _customer.UserID = _userId;
                _customer.FullName = txtFullName.Text;
                _customer.NIC = txtNic.Text;
                _customer.Email = txtEmail.Text;
                _customer.Mobile = txtMobile.Text;
                _customer.Address = txtAddress.Text;
                _customer.City = txtCity.Text;
                _customer.Age = int.Parse(txtAge.Text);

                _customer.SaveCustomer(_customer);
                MessageBox.Show("Profile saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private bool DataValid()
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Enter Customer Name", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (txtNic.Text == "")
            {
                MessageBox.Show("Enter Customer NIC", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (txtMobile.Text == "")
            {
                MessageBox.Show("Enter Mobile Number", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void LoadCustomerData()
        {
       
            _customer = new Customer();
            _customer.UserID = _userId;
            _customer.LoadCustomerDetails();

            txtFullName.Text = _customer.FullName;
            txtNic.Text = _customer.NIC;
            txtEmail.Text = _customer.Email;
            txtMobile.Text = _customer.Mobile;
            txtAddress.Text = _customer.Address;
            txtCity.Text = _customer.City;
            txtAge.Text = _customer.Age.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customer.FullName = txtFullName.Text;
            _customer.NIC = txtNic.Text;
            _customer.Email = txtEmail.Text;
            _customer.Mobile = txtMobile.Text;
            _customer.Address = txtAddress.Text;
            _customer.City = txtCity.Text;

            if (int.TryParse(txtAge.Text, out int age))
            {
                _customer.Age = age;

                bool success = _customer.UpdateCustomerDetails();

                if (success)
                {
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload updated details into the textboxes
                    _customer.LoadCustomerDetails();
                    LoadDataToTextBoxes();  // Custom method to refresh textboxes
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDataToTextBoxes()
        {
            txtFullName.Text = _customer.FullName;
            txtNic.Text = _customer.NIC;
            txtEmail.Text = _customer.Email;
            txtMobile.Text = _customer.Mobile;
            txtAddress.Text = _customer.Address;
            txtCity.Text = _customer.City;
            txtAge.Text = _customer.Age.ToString();
        }

    }

}
