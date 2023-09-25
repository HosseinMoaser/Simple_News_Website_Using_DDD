using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Message.Handlers;

public sealed class RemoveMessageHandler : ICommandHandler<RemoveMessage>
{
    private readonly IMessageReporitory _messageRepository;

    public RemoveMessageHandler(IMessageReporitory messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async Task HandleAsync(RemoveMessage command)
    {
        var message = await _messageRepository.GetMessageAsync(command.id);
        if (message == null)
        {
            throw new MessageNotFoundException();
        }

        await _messageRepository.DeleteAsync(message);
    }
}
