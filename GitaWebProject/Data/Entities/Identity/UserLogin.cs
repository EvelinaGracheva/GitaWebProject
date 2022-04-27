using Microsoft.AspNetCore.Identity;

namespace GitaWebProject.Data.Entities.Identity
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public virtual User? User { get; set; }
    }
}
