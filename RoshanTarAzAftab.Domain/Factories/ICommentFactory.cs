using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects.Comment;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Factories;

public interface ICommentFactory
{
    Comment Create(BaseEntityId id, CommentContent content, Date date, BaseEntityId postId, Email email, FullName fullName);
}
