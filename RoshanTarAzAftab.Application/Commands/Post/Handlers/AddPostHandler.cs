using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Post.Handlers;

public sealed class AddPostHandler : ICommandHandler<AddPost>
{
    private readonly IPostRepository _postRepository;
    private readonly IPostFactory _postFactory;

    public AddPostHandler(IPostRepository postRepository, IPostFactory postFactory)
    {
        _postRepository = postRepository;
        _postFactory = postFactory;
    }

    public async Task HandleAsync(AddPost command)
    {
        var post = _postFactory.Create(command.id, command.title, command.postType, command.categoryId, command.shortDescription,
            command.content, command.datePosted);
        await _postRepository.AddAsync(post);
    }
}
