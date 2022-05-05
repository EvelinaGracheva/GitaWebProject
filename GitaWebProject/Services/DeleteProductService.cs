using AutoMapper;
using GitaWebProject.Data;
using GitaWebProject.Interfaces;

namespace GitaWebProject.Services
{
    public class DeleteProductService: IDeleteProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteProductService> _logger;

        public DeleteProductService(ApplicationDbContext context, IMapper mapper, ILogger<DeleteProductService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
    }
}
