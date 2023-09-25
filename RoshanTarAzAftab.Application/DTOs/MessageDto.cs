using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Application.DTOs;

public class MessageDto
{
    public Guid Id { get; set; }
    public string SenderName { get; set; }
    public string SenderEmail { get; set; }
    public string Content { get; set; }

}
