using E_Commerce_API.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_API.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUserAddress> UserAddresses { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartProduct> ShoppingCartProducts { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderProduct>()
                .HasKey(x => new { x.OrderId, x.ProductId });

            builder.Entity<FavoriteProduct>()
                .HasKey(x => new { x.AppUserId, x.ProductId });

            builder.Entity<ShoppingCartProduct>()
                .HasKey(x => new { x.ShoppingCartId, x.ProductId });

            builder.Entity<Product>()
                .HasMany(x => x.ProductImages)
                .WithOne(x => x.Product)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Article>()
                .HasOne(x => x.Image)
                .WithOne(x => x.Article)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<MainCategory>()
                .HasMany(x => x.Categories)
                .WithOne(x => x.MainCategory)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Category>()
                .HasOne(x => x.MainCategory)
                .WithMany(x => x.Categories)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ShoppingCart>()
                .HasOne(x => x.AppUser)
                .WithOne(x => x.ShoppingCart)
                .HasForeignKey<AppUser>(x => x.ShoppingCartId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Maker>().HasMany(x => x.Products)
                .WithOne(x => x.Maker)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Courier>().HasMany(x => x.Orders)
                .WithOne(x => x.Courier)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
