using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Message;

public class MessageInvalidEmailException : MessageException
{
    public MessageInvalidEmailException() : base("Entered Email Is Not a Valid Mail Address...!")
    {
    }
}
