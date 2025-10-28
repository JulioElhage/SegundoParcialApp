using Microsoft.EntityFrameworkCore;
using SegundoParcialApp.Models;

namespace SegundoParcialApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Definir las tablas en la base de datos
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        // Configuración adicional de los modelos y tablas en la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración para el campo 'Price' en 'Product' para usar decimal con precisión 18,2
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");  // Especifica el tipo de columna y la precisión
            
            // Configuración para el campo 'Total' en 'Order'
            modelBuilder.Entity<Order>()
                .Property(o => o.Total)
                .HasColumnType("decimal(18,2)");  // Especifica el tipo de columna y la precisión
        }
    }
}