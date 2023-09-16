using RoshanTarAzAftab.Domain.Exceptions.Message;

namespace RoshanTarAzAftab.Domain.ValueObjects.Message;

public record FullName
{
    public string Value { get; set; }

	public FullName(string value)
	{
		if(string.IsNullOrWhiteSpace(value))
		{
			throw new MessageFullNameNullOrEmptyException();
		}
		Value = value;
	}

    public static implicit operator string(FullName fullName) => fullName.Value;
    public static implicit operator FullName(string fullName) => new(fullName);
}
