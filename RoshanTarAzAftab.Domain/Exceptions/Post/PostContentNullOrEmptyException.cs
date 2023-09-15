using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Post;

public class PostContentNullOrEmptyException : PostException
{
    public PostContentNullOrEmptyException() : base("Post Content Can Not Be Empty...!")
    {

    }
}
