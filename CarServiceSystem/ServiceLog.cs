using System;

namespace CarServiceSystem
{
    public class ServiceLog
    {
        protected int ID;
        protected Customer? Customer;
        protected Mechanic? Mechanic;
        protected Car? Car;
        protected string Task = "";
        protected int CarOdometer;
        protected DateTime CurrentDateTime;
        public string GetDateTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }
        public ServiceLog(int ID, Customer Customer, Mechanic Mechanic, Car Car, string Task, int CarOdometer)
        {
            this.ID = ID;
            this.Customer = Customer;
            this.Mechanic = Mechanic;
            this.Car = Car;
            this.Task = Task;
            this.CarOdometer = CarOdometer;
            CurrentDateTime = DateTime.Now;
        }
    }
}
