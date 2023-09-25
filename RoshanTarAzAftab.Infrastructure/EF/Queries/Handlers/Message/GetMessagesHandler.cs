using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Message;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Message;

public class GetMessagesHandler : IQueryHandler<GetMessages, IEnumerable<MessageDto>>
{
    private readonly IMessageReporitory _repository;

    public GetMessagesHandler(IMessageReporitory repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MessageDto>> HandleAsync(GetMessages query)
    {
        var messages = await _repository.GetMessages();
        // Should be converted to dto
        return null;
    }
}
