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
        private readonly IDeleteProductService _deleteProductService;
        private readonly IUserChangesService _userChangesService;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(ApplicationDbContext context,
                              IDeleteProductService deleteProductService,
                              IUserChangesService userChangesService,
                              IMapper mapper,
                              ILogger<ProductService> logger)
        {
            _context = context;
            _deleteProductService = deleteProductService;
            _userChangesService = userChangesService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<ProductModel>> AllAsync()
        {
            try
            {
                var query = _context.Product
                    .AsNoTracking()
                    .ProjectTo<ProductModel>(_mapper.ConfigurationProvider);

                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductService AllAsync Fail, Ex: {ex}");
                return null;
            }
        }

        public async Task<ProductModel?> GetByIdAsync(int id)
        {
            try
            {
                var item = await _context.Product
                    .AsNoTracking()
                    .ProjectTo<ProductModel>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(t => t.ProductID == id);

                return item;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductService GetByIdAsync Fail, Ex: {ex}");
                return null;
            }
        }

        public async Task<ProductModel> CreateAsync(ProductCreateModel model)
        {
            var item = _mapper.Map<Product>(model);
            await _context.AddAsync(item);

            var changes = new UserChangesModel()
            {
                OperationDate = DateTime.Now,
                OperationType = Data.Enum.OperationType.Create,
                TableName = "Production.Product",
                UserName = "some user name",
                Values = $"ProductName {model.Name}, ProductCreated: {DateTime.Now}",
            };

            await _userChangesService.CreateAsync(changes);

            await _context.SaveChangesAsync();

            return _mapper.Map<ProductModel>(item);
        }

        public async Task<ProductModel?> UpdateAsync(ProductUpdateModel model)
        {
            var item = await _context.Product.FindAsync(model.ProductID);

            if (item is null)
            {
                return null;
            }

            try
            {
                _mapper.Map(model, item);

                var changes = new UserChangesModel()
                {
                    OperationDate = DateTime.Now,
                    OperationType = Data.Enum.OperationType.Update,
                    TableName = "Production.Product",
                    UserName = "some user name",
                    Values = $"ProductId:{item.ProductID}, ProductName {model.Name}, ProductUpdated: {DateTime.Now}",
                };

                await _userChangesService.CreateAsync(changes);

                await _context.SaveChangesAsync();

                return _mapper.Map<ProductModel>(item);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ProductService UpdateAsync Fail, Ex: {ex}");
                return null;
            }
        }

        public async Task<ProductModel?> DeleteAsync(int id)
        {
            var item = await _context.Product.FirstOrDefaultAsync(t => t.ProductID == id);

            if (item is null)
            {
                return null;
            }

            var result = await _deleteProductService.DeleteProductByIdAsync(id);

            if (result)
            {
                var changes = new UserChangesModel()
                {
                    OperationDate = DateTime.Now,
                    OperationType = Data.Enum.OperationType.Delete,
                    TableName = "Production.Product",
                    UserName = "some user name",
                    Values = $"ProductId:{item.ProductID}, ProductName {item.Name}, ProductDeleted: {DateTime.Now}",
                };

                await _userChangesService.CreateAsync(changes);

                _logger.LogInformation($"ProductService DeleteAsync - Product was deleted from table Production.Products - Id: {item.ProductID}");
            }
            else
            {
                _logger.LogInformation($"ProductService DeleteAsync - Error during delete product - Id: {item.ProductID}");
                return null;
            }

            return _mapper.Map<ProductModel>(item);
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
