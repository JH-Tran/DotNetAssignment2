using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSystem
{
    public class ServiceAdmin : User
    {
        public ServiceAdmin(string FirstName, string LastName, string Email, string Password) : base(FirstName, LastName, Email, Password)
        {
        }
        public ServiceAdmin()
        {

        }
    }
}
