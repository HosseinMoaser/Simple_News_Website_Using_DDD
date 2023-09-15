using RoshanTarAzAftab.Domain.Common;

namespace RoshanTarAzAftab.Domain.Entities;

public class Message : BaseEntity
{
    public string SenderName { get; set; }
    public string SenderEmail { get; set; }
    public string Content { get; set; }
}
