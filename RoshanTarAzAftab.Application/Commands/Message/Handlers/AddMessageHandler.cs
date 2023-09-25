using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Message.Handlers;

public sealed class AddMessageHandler : ICommandHandler<AddMessage>
{
    private readonly IMessageFactory _messageFactory;
    private readonly IMessageReporitory _messageReporitory;

    public AddMessageHandler(IMessageFactory messageFactory, IMessageReporitory messageReporitory)
    {
        _messageFactory = messageFactory;
        _messageReporitory = messageReporitory;
    }

    public async Task HandleAsync(AddMessage command)
    {
        var message = _messageFactory.Create(command.id,command.senderName,command.senderEmail,command.content);
        await _messageReporitory.AddAsync(message);
    }
}
