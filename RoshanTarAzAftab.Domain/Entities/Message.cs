namespace RoshanTarAzAftab.Domain.Entities;

public class Message
{
    public Guid Id { get; set; }
    public string SenderName { get; set; }
    public string SenderEmail { get; set; }
    public string Content { get; set; }
}
