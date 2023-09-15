using RoshanTarAzAftab.Domain.Enums;

namespace RoshanTarAzAftab.Domain.Entities;

public class Category
{
    public Guid Id { get; set; }
    public CategoryType CategoryType { get; set; }
    public List<Post> Posts { get; set; }
}
