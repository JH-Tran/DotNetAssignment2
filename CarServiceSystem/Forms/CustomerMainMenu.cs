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
        }

        private void ViewCustomerDetailClick(object sender, EventArgs e)
        {
            customerDetails1.Show();
            customerDetails1.BringToFront();
            viewAllCars1.Hide();
        }
        private void ViewAllCarsClick(object sender, EventArgs e)
        {
            customerDetails1.Show();
            viewAllCars1.Show();
            viewAllCars1.BringToFront();
        }
        private void ViewScheduleClick(object sender, EventArgs e)
        {

        }

        private void AddCarClick(object sender, EventArgs e)
        {
            this.Hide();
            AddCar AddCar = new AddCar();
            AddCar.ShowDialog();
        }
    }
}
