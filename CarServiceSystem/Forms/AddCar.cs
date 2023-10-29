using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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
    public partial class AddCar : UserControl
    {
        Customer loggedInCustomer;
        public AddCar()
        {
            InitializeComponent();
        }
        public void ResetTextBox()
        {
            carCompanyTextBox.Text = "";
            carModelTextBox.Text = "";
            yearModelTextBox.Text = "";
            licenceNumberTextBox.Text = "";
            vehicleIdentificationNumberTextBox.Text = "";
            odometerTextBox.Text = "";
            informationLabel.Visible = false;
        }

        internal void AssignLoginCustomer(Customer loggedInCustomer)
        {
            this.loggedInCustomer = loggedInCustomer;
        }

        private void ConfirmAddingCar(object sender, EventArgs e)
        {
            try
            {
                string company = Convert.ToString(carCompanyTextBox.Text);
                string model = Convert.ToString(carModelTextBox.Text);
                int year = Convert.ToInt32(yearModelTextBox.Text);
                int odometer = Convert.ToInt32(odometerTextBox.Text);
                string licenceNumber = Convert.ToString(licenceNumberTextBox.Text);
                string vehicleIdentificationNumber = Convert.ToString(vehicleIdentificationNumberTextBox.Text);
                string completedText = "";

                using (var context = new MechanicServiceContext())
                {
                    context.Database.EnsureCreated();
                    var carOwner = context.Customers
                        .Where(c => c.Email == loggedInCustomer.Email)
                        .FirstOrDefault();
                    var car = new Car() { Make = company, Model = model, Year = year, Odometer = odometer, LicenceNumber = licenceNumber, VehicleIdentificationNumber = vehicleIdentificationNumber, Owner = carOwner };
                    context.Cars.Add(car);
                    context.SaveChanges();
                    completedText = $"{company} {model} {year}";
                }
                ResetTextBox();
                informationLabel.Visible = true;
                informationLabel.ForeColor = Color.Black;
                informationLabel.Text = $"{completedText} has been added to your account.";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                informationLabel.Visible = true;
                informationLabel.ForeColor = Color.Red;
                informationLabel.Text = "Model Year or Odometer Input Input is Invalid.";
            }
        }
    }
}
