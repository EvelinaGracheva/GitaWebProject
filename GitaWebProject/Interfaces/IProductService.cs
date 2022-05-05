using GitaWebProject.Models;

namespace GitaWebProject.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductModel>> AllAsync();
        Task<ProductModel> CreateAsync(ProductCreateModel model);
        Task<ProductModel?> DeleteAsync(int id);
        Task<List<ProductModel>> FilterAsync(FilterModel model);
        Task<ProductModel?> GetByIdAsync(int id);
        Task<ProductModel?> UpdateAsync(ProductUpdateModel model);
    }
}
