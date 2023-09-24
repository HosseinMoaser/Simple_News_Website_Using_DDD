using RoshanTarAzAftab.Domain.ValueObjects.Category;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Category;

public record UpdateCategory (BaseEntityId id, CategoryName name) : ICommand;
