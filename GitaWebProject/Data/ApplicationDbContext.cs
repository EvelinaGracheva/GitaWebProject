using GitaWebProject.Data.Entities;
using GitaWebProject.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GitaWebProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public virtual DbSet<DeletedProduct> DeletedProducts { get; set; } = null!;
        public virtual DbSet<Product> Product { get; set; } = null!;
        public virtual DbSet<UserChange> UserChanges { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Production");

            builder.Entity<DeletedProduct>(b =>
            {
                b.Property(t => t.ListPrice).HasPrecision(18, 4);
                b.Property(t => t.StandardCost).HasPrecision(18, 4);
                b.Property(t => t.Weight).HasPrecision(18, 4);
            });

            builder.Entity<Product>(b =>
            {
                b.Property(t => t.ListPrice).HasPrecision(18, 4);
                b.Property(t => t.StandardCost).HasPrecision(18, 4);
                b.Property(t => t.Weight).HasPrecision(18, 4);
            });
        }
    }
}
