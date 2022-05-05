using AutoMapper;
using GitaWebProject.Data;
using GitaWebProject.Data.Entities;
using GitaWebProject.Interfaces;
using GitaWebProject.Models;

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

        public async Task<UserChangesModel> CreateAsync(UserChangesModel model)
        {
            var item = _mapper.Map<UserChange>(model);
            await _context.AddAsync(item);

            await _context.SaveChangesAsync();

            return _mapper.Map<UserChangesModel>(item);
        }
    }
}
