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
        public DbSet<AccountCategory> AccountCategory { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleCategory> ArticleCategory { get; set; }
        public DbSet<ArticleMainCategory> ArticleMainCategory { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactCategory> ContactCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductMainCategory> ProductMainCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity => {
                entity.ToTable("Accounts");
            });
            modelBuilder.Entity<AccountCategory>(entity => {
                entity.ToTable("AccountCategories");
            });
            modelBuilder.Entity<Article>(entity => {
                entity.ToTable("Articles");
            });
            modelBuilder.Entity<ArticleCategory>(entity => {
                entity.ToTable("ArticleCategories");
            });
            modelBuilder.Entity<ArticleMainCategory>(entity => {
                entity.ToTable("ArticleMainCategories");
            });
            modelBuilder.Entity<Contact>(entity => {
                entity.ToTable("Contacts");
            });
            modelBuilder.Entity<ContactCategory>(entity => {
                entity.ToTable("ContactCategories");
            });
            modelBuilder.Entity<Product>(entity => {
                entity.ToTable("Products");
            });
            modelBuilder.Entity<ProductCategory>(entity => {
                entity.ToTable("ProductCategories");
            });
            modelBuilder.Entity<ProductMainCategory>(entity => {
                entity.ToTable("ProductMainCategories");
            });
        }
    }
}
