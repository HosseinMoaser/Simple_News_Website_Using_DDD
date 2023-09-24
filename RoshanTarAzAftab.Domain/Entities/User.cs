using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Entities;

public class User : BaseEntity
{
    private FullName _fullName;
    private Email _email;
    private ActivationCode _activationCode;
    internal User(BaseEntityId id, Email email, ActivationCode activationCode) : base(id)
    {
        _email = email;
        _activationCode = activationCode;
    }

    public User(BaseEntityId id): base(id)
    {

    }
}
