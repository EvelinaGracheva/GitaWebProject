using GitaWebProject.Models;

namespace GitaWebProject.Interfaces
{
    public interface IUserChangesService
    {
        Task<UserChangesModel> CreateAsync(UserChangesModel model);
    }
}
