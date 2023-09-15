using RoshanTarAzAftab.Domain.Exceptions.Post;

namespace RoshanTarAzAftab.Domain.ValueObjects.Post;

public record PostContent
{
    public string Value { get; }

	public PostContent(string value)
	{
		if(string.IsNullOrWhiteSpace(value))
		{
			throw new PostContentNullOrEmptyException();
		}

		Value = value;
	}

    public static implicit operator string(PostContent content) => content.Value;
    public static implicit operator PostContent(string content) => new(content);
}
