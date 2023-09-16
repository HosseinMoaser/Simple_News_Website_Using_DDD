using RoshanTarAzAftab.Domain.Exceptions.Message;

namespace RoshanTarAzAftab.Domain.ValueObjects.Message;

public record Email
{
    public string Value { get; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new MessageEmptyEmailException();

        try
        {
            var addr = new System.Net.Mail.MailAddress(value);
            if (addr.Address != value)
                throw new MessageInvalidEmailException();
        }
        catch
        {
            throw new MessageInvalidEmailException();
        }

        Value = value;
    }

    public static implicit operator string(Email email) => email.Value;
    public static explicit operator Email(string email) => new (email);
}
