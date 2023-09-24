using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.User;

public record RemoveUser(Guid id): ICommand;
