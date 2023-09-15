using RoshanTarAzAftab.Domain.Exceptions.Comment;
using RoshanTarAzAftab.Domain.ValueObjects.Post;

namespace RoshanTarAzAftab.Domain.ValueObjects.Comment;

public record CommentContent
{
    public string Value { get; }

    private const int maxLength = 200;

    public CommentContent(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new CommentContentNullOrEmptyException();
        }

        if (value.Length > maxLength)
        {
            throw new CommentContentOutOfRangeLengthException(maxLength);
        }
        Value = value;
    }

    public static implicit operator string(CommentContent content) => content.Value;
    public static implicit operator CommentContent(string content) => new(content);

}
