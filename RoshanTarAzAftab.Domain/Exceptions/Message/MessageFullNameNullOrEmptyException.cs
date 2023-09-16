using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Message;

public class MessageFullNameNullOrEmptyException : MessageException
{
    public MessageFullNameNullOrEmptyException() : base("Full Name Could Not Be Empty...!")
    {
    }
}
