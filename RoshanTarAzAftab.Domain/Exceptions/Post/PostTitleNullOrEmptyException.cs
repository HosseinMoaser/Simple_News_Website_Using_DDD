using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Post;

public class PostTitleNullOrEmptyException : PostException
{
    public PostTitleNullOrEmptyException() : base("Post Title Can Not Be Empty...!")
    {
    }
}
