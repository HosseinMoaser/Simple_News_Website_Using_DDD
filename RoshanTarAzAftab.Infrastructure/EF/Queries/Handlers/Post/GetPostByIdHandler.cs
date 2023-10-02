using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Post;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Post;

internal class GetPostByIdHandler : IQueryHandler<GetPostById, PostDto>
{
    private readonly DbSet<PostReadModel> _posts;

    public GetPostByIdHandler(ReadDbContext readContext)
    {
        _posts = readContext.Post;
    }

    public async Task<PostDto> HandleAsync(GetPostById query)
    {
        var post = await _posts.Include(p=> p.Category).Where(p => p.Id == query.Id)
            .Select(p => p.ToPostDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();
        return post;
    }
}
