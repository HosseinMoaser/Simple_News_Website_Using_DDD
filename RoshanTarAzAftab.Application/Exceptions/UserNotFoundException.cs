using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Application.Exceptions;

public sealed class UserNotFoundException : UserException
{
    public UserNotFoundException() : base("User Not Found..!")
    {
    }
}
