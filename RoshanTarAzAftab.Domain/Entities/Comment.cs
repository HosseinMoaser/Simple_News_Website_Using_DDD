namespace RoshanTarAzAftab.Domain.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public Guid PostId { get; set; }
    public List<Reply> Replies { get; set; }

}
