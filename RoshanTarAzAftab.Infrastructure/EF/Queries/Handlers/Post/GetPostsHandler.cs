using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Category;
using RoshanTarAzAftab.Application.Queries.Post;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Post;

internal class GetPostsHandler : IQueryHandler<GetPosts, IEnumerable<PostDto>>
{
    private readonly DbSet<PostReadModel> _posts;

    public GetPostsHandler(ReadDbContext readContext)
    {
        _posts = readContext.Post;
    }

    public async Task<IEnumerable<PostDto>> HandleAsync(GetPosts query)
    {
        return await _posts.Select(p=> p.ToPostDto()).ToListAsync();
    }
}
