using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Comment;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Entities;

public class Reply : BaseEntity
{
    private CommentContent _content;
    private Date _datePosted;
    private BaseEntityId _commentId;
    private Email _email;
    private FullName _fullName;

    internal Reply(BaseEntityId id, CommentContent content, Date datePosted, BaseEntityId commentId, Email email, FullName fullName) : base(id)
    {
        _content = content;
        _datePosted = datePosted;
        _commentId = commentId;
        _email = email;
        _fullName = fullName;
    }

    public Reply(BaseEntityId id) : base(id)
    {

    }
}
