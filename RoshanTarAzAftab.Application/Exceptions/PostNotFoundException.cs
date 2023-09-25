using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Application.Exceptions;

public sealed class PostNotFoundException : PostException
{
    public PostNotFoundException() : base("Post Not Found...!")
    {
    }
}
