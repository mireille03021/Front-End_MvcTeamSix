namespace ANVI_Mvc.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AnviModel : DbContext
    {
        public AnviModel()
            : base("name=AnviConnection")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DesDetail> DesDetails { get; set; }
        public virtual DbSet<DesSubTitle> DesSubTitles { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.ProductDetails)
                .WithRequired(e => e.Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CreditCard)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductDetail>()
                .HasMany(e => e.Images)
                .WithRequired(e => e.ProductDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductDetail>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.ProductDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DesDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DesSubTitles)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipper>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShippingID);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.ProductDetails)
                .WithRequired(e => e.Size)
                .WillCascadeOnDelete(false);
        }
    }
}
