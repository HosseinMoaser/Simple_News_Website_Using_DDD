using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Comment;

public class CommentContentNullOrEmptyException : CommentException
{
    public CommentContentNullOrEmptyException() : base("Comment Content Could Not Be Null Or Empty...!")
    {
    }
}
