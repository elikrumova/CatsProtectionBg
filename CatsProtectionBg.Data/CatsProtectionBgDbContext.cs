namespace CatsProtectionBg.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class CatsProtectionBgDbContext : IdentityDbContext<User>
    {
        public CatsProtectionBgDbContext(DbContextOptions<CatsProtectionBgDbContext> options)
            : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }

        public DbSet<CharityItem> CharityItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder
            //    .Entity<User>()
            //    .HasIndex(u => u.Email)
            //    .IsUnique();

            builder
                .Entity<Order>()
                .HasKey(o => new { o.UserId, o.CharityItemId });

            builder
                .Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            builder
                .Entity<Order>()
                .HasOne(o => o.CharityItem)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CharityItemId);
       
            base.OnModelCreating(builder);
        }
    }
}
