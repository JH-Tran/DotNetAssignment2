using Microsoft.EntityFrameworkCore;

namespace CarServiceSystem
{
    public class MechanicServiceContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqlocaldb;Database=MechanicServiceDb;Trusted_Connection=True");

        }
    }
}
