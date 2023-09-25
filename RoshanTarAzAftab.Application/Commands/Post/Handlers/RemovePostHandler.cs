using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Post.Handlers;

public sealed class RemovePostHandler : ICommandHandler<RemovePost>
{
    private readonly IPostRepository _postRepository;

    public RemovePostHandler(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task HandleAsync(RemovePost command)
    {
        var post = await _postRepository.GetPostAsync(command.id);
        if(post == null)
        {
            throw new PostNotFoundException();
        }

        await _postRepository.DeleteAsync(post);
    }
}
