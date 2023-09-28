namespace RoshanTarAzAftab.Infrastructure.EF.Models;

public class CategoryReadModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<PostReadModel> Posts { get; set; }
}
