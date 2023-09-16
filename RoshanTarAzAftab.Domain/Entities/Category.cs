using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.Enums;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Category;

namespace RoshanTarAzAftab.Domain.Entities;

public class Category : BaseEntity
{
    private CategoryName _name;
    public List<Post> Posts { get; set; }

    internal Category(BaseEntityId id, CategoryName name) : base(id)
    {
        _name = name;
    }

    public Category(BaseEntityId id) : base(id)
    {

    }
}
