using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Comment;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Factories;

public class ReplyFactory : IReplyFactory
{
    public Reply Create(BaseEntityId id, CommentContent content, Date datePosted, BaseEntityId commentId, Email email, FullName fullName)
    {
        return new Reply(id,content,datePosted,commentId, email,fullName);
    }
}
