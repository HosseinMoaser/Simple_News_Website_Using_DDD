using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Post.Handlers;

public class GetPostByIdHandler : IQueryHandler<GetPostById, PostDto>
{
    private readonly IPostRepository _repository;

    public async Task<PostDto> HandleAsync(GetPostById query)
    {
        var post = await _repository.GetPostAsync(query.Id);
        // should be converrted to dto
        return null;
    }
}
