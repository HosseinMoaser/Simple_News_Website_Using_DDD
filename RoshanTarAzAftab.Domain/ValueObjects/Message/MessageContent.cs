using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.Exceptions.Message;

namespace RoshanTarAzAftab.Domain.ValueObjects.Message;

public record MessageContent
{
    public string Value { get; set; }

	public MessageContent(string value)
	{
		if(string.IsNullOrWhiteSpace(value))
		{
			throw new MessageNullOrEmptyException();
		}
		Value = value;
	}

    public static implicit operator string(MessageContent message) => message.Value;
    public static implicit operator MessageContent(string message) => new(message);
}
