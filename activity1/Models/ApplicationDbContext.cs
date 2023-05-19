using Microsoft.EntityFrameworkCore;

namespace LaptopStoreProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Confirmation>Confirmations{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BSC-PG02KEAN\\SQLEXPRESS;DataBase=Phase4ProjectDatabase;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
