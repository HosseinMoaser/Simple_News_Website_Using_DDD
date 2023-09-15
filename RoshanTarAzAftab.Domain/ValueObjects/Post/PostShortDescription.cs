using RoshanTarAzAftab.Domain.Exceptions.Post;

namespace RoshanTarAzAftab.Domain.ValueObjects.Post;

public record PostShortDescription
{
    public string Value { get; }
    private const int maxLength = 300;

    public PostShortDescription(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new PostShortDescriptionNullOrEmptyException();
        }

        if (value.Length > maxLength)
        {
            throw new PostShortDescriptionOutOfRangeLengthException(maxLength);
        }
        Value = value;
    }

    public static implicit operator string(PostShortDescription postShortDesc) => postShortDesc.Value;
    public static implicit operator PostShortDescription(string postShortDesc) => new(postShortDesc);
}
