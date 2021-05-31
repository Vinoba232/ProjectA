using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TransportManagementSystemAPI.Models
{
    public class TransportContext:DbContext
    {
        public TransportContext() : base()
        {

        }
        public TransportContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
    }
}
