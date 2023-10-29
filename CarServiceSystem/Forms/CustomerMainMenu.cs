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
        //Initalise the customer main menu.
        //Creates all components and hide the interfaces.
        //The current login customer is recorded
        public CustomerMainMenu(Customer Customer)
        {
            InitializeComponent();
            HideAllUserControl();
            loggedInCustomer = Customer;
        }
        //Returns the full name of the current login user
        public String GetCustomerFullName()
        {
            return loggedInCustomer.GetFullName();
        }
        //Button that will hide every interface before showing the customer's details
        //Updates the customer interface in case any data has changed.
        private void ViewCustomerDetailClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            CustomerDetails1.Show();
            CustomerDetails1.BringToFront();
            CustomerDetails1.UpdateCustomerDetailInterface(loggedInCustomer);
        }
        //Button that will hide every interface before showing the customer's car details
        //Updates the customer details of their car based on what they own in the database.
        private void ViewAllCarsClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            ViewAllCars1.Show();
            ViewAllCars1.BringToFront();
            ViewAllCars1.UpdateCustomerCars(loggedInCustomer);
        }
        //Button that will hide every interface before showing the customer's up coming schedules
        //Update the customer's schedules in case of their schedule changing
        private void ViewScheduleClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            ViewCustomerSchedule1.Show();
            ViewCustomerSchedule1.BringToFront();
            ViewCustomerSchedule1.UpdateCustomerSchedule(loggedInCustomer);
        }
        //Button that will hide every interface before showing the customer's up coming schedules.
        //Resets the textbox to refresh the interface from previous information.
        //Assignes the login customer to the interface to reference as the owner of the car.
        private void AddCarClick(object sender, EventArgs e)
        {
            HideAllUserControl();
            AddCar1.Show();
            AddCar1.BringToFront();
            AddCar1.ResetTextBox();
            AddCar1.AssignLoginCustomer(loggedInCustomer);
        }
        //Hides all the interfaces
        private void HideAllUserControl()
        {
            CustomerDetails1.Hide();
            ViewAllCars1.Hide();
            ViewCustomerSchedule1.Hide();
            AddCar1.Hide();
        }
        //Get customer text box information from customer details interface.
        //(Unit testing)
        public String GetCustomerTextBoxInfomation()
        {
            return CustomerDetails1.GetAllTextBoxString();
        }

    }
}
