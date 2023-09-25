using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Application.Exceptions;

public sealed class MessageNotFoundException : MessageException
{
    public MessageNotFoundException() : base("Message Not Found...!")
    {
    }
}
