using CarServiceSystem.Forms;

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
            context.Database.EnsureCreated();

            var TestCusomter = new Customer() { FirstName = "Tester", LastName = "Last", Email = "test@gmail.com", Password = "abc" };
            var TestAdmin = new ServiceAdmin() { FirstName = "Admin", LastName = "LastName", Email = "adminlast@gmail.com", Password = "abc" };
            var TestCar = new Car() { Make = "Ford", Model = "Ranger", Year = 2017, Odometer = 153290, LicenceNumber = "evv18v", VehicleIdentificationNumber = "1za341241d1d214124", Owner = TestCusomter };
            var TestMechanic = new Mechanic { FirstName = "Michael", LastName = "Fish", Email = "michael.k.fish@student.uts.edu.au", Password = "123", WorkShopName = "Good Will" };

            context.Customers.Add(TestCusomter);
            context.ServiceAdmins.Add(TestAdmin);
            context.Cars.Add(TestCar);
            context.Mechanics.Add(TestMechanic);
            context.Cars.Add(TestCar);

            context.SaveChanges();

            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(new CustomerMainMenu());
            //Application.Run(new MechanicMainMenu());
            //Application.Run(new ServiceAdminMainMenu());
        }
    }
}