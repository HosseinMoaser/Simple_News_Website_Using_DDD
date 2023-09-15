using RoshanTarAzAftab.Domain.Enums;

namespace RoshanTarAzAftab.Domain.ValueObjects.Post;

public record PostType
{
    public Enums.PostType Value { get; }

	public PostType(Enums.PostType value)
	{
		Value = value;
	}

    public static implicit operator Enums.PostType(PostType type) => type.Value;
    public static implicit operator PostType(Enums.PostType type) => new(type);
}
