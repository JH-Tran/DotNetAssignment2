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
            using (var context = new MechanicServiceContext())
            {
                context.Database.EnsureCreated();

                var TestCusomter = new Customer() { userID = 12345, FirstName = "Tester", LastName = "Last", Email = "test@gmail.com", Password = "abc" };

                context.Customers.Add(TestCusomter);

                context.SaveChanges();
            }


            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(new CustomerMainMenu());
            //Application.Run(new MechanicMainMenu());
            //Application.Run(new ServiceAdminMainMenu());
        }
    }
}