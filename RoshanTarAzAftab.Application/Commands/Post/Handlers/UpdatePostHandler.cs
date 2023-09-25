using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Post.Handlers;

public sealed class UpdatePostHandler : ICommandHandler<UpdatePost>
{
    private readonly IPostRepository _postRepository;
    private readonly IPostFactory _postFactory;

    public UpdatePostHandler(IPostRepository postRepository, IPostFactory postFactory)
    {
        _postRepository = postRepository;
        _postFactory = postFactory;
    }

    public async Task HandleAsync(UpdatePost command)
    {
        var post = await _postRepository.GetPostAsync(command.id);
        if (post == null)
        {
            throw new PostNotFoundException();
        }
        var updatedPost = _postFactory.Create(post.Id,command.title,command.postType,command.categoryId,command.shortDescription,
            command.content,command.datePosted);
        await _postRepository.UpdateAsync(updatedPost);
    }
}
