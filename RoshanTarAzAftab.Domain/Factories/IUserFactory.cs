using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects.Message;
using RoshanTarAzAftab.Domain.ValueObjects;

namespace RoshanTarAzAftab.Domain.Factories;

public interface IUserFactory
{
    User Create(BaseEntityId id, Email email, ActivationCode activationCode);
}
