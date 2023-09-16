using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Comment;

namespace RoshanTarAzAftab.Domain.Entities;

public class Comment : BaseEntity
{
    private CommentContent _content;
    private Date _datePosted;
    private BaseEntityId _postId;

    public List<Reply> Replies { get; set; }

    internal Comment(BaseEntityId id, CommentContent content, Date date, BaseEntityId postId) : base(id)
    {
        _content = content;
        _datePosted = date;
        _postId = postId;
    }

    public Comment(BaseEntityId id) : base(id)
    {

    }

}
