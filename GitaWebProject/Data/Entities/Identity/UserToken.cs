using Microsoft.AspNetCore.Identity;

namespace GitaWebProject.Data.Entities.Identity
{
    public class UserToken : IdentityUserToken<Guid>
    {
        public virtual User? User { get; set; }
    }
}
