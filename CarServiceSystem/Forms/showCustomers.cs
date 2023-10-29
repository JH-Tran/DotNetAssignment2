using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceSystem.Forms
{
    public partial class showCustomers : Form
    {
        public showCustomers()
        {
            InitializeComponent();

            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            // Fills first listbox with customer emails within the system
            customerList.BeginUpdate();
            foreach (var cust in context.Customers)
            {
                customerList.Items.Add(cust.Email);
            }
            customerList.EndUpdate();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var adminMainMenuForm = new ServiceAdminMainMenu();
            adminMainMenuForm.Show();
            this.Hide();
        }

        private void delCustButton_Click(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            if (customerList.SelectedItem != null)
            {
                string message = "Are you sure you want to delete this customer?";
                string caption = "Delete Customer";

                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                // If user is sure they want to delete customer, removes it from the database
                if (result == DialogResult.Yes)
                {
                    Customer customer = context.Customers.FirstOrDefault(c => c.Email == customerList.SelectedItem) ?? null!;
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    customerList.Items.Remove(customerList.SelectedItem);
                    customerProperties.Items.Clear();
                    Titles.Items.Clear();
                }

            }
        }

        private void customerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerList.SelectedItem != null)
            {
                viewCustButton.Visible = true;
                delCustButton.Visible = true;
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            var adminMainMenuForm = new ServiceAdminMainMenu();
            adminMainMenuForm.Show();
            this.Hide();
        }

        private void viewCustButton_Click_1(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            customerProperties.Items.Clear();
            Titles.Items.Clear();

            if (customerList.SelectedItem != null)
            {
                Customer customer = context.Customers.FirstOrDefault(c => c.Email == customerList.SelectedItem) ?? null!;
                customerProperties.Items.Add(customer.FirstName);
                customerProperties.Items.Add(customer.LastName);
                customerProperties.Items.Add(customer.Email);

                Titles.Items.Add("First Name");
                Titles.Items.Add("Last Name");
                Titles.Items.Add("Email");

                customerList.SelectedItems.Clear();
            }
        }

        private void showCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
