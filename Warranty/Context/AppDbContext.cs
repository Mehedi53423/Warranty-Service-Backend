using Microsoft.EntityFrameworkCore;
using Warranty.Entities;

namespace Warranty.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceTechnician> ServiceTechnicians { get; set; }
        public DbSet<WarrantyContract> WarrantyContracts { get; set; }
        public DbSet<WarrantyType> WarrantyTypes { get; set; }
    }
}
