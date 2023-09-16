using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Message;

public class MessageNullOrEmptyException : MessageException
{
    public MessageNullOrEmptyException() : base("Message Could Not Be Empty...!")
    {
    }
}
