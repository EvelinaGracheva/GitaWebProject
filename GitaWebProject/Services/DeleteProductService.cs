using AutoMapper;
using GitaWebProject.Data;
using GitaWebProject.Data.Entities;
using GitaWebProject.Interfaces;
using GitaWebProject.Models;

namespace GitaWebProject.Services
{
    public class DeleteProductService : IDeleteProductService
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

        public async Task<bool> DeleteProductByIdAsync(int productId)
        {
            var product = await _context.Product.FindAsync(productId);

            if (product != null)
            {
                using var transaction = _context.Database.BeginTransaction();
                {
                    try
                    {
                        var model = new DeletedProductModel()
                        {
                            ProductID = productId,
                            Class = product.Class,
                            Color = product.Color,
                            DaysToManufacture = product.DaysToManufacture,
                            DiscontinuedDate = product.DiscontinuedDate,
                            FinishedGoodsFlag = product.FinishedGoodsFlag,
                            ListPrice = product.ListPrice,
                            MakeFlag = product.MakeFlag,
                            ModifiedDate = product.ModifiedDate,
                            Name = product.Name,
                            ProductLine = product.ProductLine,
                            ProductNumber = product.ProductNumber,
                            ReorderPoint = product.ReorderPoint,
                            Rowguid = product.Rowguid,
                            SafetyStockLevel = product.SafetyStockLevel,
                            SellEndDate = product.SellEndDate,
                            SellStartDate = product.SellStartDate,
                            Size = product.Size,
                            StandardCost = product.StandardCost,
                            Style = product.Style,
                            Weight = product.Weight,
                            DateOfDeletion = DateTime.Now
                        };

                        var deletedItem = _mapper.Map<DeletedProduct>(model);
                        await _context.DeletedProducts.AddAsync(deletedItem);
                        _context.Product.Remove(product);
                        await _context.SaveChangesAsync();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"DeleteProductService DeleteProductByIdAsync Failed, Ex: {ex}");
                        transaction.Rollback();
                        return false;
                    }
                }
            }

            return false;
        }

        public async Task<bool> UndeleteProductByIdAsync(int productId)
        {
            var deletedProduct = await _context.DeletedProducts.FindAsync(productId);

            if (deletedProduct != null)
            {
                using var transaction = _context.Database.BeginTransaction();
                {
                    try
                    {
                        var model = new ProductModel()
                        {
                            ProductID = productId,
                            Class = deletedProduct.Class,
                            Color = deletedProduct.Color,
                            DaysToManufacture = deletedProduct.DaysToManufacture,
                            DiscontinuedDate = deletedProduct.DiscontinuedDate,
                            FinishedGoodsFlag = deletedProduct.FinishedGoodsFlag,
                            ListPrice = deletedProduct.ListPrice,
                            MakeFlag = deletedProduct.MakeFlag,
                            ModifiedDate = deletedProduct.ModifiedDate,
                            Name = deletedProduct.Name,
                            ProductLine = deletedProduct.ProductLine,
                            ProductNumber = deletedProduct.ProductNumber,
                            ReorderPoint = deletedProduct.ReorderPoint,
                            Rowguid = deletedProduct.Rowguid,
                            SafetyStockLevel = deletedProduct.SafetyStockLevel,
                            SellEndDate = deletedProduct.SellEndDate,
                            SellStartDate = deletedProduct.SellStartDate,
                            Size = deletedProduct.Size,
                            StandardCost = deletedProduct.StandardCost,
                            Style = deletedProduct.Style,
                            Weight = deletedProduct.Weight,
                        };

                        var item = _mapper.Map<Product>(model);
                        await _context.Product.AddAsync(item);
                        await _context.SaveChangesAsync();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"DeleteProductService UndeleteProductByIdAsync Failed,  Ex: {ex}");
                        transaction.Rollback();
                        return false;
                    }
                }
            }

            return false;
        }
    }
}
