using RoshanTarAzAftab.Domain.Exceptions.Post;

namespace RoshanTarAzAftab.Domain.ValueObjects.Post;

public record PostTitle
{
    public string Value { get;}
	private const int maxLength = 150;
	public PostTitle(string value)
	{
		if(string.IsNullOrWhiteSpace(value))
		{
			throw new PostTitleNullOrEmptyException();
		}

		if(value.Length > maxLength)
		{
			throw new PostTitleOutOfRangeLengthException(maxLength);
		}
		Value = value;
	}

    public static implicit operator string(PostTitle postTitle) => postTitle.Value;
    public static implicit operator PostTitle(string postTitle) => new(postTitle);
}
