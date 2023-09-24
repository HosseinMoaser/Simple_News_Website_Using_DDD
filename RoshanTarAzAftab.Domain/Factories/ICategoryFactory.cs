using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects.Category;
using RoshanTarAzAftab.Domain.ValueObjects;

namespace RoshanTarAzAftab.Domain.Factories;

public interface ICategoryFactory
{
    Category Create(BaseEntityId id, CategoryName name);
}
