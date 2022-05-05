namespace GitaWebProject.Interfaces
{
    public interface IDeleteProductService
    {
        Task<bool> DeleteProductByIdAsync(int productId);
    }
}
