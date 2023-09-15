using RoshanTarAzAftab.Domain.Exceptions;

namespace RoshanTarAzAftab.Domain.ValueObjects;

public record BaseEntityId
{
    public Guid Value { get; }

    public BaseEntityId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new BaseEntityIdException();
        }

        Value = value;
    }

    public static implicit operator Guid(BaseEntityId id) => id.Value;
    public static implicit operator BaseEntityId(Guid id) => new(id);
}
