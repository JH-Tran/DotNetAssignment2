using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceSystem;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Diagnostics;

namespace CarServiceSystem.Forms
{
    public partial class showMechanics : Form
    {
        public showMechanics()
        {
            InitializeComponent();

            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            // Fills first listbox with mechanics from the system
            mechanicsList.BeginUpdate();
            foreach (var mech in context.Mechanics)
            {
                mechanicsList.Items.Add(mech.Email);
            }
            mechanicsList.EndUpdate();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var adminMainMenuForm = new ServiceAdminMainMenu();
            adminMainMenuForm.Show();
            this.Hide();
        }

        private void delMechButton_Click(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            if (mechanicsList.SelectedItem != null)
            {
                string message = "Are you sure you want to delete this mechanic?";
                string caption = "Delete Mechanic";

                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Mechanic mechanic = context.Mechanics.FirstOrDefault(m => m.Email == mechanicsList.SelectedItem) ?? null!;
                    context.Mechanics.Remove(mechanic);
                    context.SaveChanges();
                    mechanicsList.Items.Remove(mechanicsList.SelectedItem);
                    mechanicProperties.Items.Clear();
                    Titles.Items.Clear();
                }

            }
        }

        private void viewMechButton_Click(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            mechanicProperties.Items.Clear();
            Titles.Items.Clear();

            if (mechanicsList.SelectedItem != null)
            {
                Mechanic mechanic = context.Mechanics.FirstOrDefault(m => m.Email == mechanicsList.SelectedItem) ?? null!;
                mechanicProperties.Items.Add(mechanic.FirstName);
                mechanicProperties.Items.Add(mechanic.LastName);
                mechanicProperties.Items.Add(mechanic.Email);
                mechanicProperties.Items.Add(mechanic.WorkShopName);

                Titles.Items.Add("First Name");
                Titles.Items.Add("Last Name");
                Titles.Items.Add("Email");
                Titles.Items.Add("Workshop");

                mechanicsList.SelectedItems.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mechanicsList.SelectedItem != null)
            {
                viewMechButton.Visible = true;
                delMechButton.Visible = true;
            }
        }

        private void mechanicProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void addMechButton_Click(object sender, EventArgs e)
        {
            var addMechForm = new addMechanic();
            addMechForm.Show();
            this.Hide();
        }

        private void viewMechScheduleButton_Click(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();

            if (mechanicsList.SelectedItem != null)
            {
                Mechanic mechanic = context.Mechanics.FirstOrDefault(m => m.Email == (string) mechanicsList.SelectedItem) ?? null!;

                var mechanicBookingList = context.Bookings
                    .Include(book => book.Customer)
                    .Include(book => book.Car)
                    .Where(book => book.Mechanic == mechanic)
                    .ToList();

                string message = "";
                foreach (var item in mechanicBookingList)
                {
                    message += $"Booking for {item.Customer.FirstName}'s {item.Car.Make} {item.Car.Model} at {item.dateTime}\n";
                }
                string caption = "Mechanic Schedule";

                var serviceMessage = MessageBox.Show(message, caption);
            }
        }
    }
}
