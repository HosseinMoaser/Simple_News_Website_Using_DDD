using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Message;

public class MessageEmptyEmailException : MessageException
{
    public MessageEmptyEmailException() : base("Emial Can Not Be Empty...!")
    {
    }
}
