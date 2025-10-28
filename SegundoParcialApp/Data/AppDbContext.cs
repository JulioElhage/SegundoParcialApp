using Microsoft.EntityFrameworkCore;
using SegundoParcialApp.Models;

namespace SegundoParcialApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}