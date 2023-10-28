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
            //mechanicDetails1.Hide();
            //lookupCar1.Hide();
            //addServiceLog1.Hide();
            //viewSchedule1.Hide();
        }

        private void PersonalDetailsBtn_Click(object sender, EventArgs e)
        {
            mechanicDetails1.Show();
            mechanicDetails1.BringToFront();
        }

        private void LookupCarBtn_Click(object sender, EventArgs e)
        {
            lookupCar1.Show();
            lookupCar1.BringToFront();
        }

        private void AddServiceLogBtn_Click(object sender, EventArgs e)
        {
            addServiceLog1.Show();
            addServiceLog1.BringToFront();
        }

        private void ViewScheduleBtn_Click(object sender, EventArgs e)
        {
            viewSchedule1.Show();
            viewSchedule1.BringToFront();
        }

        private void mechanicDetails1_Load(object sender, EventArgs e)
        {
            mechanicDetails1.loggedInMechanic = this.loggedInMechanic;  
            mechanicDetails1.MechanicWorkshopLbl.Text += loggedInMechanic.WorkShopName;
            mechanicDetails1.FirstNameInput.Text = loggedInMechanic.FirstName;
            mechanicDetails1.LastNameInput.Text = loggedInMechanic.LastName;
            mechanicDetails1.EmailInput.Text = loggedInMechanic.Email;
        }

        private void addServiceLog1_Load(object sender, EventArgs e)
        {
            addServiceLog1.loggedInMechanic = this.loggedInMechanic;
        }
    }
}
