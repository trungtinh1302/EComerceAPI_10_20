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
                entity.HasData
                (
                    new Product
                    {
                        ProductID = 1,
                        Title = "Áo thun 1",
                        Description = "Mô tả áo thun số 1",
                        Code = "",
                        ProductCategoryID = 1,
                        CreateTime = DateTime.Now,
                        Content = "Content halshdshaglk",
                        Price = 200,
                        Status = true,
                        Quantity = 50,
                    },
                    new Product
                    {
                        ProductID = 2,
                        Title = "Áo thun 2",
                        Description = "Mô tả áo thun số 1",
                        Code = "",
                        ProductCategoryID = 1,
                        CreateTime = DateTime.Now,
                        Content = "Content halshdshaglk",
                        Price = 200,
                        Status = true,
                        Quantity = 100,
                    },
                    new Product
                    {
                        ProductID = 3,
                        Title = "Áo thun 3",
                        Description = "Mô tả áo thun số 1",
                        Code = "",
                        ProductCategoryID = 1,
                        CreateTime = DateTime.Now,
                        Content = "Content halshdshaglk",
                        Price = 200,
                        Status = true,
                        Quantity = 150,
                    },
                    new Product
                    {
                        ProductID = 4,
                        Title = "Áo thun 4",
                        Description = "Mô tả áo thun số 1",
                        Code = "",
                        ProductCategoryID = 1,
                        CreateTime = DateTime.Now,
                        Content = "Content halshdshaglk",
                        Price = 250,
                        Status = true,
                        Quantity = 50,
                    },
                    new Product
                    {
                        ProductID = 5,
                        Title = "Áo thun 5",
                        Description = "Mô tả áo thun số 5",
                        Code = "",
                        ProductCategoryID = 1,
                        CreateTime = DateTime.Now,
                        Content = "Content halshdshaglk",
                        Price = 120,
                        Status = true,
                        Quantity = 90,
                    },
                    new Product
                    {
                        ProductID = 6,
                        Title = "Áo thun 6",
                        Description = "Mô tả áo thun số 6",
                        Code = "",
                        ProductCategoryID = 1,
                        CreateTime = DateTime.Now,
                        Content = "Content halshdshaglk",
                        Price = 200,
                        Status = true,
                        Quantity = 50,
                    },
                     new Product
                     {
                         ProductID = 7,
                         Title = "Áo thun 7",
                         Description = "Mô tả áo thun số 7",
                         Code = "",
                         ProductCategoryID = 1,
                         CreateTime = DateTime.Now,
                         Content = "Content halshdshaglk",
                         Price = 300,
                         Status = true,
                         Quantity = 70,
                     }
                );
            });
            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");
                entity.HasData(
                        new ProductCategory
                        {
                            ProductCategoryID = 1,
                            Title = "Áo thun",
                            Code = "",
                            Description = "Danh mục áo thun",
                            Position = 1,
                            Status = true,
                            ProductMainCategoryID = 1,
                            CreateTime = DateTime.Now,
                        },
                        new ProductCategory
                        {
                            ProductCategoryID = 2,
                            Title = "Áo Sơmi",
                            Code = "",
                            Description = "Danh mục áo thun",
                            Position = 2,
                            Status = true,
                            ProductMainCategoryID = 1,
                            CreateTime = DateTime.Now,
                        },
                        new ProductCategory
                        {
                            ProductCategoryID = 3,
                            Title = "Áo Khoác",
                            Code = "",
                            Description = "Danh mục áo thun",
                            Position = 1,
                            Status = true,
                            ProductMainCategoryID = 3,
                            CreateTime = DateTime.Now,
                        },

                        new ProductCategory
                        {
                            ProductCategoryID = 4,
                            Title = "Quần Jean",
                            Code = "",
                            Description = "Danh mục quần jean",
                            Position = 4,
                            Status = true,
                            ProductMainCategoryID = 2,
                            CreateTime = DateTime.Now,
                        },
                        new ProductCategory
                        {
                            ProductCategoryID = 5,
                            Title = "Quần Kaki",
                            Code = "",
                            Description = "Danh mục quần kaki",
                            Position = 5,
                            Status = true,
                            ProductMainCategoryID = 2,
                            CreateTime = DateTime.Now,
                        },
                        new ProductCategory
                        {
                            ProductCategoryID = 6,
                            Title = "Quần Jogger",
                            Code = "",
                            Description = "Danh mục quần Jogger",
                            Position = 6,
                            Status = true,
                            ProductMainCategoryID = 2,
                            CreateTime = DateTime.Now,
                        },
                        new ProductCategory
                        {
                            ProductCategoryID = 7,
                            Title = "Quần Tây",
                            Code = "",
                            Description = "Danh mục quần tây",
                            Position = 7,
                            Status = true,
                            ProductMainCategoryID = 2,
                            CreateTime = DateTime.Now,
                        },
                        new ProductCategory
                        {
                            ProductCategoryID = 8,
                            Title = "Quần Short",
                            Code = "",
                            Description = "Danh mục quần short",
                            Position = 7,
                            Status = true,
                            ProductMainCategoryID = 2,
                            CreateTime = DateTime.Now,
                        }
                );
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
