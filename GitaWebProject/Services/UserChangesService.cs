using AutoMapper;
using GitaWebProject.Data;
using GitaWebProject.Interfaces;

namespace GitaWebProject.Services
{
    public class UserChangesService : IUserChangesService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<UserChangesService> _logger;

        public UserChangesService(ApplicationDbContext context, IMapper mapper, ILogger<UserChangesService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
    }
}
