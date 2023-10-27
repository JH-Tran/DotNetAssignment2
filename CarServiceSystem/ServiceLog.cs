using System;

namespace CarServiceSystem
{
    public class ServiceLog
    {
        protected int serviceLogId;
        public Customer? Customer;
        public Mechanic? Mechanic;
        public Car? Car;
        public string Task = "";
        public int CarOdometer;
        public DateTime CompletionDateTime;
        public string GetDateTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }
        public int ServiceLogId {
            get {  return serviceLogId; }
            set {  serviceLogId = value; } 
        }
        public ServiceLog(Customer Customer, Mechanic Mechanic, Car Car, string Task, int CarOdometer)
        {
            this.Customer = Customer;
            this.Mechanic = Mechanic;
            this.Car = Car;
            this.Task = Task;
            this.CarOdometer = CarOdometer;
            CompletionDateTime = DateTime.Now;
        }
        public ServiceLog()
        {

        }
    }
}
