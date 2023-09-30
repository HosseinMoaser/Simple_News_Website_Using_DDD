using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Infrastructure.EF.Context;

namespace RoshanTarAzAftab.Infrastructure.EF.Repositories;

internal sealed class PostRepository : IPostRepository
{
    private readonly DbSet<Post> _posts;
    private readonly WriteDbContext _writeContext;

    public async Task<Post> GetPostAsync(BaseEntityId id)
    {
        return await _posts.SingleOrDefaultAsync(p=> p.Id == id);
    }

    public async Task<IEnumerable<Post>> GetPosts()
    {
        return await _posts.ToListAsync();
    }

    public async Task AddAsync(Post post)
    {
        await _posts.AddAsync(post);
        await _writeContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Post post)
    {
        _posts.Remove(post);
        await _writeContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Post post)
    {
        _posts.Update(post);
        await _writeContext.SaveChangesAsync();
    }
}
