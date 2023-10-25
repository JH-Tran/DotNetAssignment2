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
        public MechanicMainMenu()
        {
            InitializeComponent();
        }

        private void MechanicMainMenu_Load(object sender, EventArgs e)
        {

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
    }
}
