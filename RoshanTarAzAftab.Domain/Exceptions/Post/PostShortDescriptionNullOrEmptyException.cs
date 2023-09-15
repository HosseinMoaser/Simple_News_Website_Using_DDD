using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Post;

public class PostShortDescriptionNullOrEmptyException : PostException
{
    public PostShortDescriptionNullOrEmptyException() : base("Short Description For a Post Could Not Be Empty...!")
    {
    }
}
