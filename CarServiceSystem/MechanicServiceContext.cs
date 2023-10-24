using Microsoft.EntityFrameworkCore;

namespace CarServiceSystem
{
    public class MechanicServiceContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceAdmin> ServiceAdmins { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqlocaldb;Database=MechanicServiceDb;Trusted_Connection=True");

        }
    }
}
