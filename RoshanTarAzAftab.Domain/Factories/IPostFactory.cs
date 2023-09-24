using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects.Post;
using RoshanTarAzAftab.Domain.ValueObjects;

namespace RoshanTarAzAftab.Domain.Factories;

public interface IPostFactory
{
    Post Create(BaseEntityId id, PostTitle title, PostType postType, BaseEntityId categoryId, PostShortDescription shortDescription,
        PostContent content, Date datePosted);
}
