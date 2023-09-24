using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Comment;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Factories;

public class CommentFactory : ICommentFactory
{
    public Comment Create(BaseEntityId id, CommentContent content, Date date, BaseEntityId postId, Email email, FullName fullName)
    {
        return new Comment(id, content, date, postId, email, fullName);
    }
}
