using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Post;

public class PostTitleOutOfRangeLengthException : PostException
{
    public PostTitleOutOfRangeLengthException(int maxLength) : base($"Post Title Could Not Be More Than {maxLength} ...!")
    {
    }
}
