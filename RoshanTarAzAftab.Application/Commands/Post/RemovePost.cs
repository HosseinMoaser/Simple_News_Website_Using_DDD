using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Post;

public record RemovePost (Guid id) : ICommand;
