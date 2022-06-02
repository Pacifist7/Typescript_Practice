using CoffeeShopRegistration_Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopRegistration_Lab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
