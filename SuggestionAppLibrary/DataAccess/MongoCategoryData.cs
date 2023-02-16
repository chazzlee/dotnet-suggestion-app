using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace SuggestionAppLibrary.DataAccess;

public class MongoCategoryData : ICategoryData
{
    private const string cacheName = "CategoryData";
    private readonly IMemoryCache _cache;
    private readonly IMongoCollection<CategoryModel> _categories;

    public MongoCategoryData(IDbConnection db, IMemoryCache cache)
    {
        _cache = cache;
        _categories = db.CategoryCollection;
    }

    public async Task<List<CategoryModel>> GetCategoriesAsync()
    {
        var output = _cache.Get<List<CategoryModel>>(cacheName);
        if (output is null)
        {
            var result = await _categories.FindAsync(_ => true);
            output = result.ToList();
            _cache.Set(cacheName, output, TimeSpan.FromDays(1));
        }
        return output;
    }

    public Task CreateCategory(CategoryModel category)
    {
        return _categories.InsertOneAsync(category);
    }
}