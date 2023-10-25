using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarServiceSystem
{
    public class Car
    {
        protected int CarId { get; }
        protected String Make { get; set; }
        protected String Model {  get; set; }
        protected int Year { get; set; }
        protected String LicenceNumber { get; set; }
        protected String VehicleIdentificationNumber { get; set; }

        protected int OwnerId { get; set; }
        protected Customer Owner { get; set; }
        protected int? SecondaryOwnerId { get; set; }
        protected Customer? SecondaryOwner { get; set; }
        protected ServiceLog[]? ServiceHistory { get; set; }


        public Car()
        {

        }

        public Car(String Make, String Model, int Year, String LicenceNumber, String VehicleIdentificationNumber, Customer Owner)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
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
