using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarServiceSystem
{
    public class Car
    {
        protected String make;
        protected String model;
        protected int year;
        protected int odometer;
        protected String licenseNumber;
        protected String vehicleIdentificationNumber;
        protected Customer owner;
        protected Customer? secondaryOwner;
        protected List<ServiceLog> serviceHistory = new List<ServiceLog>();
        public int CarId { get; set;} 
        
        public String Make {
            get { return make; }
            set { make = value; } 
        }
        public String Model {
            get { return model; }
            set {  model = value; }
        }
        public int Year {
            get { return year; }
            set { year = value; }
        }
        public int Odometer {
            get { return odometer; } 
            set { odometer = value; } 
        }
        public String LicenceNumber {
            get { return licenseNumber; }
            set { licenseNumber = value; } 
        }
        public String VehicleIdentificationNumber {
            get { return vehicleIdentificationNumber; }
            set { vehicleIdentificationNumber = value; } 
        }
        public Customer Owner {
            get { return owner; }
            set {  owner = value; }
        }
        public Customer? SecondaryOwner {
            get { return secondaryOwner; } 
            set {  secondaryOwner = value; }
        }
        public List<ServiceLog> ServiceHistory {
            get { return serviceHistory; }
            set {  serviceHistory = value; }
        }

        public Car(String Make, String Model, int Year, int Odometer, String LicenceNumber, String VehicleIdentificationNumber, Customer Owner)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Odometer = Odometer;
            this.LicenceNumber = LicenceNumber;
            this.VehicleIdentificationNumber = VehicleIdentificationNumber;
            this.Owner = Owner;
            this.ServiceHistory = new List<ServiceLog>();
        }
        public Car() { }

        public string GetName()
        {
            return $"{Make} {Model} {Year}";
        }

    }
}
