using Doan.Entities;
using Doan.Entities.SubTable;
using Microsoft.EntityFrameworkCore;

namespace Doan.Service
{
    public class Context : DbContext
    {
        public DbSet<GeneralProduct> GeneralProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder b)
        {
            b.ApplyConfiguration(new ProductConfig());
            b.Initial();
            
        }
    }

    public static class DuLieuMau
    {
        public static void Initial(this ModelBuilder b)
        {
            b.Entity<Category>().HasData(
                new Category { ID = 1, Name = "quan ao" }
                );
            b.Entity<Category>().HasData(
              new Category { ID = 2, Name = "quan" }
              );
        }
    }
}
