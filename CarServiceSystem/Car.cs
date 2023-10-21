using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSystem
{
    class Car
    {
        protected String Make;
        protected String Model;
        protected int Year;
        protected String LicenceNumber;
        protected String VehicleIdentificationNumber;
        protected Customer Owner;
        protected Customer[] SecondaryOwner;
        protected ServiceLog[] ServiceHistory;
    }
}
