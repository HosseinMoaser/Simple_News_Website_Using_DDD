using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Comment;
using RoshanTarAzAftab.Domain.ValueObjects.Message;

namespace RoshanTarAzAftab.Domain.Entities;

public class Comment : BaseEntity
{
    private CommentContent _content;
    private Date _datePosted;
    private BaseEntityId _postId;
    private Email _email;
    private FullName _fullName;
    public List<Reply> Replies { get; set; }

    internal Comment(BaseEntityId id, CommentContent content, Date date, BaseEntityId postId, Email email, FullName fullName) : base(id)
    {
        _content = content;
        _datePosted = date;
        _postId = postId;
        _email = email;
        _fullName = fullName;
    }

    public Comment(BaseEntityId id) : base(id)
    {

    }

}
