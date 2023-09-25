using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Post;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Post;

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
