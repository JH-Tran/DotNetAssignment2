namespace CarServiceSystem
{
    public class Car
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
