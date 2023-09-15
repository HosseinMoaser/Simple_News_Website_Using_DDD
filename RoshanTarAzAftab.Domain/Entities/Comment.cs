using RoshanTarAzAftab.Domain.Common;

namespace RoshanTarAzAftab.Domain.Entities;

public class Comment : BaseEntity
{
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public Guid PostId { get; set; }
    public List<Reply> Replies { get; set; }

}
