namespace RoshanTarAzAftab.Domain.Entities;

public class Reply
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public Guid CommentId { get; set; }

}
