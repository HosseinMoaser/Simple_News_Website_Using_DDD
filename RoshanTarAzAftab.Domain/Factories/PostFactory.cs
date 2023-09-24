using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Post;

namespace RoshanTarAzAftab.Domain.Factories;

public sealed class PostFactory : IPostFactory
{
    public Post Create(BaseEntityId id, PostTitle title, PostType postType, BaseEntityId categoryId, PostShortDescription shortDescription,
        PostContent content, Date datePosted)
    {
        return new Post(id,title,postType,categoryId,shortDescription,content,datePosted);
    }
}
