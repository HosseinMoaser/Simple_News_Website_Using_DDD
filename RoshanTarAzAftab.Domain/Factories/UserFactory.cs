using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Factories;

public class UserFactory : IUserFactory
{
    public User Create(BaseEntityId id, Email email, ActivationCode activationCode,bool isRegistered)
    {
        return new User(id,email,activationCode,isRegistered);
    }
}
