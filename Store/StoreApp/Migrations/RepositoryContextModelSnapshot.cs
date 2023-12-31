﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("KategoriNumarası");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT")
                        .HasColumnName("KategoriAdi");

                    b.HasKey("CategoryId");

                    b.ToTable("Kategori", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Kategori 1"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Kategori 2"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Kategori 3"
                        });
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("UrunNumarasi");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("Aciklama");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT")
                        .HasColumnName("Fiyat");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT")
                        .HasColumnName("UrunAdi");

                    b.HasKey("ProductId");

                    b.ToTable("Urunler", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Bu ürünün açıklaması 1",
                            Price = 49.99m,
                            ProductName = "Ürün 1"
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Bu ürünün açıklaması 2",
                            Price = 29.99m,
                            ProductName = "Ürün 2"
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Bu ürünün açıklaması 3",
                            Price = 39.99m,
                            ProductName = "Ürün 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
