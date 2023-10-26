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
        private Customer CustomerSignIn;
        public CustomerMainMenu()
        {
            InitializeComponent();
            HideAllUserControl();
        }
        public CustomerMainMenu(Customer Customer)
        {
            InitializeComponent();
            HideAllUserControl();
            AutoFillCustomerDetailsMenu(Customer);
        }
        public String PrintCustomerFullName()
        {
            return CustomerSignIn.GetFullName();
        }
        public void AutoFillCustomerDetailsMenu(Customer Customer)
        {
            CustomerSignIn = Customer;
            CustomerDetails1.AutoFillCustomerDetails(CustomerSignIn);
            ViewAllCars1.AutoFillCustomerCars(CustomerSignIn.GetCars());
            //ViewScheduleClick1.AutoFillCustomerSchedule();
        }
        private void ViewCustomerDetailClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            CustomerDetails1.Show();
            CustomerDetails1.BringToFront();
        }
        private void ViewAllCarsClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            ViewAllCars1.Show();
            ViewAllCars1.BringToFront();
        }
        private void ViewScheduleClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            ViewCustomerSchedule1.Show();
            ViewCustomerSchedule1.BringToFront();
        }

        private void AddCarClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            AddCar1.Show();
            AddCar1.BringToFront();
        }

        private void HideAllUserControl()
        {
            CustomerDetails1.Hide();
            ViewAllCars1.Hide();
            ViewCustomerSchedule1.Hide();
            AddCar1.Hide();
        }
    }
}
