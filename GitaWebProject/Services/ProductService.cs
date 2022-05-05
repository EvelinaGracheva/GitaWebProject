using AutoMapper;
using AutoMapper.QueryableExtensions;
using GitaWebProject.Data;
using GitaWebProject.Data.Entities;
using GitaWebProject.Interfaces;
using GitaWebProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GitaWebProject.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(ApplicationDbContext context, IMapper mapper, ILogger<ProductService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<ProductModel>> AllAsync()
        {
            var query = _context.Product
                .AsNoTracking()
                .ProjectTo<ProductModel>(_mapper.ConfigurationProvider);

            return await query.ToListAsync();
        }

        public async Task<ProductModel?> GetByIdAsync(int id)
        {
            var item = await _context.Product
                .AsNoTracking()
                .ProjectTo<ProductModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(t => t.ProductID == id);

            return item;
        }

        public async Task<ProductModel> CreateAsync(ProductModel model)
        {
            var item = _mapper.Map<Product>(model);
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductModel>(item);
        }

        public async Task<ProductModel?> UpdateAsync(ProductModel model)
        {
            var item = await _context.Product.FindAsync(model.ProductID);

            if (item is null)
            {
                return null;
            }

            _mapper.Map(model, item);

            await _context.SaveChangesAsync();

            return _mapper.Map<ProductModel>(item);
        }

        public async Task<ProductModel?> DeleteAsync(int id)
        {
            var item = await _context.Product.FirstOrDefaultAsync(t => t.ProductID == id);

            if (item is null)
            {
                return null;
            }

            using var transaction = _context.Database.BeginTransaction();
            {
                try
                {
                    _context.Remove(item);

                    var model = new DeletedProductModel { };
                    var deletedItem = _mapper.Map<DeletedProduct>(model);

                    await _context.AddAsync(deletedItem);
                    await _context.SaveChangesAsync();

                    _logger.LogInformation($"ProductService DeleteAsync - Product was deleted from table Production.Products - Id: {item.ProductID}");

                    transaction.Commit();
                    return _mapper.Map<ProductModel>(item);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"ProductService DeleteAsync Ex: {ex}");
                    _logger.LogInformation($"ProductService DeleteAsync - Error during delete product - Id: {item.ProductID}");
                    transaction.Rollback();
                    return null;
                }
            }
        }

        public async Task<List<ProductModel>> FilterAsync(FilterModel model)
        {
            var query = _context.Product
                .AsNoTracking()
                .ProjectTo<ProductModel>(_mapper.ConfigurationProvider);

            if (model.ListPrice.HasValue)
            {
                query = query.Where(t => t.ListPrice == model.ListPrice);
            }
            if (!string.IsNullOrEmpty(model.Name))
            {
                query = query.Where(t => t.Name.Contains(model.Name));
            }
            if (!string.IsNullOrEmpty(model.ProductNumber))
            {
                query = query.Where(t => t.ProductNumber.Contains(model.ProductNumber));
            }
            if (!string.IsNullOrEmpty(model.Color))
            {
                query = query.Where(t => t.Color!.Contains(model.Color));
            }
            if (!string.IsNullOrEmpty(model.Size))
            {
                query = query.Where(t => t.Size!.Contains(model.Size));
            }
            if (model.Weight.HasValue)
            {
                query = query.Where(t => t.Weight == model.Weight);
            }
            if (model.SellEndDate.HasValue)
            {
                query = query.Where(t => t.SellEndDate == model.SellEndDate);
            }
            if (model.SellStartDate.HasValue)
            {
                query = query.Where(t => t.SellStartDate == model.SellStartDate);
            }

            var items = await query.ToListAsync();

            return items;
        }
    }
}
