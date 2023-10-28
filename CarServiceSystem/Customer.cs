using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSystem
{
    public class Customer : User
    {
        public int CustomerId { get; set; }
        protected Car[] OwnCars;
        public Customer(string FirstName, string LastName, string Email, string Password) : base(FirstName, LastName, Email, Password)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.email = Email;
            this.password = Password;
        }

        public Customer()
        {
        }

        public Car[] GetCars()
        {
            return OwnCars;
        }
        
        private void ShowCustomerDetails()
        {
            //Display customer information except password
        }
        private void ShowOwnCar()
        {
            foreach (Car car in OwnCars)
            {
                //Display Car information and button
            }
        }
        private void ViewServiceScheduleTime()
        {
            //Show Booked time
        }
        private void AddCar()
        {
            //Add car to owncar
        }
        private void UpdateCar()
        {
            //Add owner to car
        }
    }
}
