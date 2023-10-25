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

        private void ViewCustomerDetail_Click(object sender, EventArgs e)
        {
            customerDetails1.Show();
            customerDetails1.BringToFront();
            viewAllCars1.Hide();
        }
        private void ViewAllCars(object sender, EventArgs e)
        {
            customerDetails1.Show();
            viewAllCars1.Show();
            viewAllCars1.BringToFront();
        }
        private void ViewSchedule(object sender, EventArgs e)
        {

        }

        private void AddCar(object sender, EventArgs e)
        {

        }
    }
}
