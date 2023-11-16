using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCuaHang.EF
{
    public partial class QLBanhangContext : DbContext
    {
        public QLBanhangContext()
            : base("name=QLBanhangContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Product>()
            //    .Property(e => e.Discount)
            //    .HasPrecision(5, 2);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ReceiptDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
