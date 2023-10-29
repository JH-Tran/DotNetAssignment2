using CarServiceSystem.Forms;
using Microsoft.EntityFrameworkCore;

namespace CarServiceSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static public void Main()
        {
            var context = new MechanicServiceContext();
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            var TestCustomer = new Customer() { FirstName = "Tester", LastName = "Last", Email = "mickey.fish@hotmail.com", Password = "abc" };
            //var TestAdmin = new ServiceAdmin() { FirstName = "Admin", LastName = "LastName", Email = "adminlast@gmail.com", Password = "abc" };
            //var TestCar = new Car() { Make = "Ford", Model = "Ranger", Year = 2017, Odometer = 153290, LicenceNumber = "evv18v", VehicleIdentificationNumber = "1za341241d1d214124", Owner = TestCustomer };
            //var TestMechanic = new Mechanic { FirstName = "Michael", LastName = "Fish", Email = "michael.k.fish@student.uts.edu.au", Password = "123", WorkShopName = "Auto Repairs" };
            //var TestBooking = new Booking { Customer = TestCusomter, Mechanic = TestMechanic, Car = TestCar, dateTime = DateTime.Now };

            //context.Customers.Add(TestCusomter);
            //context.ServiceAdmins.Add(TestAdmin);
            //context.Cars.Add(TestCar);
            //context.Mechanics.Add(TestMechanic);
            //context.Bookings.Add(TestBooking);

            //context.SaveChanges();
          
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginMenu());
            //Application.Run(new CustomerMainMenu());

            //Application.Run(new MechanicMainMenu(mechanic));
            //Application.Run(new ServiceAdminMainMenu());
        }
    }
}