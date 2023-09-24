using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.User;

public class UserActivationCodeNullException : UserException
{
    public UserActivationCodeNullException() : base("Activation Code Could Not Be Null Or Empty...!")
    {
    }
}
