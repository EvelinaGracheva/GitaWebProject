using GitaWebProject.Data.Entities;
using GitaWebProject.Data.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GitaWebProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
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

            builder.ConfigureIdentity();

            builder.Entity<DeletedProduct>(b =>
            {
                b.HasOne(t => t.CreatedBy)
                    .WithMany()
                    .HasForeignKey(t => t.CreatedById)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(t => t.ModifiedBy)
                    .WithMany()
                    .HasForeignKey(t => t.ModifiedById)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(t => t.DeletedBy)
                    .WithMany()
                    .HasForeignKey(t => t.DeletedById)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasQueryFilter(t => !t.DeletedAt.HasValue);
            });

            builder.Entity<UserChange>(b =>
            {
                b.HasOne(t => t.CreatedBy)
                    .WithMany()
                    .HasForeignKey(t => t.CreatedById)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(t => t.ModifiedBy)
                    .WithMany()
                    .HasForeignKey(t => t.ModifiedById)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(t => t.DeletedBy)
                    .WithMany()
                    .HasForeignKey(t => t.DeletedById)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasQueryFilter(t => !t.DeletedAt.HasValue);
            });
        }
    }
}
