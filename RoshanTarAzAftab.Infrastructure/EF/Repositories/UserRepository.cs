using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Infrastructure.EF.Context;

namespace RoshanTarAzAftab.Infrastructure.EF.Repositories;

internal sealed class UserRepository : IUserRepository
{
    private readonly DbSet<User> _users;
    private readonly WriteDbContext _writeContext;

    public async Task<User> GetUserAsync(BaseEntityId id)
    {
        return await _users.SingleOrDefaultAsync(u=> u.Id == id);
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        return await _users.ToListAsync();
    }

    public UserRepository(WriteDbContext writeContext)
    {
        _users = writeContext.Users;
        _writeContext = writeContext;
    }

    public async Task AddAsync(User user)
    {
        await _users.AddAsync(user);
        await _writeContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(User user)
    {
        _users.Remove(user);
        await _writeContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _users.Update(user);
        await _writeContext.SaveChangesAsync();
    }
}
