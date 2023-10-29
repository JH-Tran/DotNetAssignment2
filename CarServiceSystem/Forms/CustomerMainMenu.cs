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
        private Customer loggedInCustomer;
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
        public String GetCustomerFullName()
        {
            return loggedInCustomer.GetFullName();
        }
        public void AutoFillCustomerDetailsMenu(Customer Customer)
        {
            loggedInCustomer = Customer;
            CustomerDetails1.AutoFillCustomerDetails(loggedInCustomer);
            ViewAllCars1.AutoFillCustomerCars(loggedInCustomer);
            ViewCustomerSchedule1.LoadCustomerSchedule(Customer);
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
            AddCar1.ResetTextBox();
            AddCar1.AssignLoginCustomer(loggedInCustomer);
        }
        private void HideAllUserControl()
        {
            CustomerDetails1.Hide();
            ViewAllCars1.Hide();
            ViewCustomerSchedule1.Hide();
            AddCar1.Hide();
        }
        public String GetCustomerTextBoxInfomation()
        {
            return CustomerDetails1.GetAllTextBoxString();
        }
    }
}
