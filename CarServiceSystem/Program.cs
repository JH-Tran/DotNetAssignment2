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

/*            var TestCusomter = new Customer() { FirstName = "Beta", LastName = "Tester", Email = "testBeta@gmail.com", Password = "abc" };
            var TestAdmin = new ServiceAdmin() { FirstName = "Watcher", LastName = "LastName", Email = "adminWatch@gmail.com", Password = "abc" };
            var TestCar = new Car() { Make = "Speed", Model = "Ranger", Year = 2017, Odometer = 153290, LicenceNumber = "wev18v", VehicleIdentificationNumber = "1za341241d1d2141153", Owner = TestCusomter };
            var TestMechanic = new Mechanic { FirstName = "Michael", LastName = "Fish", Email = "michael.k.fish@student.uts.edu.au", Password = "123", WorkShopName = "Auto Repairs" };
            var TestBooking = new Booking { Customer = TestCusomter, Mechanic = TestMechanic, Car = TestCar, dateTime = DateTime.Today };

            context.Customers.Add(TestCusomter);
            context.ServiceAdmins.Add(TestAdmin);
            context.Cars.Add(TestCar);
            context.Mechanics.Add(TestMechanic);
            context.Bookings.Add(TestBooking);

            context.SaveChanges();*/

            /*var returnedCar = context.Cars
                  .Include(c => c.Owner)
                  .Where(c => c.LicenceNumber == "evv18v")
                  .FirstOrDefault();*/

/*            var returnedCustomer = context.Customers
                .Where(c => c.Email == "testBeta@gmail.com")
                .FirstOrDefault();*/

            //Need login function that retrieves the corresponding user and passes it to the right menu
            Customer TestCustomer = context.Customers.FirstOrDefault(m => m.Email == "testBeta@gmail.com") ?? null!;

            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(new CustomerMainMenu(TestCustomer));
            //Application.Run(new MechanicMainMenu(mechanic));
            //Application.Run(new ServiceAdminMainMenu());
        }
    }
}