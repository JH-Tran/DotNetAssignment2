using System;

namespace CarServiceSystem
{
    public class ServiceLog
    {
        private int serviceLogId;
        private Customer customer;
        private Mechanic mechanic;
        private Car car;
        private string task = "";
        private int carOdometer;
        private DateTime startDateTime;
        private DateTime completionDateTime;
        public int ServiceLogId {
            get {  return serviceLogId; }
            set {  serviceLogId = value; } 
        }
        public Customer Customer
        {
            get { return customer; }
        }
        public Mechanic Mechanic
        {
            get { return mechanic; }
            set { mechanic = value; }
        }
        public Car Car
        {
            get { return  car; }
            set { car = value; }
        }
        public string Task
        {
            get { return task; }
            set { task = value; }
        }
        public int CarOdometer
        {
            get { return  carOdometer; }
            set { carOdometer = value; }
        }
        public DateTime StartDateTime
        {
            get { return startDateTime; }
            set { startDateTime = value; }
        }
        public DateTime EndDateTime
        {
            get { return completionDateTime; }
            set { completionDateTime = value; }
        }
        public ServiceLog(Customer Customer, Mechanic Mechanic, Car Car, string Task, int CarOdometer)
        {
            customer = Customer;
            mechanic = Mechanic;
            car = Car;
            task = Task;
            carOdometer = CarOdometer;
            completionDateTime = DateTime.Now;
        }
        public ServiceLog()
        {

        }
    }
}
