using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaintenanceSystem
{
    class Mechanic : User
    {
        protected String WorkShopName;
        public Mechanic(string FirstName, string LastName, string Email, string Password) : base(FirstName, LastName, Email, Password)
        {
        }
    }
}
