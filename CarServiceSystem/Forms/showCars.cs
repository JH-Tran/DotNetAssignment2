using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
    public partial class showCars : Form
    {
        public showCars()
        {
            InitializeComponent();

            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            // Fills the car list with the licence plates of all the cars in the system
            carList.BeginUpdate();
            foreach (var car in context.Cars)
            {
                carList.Items.Add(car.LicenceNumber);
            }
            carList.EndUpdate();
        }

        private void carList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only shows the view car button once a car is selected
            if (carList.SelectedItem != null)
            {
                viewCarButton.Visible = true;
            }
        }

        private void viewCarButton_Click(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            carProperties.Items.Clear();
            Titles.Items.Clear();

            // Checks if a car is selected, then displays its info in a separate listbox
            if (carList.SelectedItem != null)
            {
                var car = context.Cars
                    .Include(c => c.Owner)
                    .Where(c => c.LicenceNumber == carList.SelectedItem)
                    .FirstOrDefault() ?? null!;

                carProperties.Items.Add(car.Make);
                carProperties.Items.Add(car.Model);
                carProperties.Items.Add(car.Year);
                carProperties.Items.Add(car.Odometer);
                carProperties.Items.Add(car.LicenceNumber);
                carProperties.Items.Add(car.VehicleIdentificationNumber);
                carProperties.Items.Add(car.Owner.FirstName + " " + car.Owner.LastName);

                Titles.Items.Add("Make");
                Titles.Items.Add("Model");
                Titles.Items.Add("Year");
                Titles.Items.Add("Odometer");
                Titles.Items.Add("Licence");
                Titles.Items.Add("VIN");
                Titles.Items.Add("Owner");

                carList.SelectedItems.Clear();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var adminMainMenuForm = new ServiceAdminMainMenu();
            adminMainMenuForm.Show();
            this.Hide();
        }

        private void serviceHistButton_Click(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            if (carList.SelectedItem != null)
            {
                var car = context.Cars
                    .Include(c => c.Owner)
                    .Where(c => c.LicenceNumber == carList.SelectedItem)
                    .FirstOrDefault() ?? null!;

                // Creates messagebox with service log information
                string message = "";
                foreach (var service in car.ServiceHistory)
                {
                    message.Concat(service.ServiceLogId + "\n" + service.Mechanic + "\n" + service.Task + "\n\n");
                }
                string caption = "Service Log";

                var serviceMessage = MessageBox.Show(message, caption);
            }
        }
    }
}
