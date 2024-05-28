using Microsoft.EntityFrameworkCore;
using RetailStoreManagement.Models;

namespace RetailStoreManagement.Data
{
    public class RetailStoreContext : DbContext
    {
        public RetailStoreContext(DbContextOptions<RetailStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
       
    }
}
