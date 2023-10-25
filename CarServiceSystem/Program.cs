using CarServiceSystem.Forms;

namespace CarServiceSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using(var context = new MechanicServiceContext())
            {
                context.Database.EnsureCreated();
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MechanicMainMenu());
            }

        }
    }
}