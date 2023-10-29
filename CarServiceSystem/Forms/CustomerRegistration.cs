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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                InvalidInputLbl.Hide();
                if (EmailExists())
                {
                    EmailInUseLbl.Show();
                    //show email exists error
                }
                else
                {
                    EmailInUseLbl.Hide();
                    string firstName = FirstNameInput.Text.Trim();
                    string lastName = LastNameInput.Text.Trim();
                    string email = EmailInput.Text.Trim();
                    string password = PasswordInput.Text.Trim();
                    using (MechanicServiceContext context = new MechanicServiceContext())
                    {
                        Customer customer = new Customer()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Email = email,
                            Password = password
                        };
                        context.Customers.Add(customer);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Account created successfully");
                    this.Close();
                }
            }
            else
            {
                InvalidInputLbl.Show();
            }
        }


        private bool ValidInput()
        {
            if (FirstNameInput.Text.Trim() == string.Empty) { return false; }
            if (LastNameInput.Text.Trim() == string.Empty) { return false; }
            if (EmailInput.Text.Trim() == string.Empty) { return false; }
            if (!EmailManager.IsValidEmail(EmailInput.Text.Trim())) { return false; }
            if (PasswordInput.Text.Trim() == string.Empty) { return false; }
            return true;
        }

        private bool EmailExists()
        {
            using (MechanicServiceContext context = new MechanicServiceContext())
            {
                if (context.Customers.Any(c => c.Email == EmailInput.Text.Trim())) { return true; }
                if (context.Mechanics.Any(m => m.Email == EmailInput.Text.Trim())) { return true; }
                if (context.ServiceAdmins.Any(s => s.Email == EmailInput.Text.Trim())) { return true; }
            }
            return false;
        }
    }
}
