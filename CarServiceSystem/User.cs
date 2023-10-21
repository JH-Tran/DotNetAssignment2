using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSystem
{
    abstract class User
    {
        protected string FirstName;
        protected string LastName;
        protected string Email;
        protected string Password;
        protected User(string FirstName, string LastName, string Email, string Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
