using RoshanTarAzAftab.Domain.Common;

namespace RoshanTarAzAftab.Domain.Entities;

public class Reply : BaseEntity
{
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public Guid CommentId { get; set; }

}
