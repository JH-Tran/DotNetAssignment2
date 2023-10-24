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
        protected Car[] OwnCars;
        public Customer(string FirstName, string LastName, string Email, string Password) : base(FirstName, LastName, Email, Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
