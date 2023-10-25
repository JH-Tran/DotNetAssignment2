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
        public static Mechanic mechanic = new Mechanic("Michael", "Fish", "michael.k.fish@student.uts.edu.au", "123");
        static Customer tempOwner = new Customer("Test", "Owner", "Test.owner@hotmail.com", "123");
        public static Car[] cars = new Car[]
        {
                new Car("Ford", "Ranger", 2017, 153290, "evv18v", "1za341241d1d214124", tempOwner),
                new Car("Volkswagen", "Golf", 2008, 121851, "bfg23x", "32zhs21357080asd8124", tempOwner),
                new Car("Mazda", "2", 2012, 88962, "btz12a", "92zasz1248a9as815dd", tempOwner)
        };

        public MechanicMainMenu()
        {
            mechanic.WorkShopName = "TestWorkshop";
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
            mechanicDetails1.MechanicWorkshopLbl.Text = mechanic.WorkShopName;
            mechanicDetails1.FirstNameInput.Text = mechanic.FirstName;
            mechanicDetails1.LastNameInput.Text = mechanic.LastName;
            mechanicDetails1.EmailInput.Text = mechanic.Email;
        }
    }
}
