using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Category;

namespace RoshanTarAzAftab.Domain.Factories;

public class CategoryFactory : ICategoryFactory
{
    public Category Create(BaseEntityId id, CategoryName name)
    {
        return new Category(id,name);
    }
}
