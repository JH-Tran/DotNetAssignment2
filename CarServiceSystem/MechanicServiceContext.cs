﻿using Microsoft.EntityFrameworkCore;

namespace CarServiceSystem
{
    public class MechanicServiceContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceAdmin> ServiceAdmins { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ServiceLog> ServiceLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MechanicServiceDb;Trusted_Connection=True");
        }
    }
}
