namespace RoshanTarAzAftab.Infrastructure.EF.Models;

public class MessageReadModel
{
    public Guid Id { get; set; }
    public string SenderName { get; set; }
    public string SenderEmail { get; set; }
    public string Content { get; set; }
}
