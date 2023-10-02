using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Category;
using RoshanTarAzAftab.Application.Queries.Message;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Message;

internal class GetMessageByIdHandler : IQueryHandler<GetMessageById, MessageDto>
{
    private readonly DbSet<MessageReadModel> _messages;

    public GetMessageByIdHandler(ReadDbContext readContext)
    {
        _messages = readContext.Message;
    }

    public async Task<MessageDto> HandleAsync(GetMessageById query)
    {
        var message = await _messages.Where(m => m.Id == query.Id)
            .Select(m => m.ToMessageDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();

        return message;
    }
}
