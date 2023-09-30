using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Infrastructure.EF.Context;

namespace RoshanTarAzAftab.Infrastructure.EF.Repositories;

internal sealed class MessageRepository : IMessageReporitory
{
    private readonly DbSet<Message> _messages;
    private readonly WriteDbContext _writeContext;

    public MessageRepository(WriteDbContext writeContext)
    {
        _messages = writeContext.Messages;
        _writeContext = writeContext;
    }

    public async Task<Message> GetMessageAsync(BaseEntityId id)
    {
        return await _messages.SingleOrDefaultAsync(m=> m.Id == id);
    }

    public async Task<IEnumerable<Message>> GetMessages()
    {
        return await _messages.ToListAsync();
    }

    public async Task AddAsync(Message message)
    {
        await _messages.AddAsync(message);
        await _writeContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Message message)
    {
        _messages.Remove(message);
        await _writeContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Message message)
    {
        _messages.Update(message);
        await _writeContext.SaveChangesAsync();
    }
}
