using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Category;

namespace RoshanTarAzAftab.Domain.Repositories;

public interface ICategoryRepository
{
    Task<Category> GetCategoryAsync(BaseEntityId id);
    Task AddAsync(Category category);
    Task UpdateAsync(Category category);
    Task DeleteAsync(Category category);
}
