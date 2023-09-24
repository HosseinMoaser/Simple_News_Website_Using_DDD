using RoshanTarAzAftab.Domain.ValueObjects.Post;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Post;

public record UpdatePost(BaseEntityId id, PostTitle title, PostType postType, BaseEntityId categoryId, PostShortDescription shortDescription,
        PostContent content, Date datePosted) : ICommand;
