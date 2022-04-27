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

    //public async Task<List<ArticleListItemModel>> AllAsync()
    //{
    //    var query = _context.Articles
    //        .AsNoTracking()
    //        .ProjectTo<ArticleListItemModel>(_mapper.ConfigurationProvider);

    //    var language = _httpContextAccessor.HttpContext?.GetLanguage();

    //    if (language == Language.RU)
    //    {
    //        query = query.Where(t => t.TitleRu != null);
    //    }

    //    return await query.ToListAsync();
    //}

    //public async Task<List<ArticleListItemModel>> Top10Async()
    //{
    //    var query = _context.Articles
    //        .AsNoTracking()
    //        .OrderByDescending(t => t.CreatedAt)
    //        .ProjectTo<ArticleListItemModel>(_mapper.ConfigurationProvider);

    //    var language = _httpContextAccessor.HttpContext?.GetLanguage();

    //    if (language == Language.RU)
    //    {
    //        query = query.Where(t => t.TitleRu != null);
    //    }

    //    return await query.ToListAsync();
    //}

    //public async Task<List<ArticleListItemModel>> GetByCategoryIdAsync(int id)
    //{
    //    var query = _context.Articles
    //        .AsNoTracking()
    //        .OrderByDescending(t => t.CreatedAt)
    //        .Where(t => t.CategoryId == id)
    //        .ProjectTo<ArticleListItemModel>(_mapper.ConfigurationProvider);

    //    var language = _httpContextAccessor.HttpContext?.GetLanguage();

    //    if (language == Language.RU)
    //    {
    //        query = query.Where(t => t.TitleRu != null);
    //    }

    //    return await query.ToListAsync();
    //}

    //public async Task<List<ArticleListItemModel>> GetLastItemsByCategoryIdAsync(int id)
    //{
    //    var query = _context.Articles
    //        .AsNoTracking()
    //        .OrderByDescending(t => t.CreatedAt)
    //        .Where(t => t.CategoryId == id)
    //        .ProjectTo<ArticleListItemModel>(_mapper.ConfigurationProvider);

    //    var language = _httpContextAccessor.HttpContext?.GetLanguage();

    //    if (language == Language.RU)
    //    {
    //        query = query.Where(t => t.TitleRu != null);
    //    }

    //    return await query.ToListAsync();
    //}

    //public async Task<List<SelectListItem>> GetCategoriesAsync()
    //{
    //    return await _context.Categories.Select(t => new SelectListItem
    //    {
    //        Text = t.Name,
    //        Value = t.Id.ToString()
    //    }).ToListAsync();
    //}

    //public async Task<ArticleReadModel?> GetByIdAsync(int id)
    //{
    //    var item = await _context.Articles
    //        .AsNoTracking()
    //        .ProjectTo<ArticleReadModel>(_mapper.ConfigurationProvider)
    //        .FirstOrDefaultAsync(t => t.Id == id);

    //    return item;
    //}

    //public async Task<ArticleReadModel> CreateAsync(ArticleModel model)
    //{
    //    var item = _mapper.Map<Article>(model);
    //    await _context.AddAsync(item);
    //    await _context.SaveChangesAsync();

    //    return _mapper.Map<ArticleReadModel>(item);
    //}

    //public async Task<ArticleReadModel?> UpdateAsync(ArticleModel model)
    //{
    //    var item = await _context.Articles.FindAsync(model.Id);

    //    if (item is null)
    //    {
    //        return null;
    //    }

    //    _mapper.Map(model, item);

    //    await _context.SaveChangesAsync();

    //    return _mapper.Map<ArticleReadModel>(item);
    //}

    //public async Task<ArticleReadModel?> DeleteAsync(int id)
    //{
    //    var item = await _context.Articles.Include(t => t.Medias).FirstOrDefaultAsync(t => t.Id == id);

    //    if (item is null)
    //    {
    //        return null;
    //    }

    //    _context.Remove(item);
    //    _context.Medias.RemoveRange(item.Medias);
    //    await _context.SaveChangesAsync();

    //    var media = _mediaManager.GetByArticleIdAsync(id);
    //    await _mediaManager.DeleteByIdAsync(media.Id);

    //    return _mapper.Map<ArticleReadModel>(item);
    //}
}
