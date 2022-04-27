using Microsoft.AspNetCore.Identity;

namespace GitaWebProject.Data.Entities.Identity
{
    public class Role : IdentityRole<Guid>
    {
        #region Identity

        public virtual ICollection<UserRole> UserRoles { get; set; } = null!;

        public virtual ICollection<RoleClaim> RoleClaims { get; set; } = null!;

        #endregion
    }
}
