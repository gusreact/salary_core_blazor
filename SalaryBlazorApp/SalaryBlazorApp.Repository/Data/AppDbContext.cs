using Microsoft.EntityFrameworkCore;
using SalaryBlazorApp.Repository.Models;

namespace SalaryBlazorApp.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
