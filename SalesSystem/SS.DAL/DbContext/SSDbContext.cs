using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SS.Model.Models;

namespace SS.DAL
{
    public partial class SSDbContext : DbContext
    {
        public SSDbContext()
        {
        }

        public SSDbContext(DbContextOptions<SSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<CorrelativeNumber> CorrelativeNumbers { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<MenuRole> MenuRoles { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SaleDetail> SaleDetails { get; set; } = null!;
        public virtual DbSet<SalesDocumentType> SalesDocumentTypes { get; set; } = null!;
        public virtual DbSet<Shop> Shops { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Configuration");

                entity.Property(e => e.Property)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorrelativeNumber>(entity =>
            {
                entity.Property(e => e.Management)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Controller)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PageAction)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.FatherMenu)
                    .WithMany(p => p.InverseFatherMenu)
                    .HasForeignKey(d => d.FatherMenuId)
                    .HasConstraintName("FK__Menus__FatherMen__37A5467C");
            });

            modelBuilder.Entity<MenuRole>(entity =>
            {
                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuRoles)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__MenuRoles__MenuI__3F466844");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MenuRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__MenuRoles__RoleI__3E52440B");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__Catego__49C3F6B7");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreactionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.ClientDocument)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Tax).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.SalesDocumentType)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesDocumentTypeId)
                    .HasConstraintName("FK__Sales__SalesDocu__52593CB8");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Sales__UserId__534D60F1");
            });

            modelBuilder.Entity<SaleDetail>(entity =>
            {
                entity.ToTable("SaleDetail");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductManufacturer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleDetails)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK__SaleDetai__SaleI__571DF1D5");
            });

            modelBuilder.Entity<SalesDocumentType>(entity =>
            {
                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.ToTable("Shop");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__RoleId__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
