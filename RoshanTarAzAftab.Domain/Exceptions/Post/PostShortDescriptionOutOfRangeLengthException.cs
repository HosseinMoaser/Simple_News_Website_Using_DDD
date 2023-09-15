using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Post;

public class PostShortDescriptionOutOfRangeLengthException : PostException
{
    public PostShortDescriptionOutOfRangeLengthException(int maxLength) : base($"Post Title Could Not Be More Than {maxLength} ...!")
    {
    }
}
