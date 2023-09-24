using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Message;

public record RemoveMessage(Guid id) : ICommand;
