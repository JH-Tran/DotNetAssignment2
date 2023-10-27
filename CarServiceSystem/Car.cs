using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarServiceSystem
{
    public class Car
    {
        public int CarId { get; }
        public String Make { get; protected set; }
        public String Model {  get; protected set; }
        public int Year { get; protected set; }
        public int Odometer { get; set; }
        public String LicenceNumber { get; protected set; }
        public String VehicleIdentificationNumber { get; protected set; }
        public Customer Owner { get; protected set; }
        public Customer? SecondaryOwner { get; protected set; }
        public List<ServiceLog> ServiceHistory { get; protected set; }

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

        public string GetName()
        {
            return $"{Make} {Model}";
        }

    }
}
