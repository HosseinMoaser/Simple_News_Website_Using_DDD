using RoshanTarAzAftab.Domain.Common;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Post;
using RoshanTarAzAftab.Shared.Abstractions.Domain;

namespace RoshanTarAzAftab.Domain.Entities;

public class Post : AggregateRoot<BaseEntityId>
{
    private PostTitle _title;
    private PostType _postType;
    private BaseEntityId _categoryId;
    private PostShortDescription _shortDescription;
    private PostContent _content;
    private Date _datePosted;
    public List<Comment> Comments { get; set; }


    internal Post(BaseEntityId id, PostTitle title, PostType postType, BaseEntityId categoryId, PostShortDescription shortDescription,
        PostContent content, Date datePosted)
    {
        Id = id;
        _title = title;
        _postType = postType;
        _categoryId = categoryId;
        _shortDescription = shortDescription;
        _content = content;
        _datePosted = datePosted;
    }

    public Post(BaseEntityId id)
    {
        Id = id;
    }
}


