using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.Enums;

namespace RoshanTarAzAftab.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Post> Posts { get; set; }
}
