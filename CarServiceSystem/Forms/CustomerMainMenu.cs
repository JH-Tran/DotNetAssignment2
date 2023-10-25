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
    public partial class CustomerMainMenu : Form
    {
        public CustomerMainMenu()
        {
            InitializeComponent();
            HideAllUserControl();
        }

        private void ViewCustomerDetailClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            customerDetails1.Show();
            customerDetails1.BringToFront();
        }
        private void ViewAllCarsClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            viewAllCars1.Show();
            viewAllCars1.BringToFront();
        }
        private void ViewScheduleClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            viewCustomerSchedule1.Show();
            viewCustomerSchedule1.BringToFront();
        }

        private void AddCarClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            addCar1.Show();
            addCar1.BringToFront();
        }

        private void HideAllUserControl()
        {
            customerDetails1.Hide();
            viewAllCars1.Hide();
            viewCustomerSchedule1.Hide();
            addCar1.Hide();
        }
    }
}
