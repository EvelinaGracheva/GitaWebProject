using Microsoft.AspNetCore.Identity;

namespace GitaWebProject.Data.Entities.Identity
{
    public class User : IdentityUser<Guid>
    {
        #region Identity

        public virtual ICollection<UserClaim> Claims { get; set; } = null!;

        public virtual ICollection<UserLogin> Logins { get; set; } = null!;

        public virtual ICollection<UserToken> Tokens { get; set; } = null!;

        public virtual ICollection<UserRole> UserRoles { get; set; } = null!;

        #endregion
    }
}
