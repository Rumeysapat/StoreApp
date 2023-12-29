using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories;
public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories{get; set;}

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().ToTable("Urunler"); // Tablo adını Türkçe olarak "Urunler" olarak ayarlıyoruz
        modelBuilder.Entity<Product>().Property(x => x.ProductId).HasColumnName("UrunNumarasi"); // Sütun adını Türkçe olarak "UrunNumarası" 
        modelBuilder.Entity<Product>().Property(x => x.ProductName).HasColumnName("UrunAdi"); // Sütun adını Türkçe olarak "UrunAdi" olarak ayarlıyoruz
        modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnName("Fiyat"); // Sütun adını Türkçe olarak "Fiyat" olarak ayarlıyoruz
        modelBuilder.Entity<Product>().Property(x => x.Description).HasColumnName("Aciklama"); // Sütun adını Türkçe olarak "Aciklama" olarak ayarlıyoruz

        modelBuilder.Entity<Product>().HasData(
          new Product { ProductId = 1, ProductName = "Ürün 1", Price = 49.99m, Description = "Bu ürünün açıklaması 1" },
            new Product { ProductId = 2, ProductName = "Ürün 2", Price = 29.99m, Description = "Bu ürünün açıklaması 2" },
            new Product { ProductId = 3, ProductName = "Ürün 3", Price = 39.99m, Description = "Bu ürünün açıklaması 3" }

        );
         base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().ToTable("Kategori");
        modelBuilder.Entity<Category>().Property(x => x.CategoryId).HasColumnName("KategoriNumarası");
        modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasColumnName("KategoriAdi");

        modelBuilder.Entity<Category>().HasData(
         new Category { CategoryId = 1, CategoryName = "Kategori 1" },
          new Category { CategoryId = 2, CategoryName = "Kategori 2" },
            new Category { CategoryId = 3, CategoryName = "Kategori 3" });


    }

   


}
