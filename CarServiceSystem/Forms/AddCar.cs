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
                string licenceNumber = Convert.ToString(yearModelTextBox.Text);
                string vehicleIdentificationNumber = Convert.ToString(vehicleIdentificationNumberTextBox.Text);
                int odometer = Convert.ToInt32(odometerTextBox.Text);
                var car = new Car { Make = company, Model = model, Year = year, LicenceNumber = licenceNumber, VehicleIdentificationNumber = vehicleIdentificationNumber, Odometer = odometer, Owner = loggedInCustomer };

                using (MechanicServiceContext context = new MechanicServiceContext())
                {
                    context.Cars.Add(car);
                }
            }
            catch
            {

            }
        }
    }
}
