using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Entities;

public class User : BaseEntity
{
    private FullName _fullName;
    private Email _email;
    private ActivationCode _activationCode;
    private bool _isRegistered;
    internal User(BaseEntityId id, Email email, ActivationCode activationCode, bool isRegistered) : base(id)
    {
        _email = email;
        _activationCode = activationCode;
        _isRegistered = isRegistered;
    }

    public User(BaseEntityId id): base(id)
    {

    }
}
