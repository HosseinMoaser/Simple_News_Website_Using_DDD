using RoshanTarAzAftab.Domain.Exceptions.User;

namespace RoshanTarAzAftab.Domain.ValueObjects;

public record ActivationCode
{
    public string Value { get; }
    public ActivationCode(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new UserActivationCodeNullException();
        }

        Value = value;
    }

    public static implicit operator string(ActivationCode activation) => activation.Value;
    public static implicit operator ActivationCode(string activation) => new(activation);
}
