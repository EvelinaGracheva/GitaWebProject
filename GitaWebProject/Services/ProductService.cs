using GitaWebProject.Interfaces;

namespace GitaWebProject.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }
    }
}
