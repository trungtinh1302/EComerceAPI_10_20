using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Model
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountCategory> AccountCategories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<ArticleMainCategory> ArticleMainCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactCategory> ContactCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductMainCategory> ProductMainCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");
            });
            modelBuilder.Entity<AccountCategory>(entity =>
            {
                entity.ToTable("AccountCategory");
                entity.HasData(new AccountCategory
                {
                    Title = "Client Account 1",
                    Description = "Tài khoản khách hàng 1",
                    Position = 1,
                    Status = true,
                    AccountCategoryID = 1
                }, new AccountCategory
                {
                    Title = "Client Account 2",
                    Description = "Tài khoản khách hàng 2",
                    Position = 1,
                    Status = true,
                    AccountCategoryID = 2
                });
            });
            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("Article");
            });
            modelBuilder.Entity<ArticleCategory>(entity =>
            {
                entity.ToTable("ArticleCategory");
            });
            modelBuilder.Entity<ArticleMainCategory>(entity =>
            {
                entity.ToTable("ArticleMainCategory");
            });
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");
            });
            modelBuilder.Entity<ContactCategory>(entity =>
            {
                entity.ToTable("ContactCategory");
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
            });
            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");
            });
            modelBuilder.Entity<ProductMainCategory>(entity =>
            {
                entity.ToTable("ProductMainCategory");
                entity.HasData(
                    new ProductMainCategory
                    {
                        ProductMainCategoryID = 1,
                        Title = "Áo",
                        Description = "Danh mục áo",
                        CreateTime = DateTime.Now,
                        Code = "1",
                        Position = 1,
                        Status = true,
                    },
                    new ProductMainCategory
                    {
                        ProductMainCategoryID = 2,
                        Title = "Quần",
                        Description = "Danh mục quần",
                        CreateTime = DateTime.Now,
                        Code = "2",
                        Position = 2,
                        Status = true,
                    },
                    new ProductMainCategory
                    {
                        ProductMainCategoryID = 3,
                        Title = "Giày",
                        Description = "Danh mục giày",
                        CreateTime = DateTime.Now,
                        Code = "3",
                        Position = 3,
                        Status = true,
                    },
                    new ProductMainCategory
                    {
                        ProductMainCategoryID = 4,
                        Title = "Phụ kiện",
                        Description = "Danh mục phụ kiện",
                        CreateTime = DateTime.Now,
                        Code = "4",
                        Position = 4,
                        Status = true,
                    },
                    new ProductMainCategory
                    {
                        ProductMainCategoryID = 5,
                        Title = "Collection",
                        Description = "Danh mục bộ sưu tập",
                        CreateTime = DateTime.Now,
                        Code = "5",
                        Position = 5,
                        Status = true,
                    }
                );
            });
        }
    }
}
