using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions;

public class BaseEntityIdException : BaseEntityException
{
    public BaseEntityIdException() : base("Id Can Not Be Empty...!")
    {
    }
}
