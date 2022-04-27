using Microsoft.AspNetCore.Identity;

namespace GitaWebProject.Data.Entities.Identity
{
    public class UserClaim : IdentityUserClaim<Guid>
    {
        public virtual User? User { get; set; }
    }
}
