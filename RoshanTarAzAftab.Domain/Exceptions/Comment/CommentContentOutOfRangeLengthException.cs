using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Comment;

public class CommentContentOutOfRangeLengthException : CommentException
{
    public CommentContentOutOfRangeLengthException(int maxLen) : base($"Comment Lenght Could Not Be More Than {maxLen}")
    {
    }
}
