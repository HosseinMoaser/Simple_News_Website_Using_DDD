using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Category;

public record RemoveCategory(Guid id) : ICommand;
