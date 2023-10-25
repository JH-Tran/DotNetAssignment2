using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarServiceSystem
{
    public class Car
    {
        public int CarId { get; }
        public String Make { get; set; }
        public String Model {  get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
        public String LicenceNumber { get; set; }
        public String VehicleIdentificationNumber { get; set; }


        public int OwnerId { get; set; }
        public Customer Owner { get; set; }
        public int? SecondaryOwnerId { get; set; }
        public Customer? SecondaryOwner { get; set; }
        public ServiceLog[]? ServiceHistory { get; set; }


        public Car()
        {

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
            this.ServiceHistory = getServiceHistory(LicenceNumber);
        }

        private ServiceLog[]? getServiceHistory(String LicenceNumber)
        {
            return null;
        }
    }
}
