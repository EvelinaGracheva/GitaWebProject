using GitaWebProject.Data.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace GitaWebProject.Data
{
    public static class IdentityExtensions
    {
        public static void ConfigureIdentity(this ModelBuilder builder)
        {
            builder.Entity<User>(b =>
            {
                b.ToTable(nameof(ApplicationDbContext.Users));

                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User!)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User!)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User!)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User!)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            builder.Entity<UserClaim>(b =>
            {
                b.ToTable(nameof(ApplicationDbContext.UserClaims));
            });

            builder.Entity<UserLogin>(b =>
            {
                b.ToTable(nameof(ApplicationDbContext.UserLogins));
            });

            builder.Entity<UserToken>(b =>
            {
                b.ToTable(nameof(ApplicationDbContext.UserTokens));
            });

            builder.Entity<Role>(b =>
            {
                b.ToTable(nameof(ApplicationDbContext.Roles));

                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role!)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role!)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });

            builder.Entity<RoleClaim>(b =>
            {
                b.ToTable(nameof(ApplicationDbContext.RoleClaims));
            });

            builder.Entity<UserRole>(b =>
            {
                b.ToTable(nameof(ApplicationDbContext.UserRoles));
            });
        }
    }
}
