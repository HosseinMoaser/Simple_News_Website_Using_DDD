using RoshanTarAzAftab.Domain.Enums;

namespace RoshanTarAzAftab.Infrastructure.EF.Models;

public class PostReadModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public PostType PostType { get; set; }
    public Guid CategoryId { get; set; }
    public string ShortDescription { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public CategoryReadModel Category { get; set; }
}
