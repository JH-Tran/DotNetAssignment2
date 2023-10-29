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
        public void UpdateCustomerDetails()
        {
            using (MechanicServiceContext context = new MechanicServiceContext())
            {
                var result = context.Customers.SingleOrDefault(customerContext => customerContext.Email == Email);
                if (result != null)
                {
                    firstName = result.FirstName;
                    lastName = result.LastName;
                }
            }
        }
    }
}
