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

namespace CarServiceSystem.Forms
{
    public partial class MechanicMainMenu : Form
    {
        private Mechanic loggedInMechanic;
        public MechanicMainMenu(Mechanic mechanic)
        {
            this.loggedInMechanic = mechanic;
            InitializeComponent();
        }

        private void MechanicMainMenu_Load(object sender, EventArgs e)
        {
            mechanicDetails1.Hide();
            lookupCar1.Hide();
            addServiceLog1.Hide();
            viewSchedule1.Hide();
            WelcomeLbl.Text = "Welcome, " + loggedInMechanic.GetFullName() + "!";
            WelcomeLbl.BringToFront();
        }

        private void PersonalDetailsBtn_Click(object sender, EventArgs e)
        {
            WelcomeLbl.Hide();
            mechanicDetails1.Show();
            mechanicDetails1.BringToFront();
        }

        private void LookupCarBtn_Click(object sender, EventArgs e)
        {
            WelcomeLbl.Hide();
            lookupCar1.Show();
            lookupCar1.BringToFront();
        }

        private void AddServiceLogBtn_Click(object sender, EventArgs e)
        {
            WelcomeLbl.Hide();
            addServiceLog1.Show();
            addServiceLog1.BringToFront();
        }

        private void ViewScheduleBtn_Click(object sender, EventArgs e)
        {
            viewSchedule1.ScheduleGridView.Rows.Clear();
            using (MechanicServiceContext context = new MechanicServiceContext())
            {
                var bookings = context.Bookings
                    .Include(b => b.Customer)
                    .Include(b => b.Car)
                    .Where(b => b.Mechanic.MechanicId == loggedInMechanic.MechanicId)
                    .ToList();

                if (bookings != null && bookings.Any())
                {
                    viewSchedule1.NoAppointmentsLbl.Hide();
                    foreach (Booking booking in bookings)
                    {
                        viewSchedule1.ScheduleGridView.Rows.Add(booking.Customer.GetFullName(), booking.Car.GetName(), booking.dateTime.ToString());
                        viewSchedule1.ScheduleGridView.Show();
                    }
                }
                else
                {
                    viewSchedule1.NoAppointmentsLbl.Show();
                    viewSchedule1.ScheduleGridView.Hide();
                    //show no bookings message
                }

            }
            WelcomeLbl.Hide();
            viewSchedule1.Show();
            viewSchedule1.BringToFront();
        }

        private void mechanicDetails1_Load(object sender, EventArgs e)
        {
            mechanicDetails1.loggedInMechanic = this.loggedInMechanic;
            mechanicDetails1.MechanicWorkshopLbl.Text += loggedInMechanic.WorkShopName;
            mechanicDetails1.FirstNameInput.Text = loggedInMechanic.FirstName;
            mechanicDetails1.LastNameInput.Text = loggedInMechanic.LastName;
            mechanicDetails1.MechanicEmailLbl.Text = loggedInMechanic.Email;
        }

        private void addServiceLog1_Load(object sender, EventArgs e)
        {
            addServiceLog1.loggedInMechanic = this.loggedInMechanic;
        }

    }
}
