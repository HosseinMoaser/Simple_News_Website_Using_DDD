using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Comment;

namespace RoshanTarAzAftab.Domain.Entities;

public class Reply : BaseEntity
{
    private CommentContent _content;
    private Date _datePosted;
    private BaseEntityId _commentId;

    internal Reply(BaseEntityId id, CommentContent content, Date datePosted, BaseEntityId commentId) : base(id)
    {
        _content = content;
        _datePosted = datePosted;
        _commentId = commentId;
    }

    public Reply(BaseEntityId id) : base(id)
    {

    }
}
