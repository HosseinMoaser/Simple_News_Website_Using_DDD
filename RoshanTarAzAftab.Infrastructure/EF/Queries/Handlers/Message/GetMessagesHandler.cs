using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Message;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Message;

internal class GetMessagesHandler : IQueryHandler<GetMessages, IEnumerable<MessageDto>>
{
    private readonly DbSet<MessageReadModel> _messages;


    public GetMessagesHandler(ReadDbContext readContext)
    {
        _messages = readContext.Message;
    }

    public async Task<IEnumerable<MessageDto>> HandleAsync(GetMessages query)
    {
        return await _messages.Select(m=> m.ToMessageDto()).ToListAsync();
    }
}
