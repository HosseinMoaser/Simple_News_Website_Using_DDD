using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Services;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Infrastructure.EF.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Services;

internal sealed class PostReadService : IPostReadService
{
    private readonly DbSet<PostReadModel> _posts;

    public PostReadService(ReadDbContext readContext)
    {
        _posts = readContext.Post;
    }
    public async Task<IEnumerable<PostDto>> ReadPostsAsync()
    {
        var posts = await _posts.ToListAsync();
        
        return posts.Select(p=> p.ToPostDto());
    }
}
