using GitaWebProject.Interfaces;
using GitaWebProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace GitaWebProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet("All")]
        public async Task<List<ProductModel>> AllAsync()
            => await _productService.AllAsync();

        [HttpGet("GetById")]
        public async Task<ProductModel?> GetByIdAsync(int id)
            => await _productService.GetByIdAsync(id);

        [HttpPut("Update")]
        public async Task<ProductModel?> UpdateAsync(ProductUpdateModel model)
        {
            if (ModelState.IsValid)
                return await _productService.UpdateAsync(model);
            else
                return null;
        }

        [HttpPost("Create")]
        public async Task<ProductModel> CreateAsync(ProductCreateModel model)
        {
            if (ModelState.IsValid)
                return await _productService.CreateAsync(model);
            else
                return null;
        }

        [HttpPost("Filter")]
        public async Task<List<ProductModel>> FilterAsync(FilterModel model)
            => await _productService.FilterAsync(model);

        [HttpDelete("Delete")]
        public async Task<ProductModel?> DeleteAsync(int id)
            => await _productService.DeleteAsync(id);
    }
}