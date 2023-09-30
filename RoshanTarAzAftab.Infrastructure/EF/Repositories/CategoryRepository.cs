using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Infrastructure.EF.Context;

namespace RoshanTarAzAftab.Infrastructure.EF.Repositories;

internal sealed class CategoryRepository : ICategoryRepository
{
    private readonly DbSet<Category> _categories;
    private readonly WriteDbContext _writeContext;

    public CategoryRepository(WriteDbContext writeContext)
    {
        _categories = writeContext.Categories;
        _writeContext = writeContext;
    }

    public async Task<IEnumerable<Category>> GetCategories()
    {
        return await _categories.ToListAsync();
    }

    public async Task<Category> GetCategoryAsync(BaseEntityId id)
    {
        return await _categories.Include("_posts").SingleOrDefaultAsync(c => c.Id == id);
    }

    public async Task AddAsync(Category category)
    {
        await _categories.AddAsync(category);
        await _writeContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Category category)
    {
        _categories.Remove(category);
        await _writeContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Category category)
    {
        _categories.Update(category);
        await _writeContext.SaveChangesAsync();
    }
}
