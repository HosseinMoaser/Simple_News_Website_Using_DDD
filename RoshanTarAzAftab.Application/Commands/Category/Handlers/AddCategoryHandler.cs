using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Category.Handlers;

public sealed class AddCategoryHandler : ICommandHandler<AddCategory>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ICategoryFactory _categoryFactory;

    public AddCategoryHandler(ICategoryRepository categoryRepository, ICategoryFactory categoryFactory)
    {
        _categoryRepository = categoryRepository;
        _categoryFactory = categoryFactory;
    }

    public async Task HandleAsync(AddCategory command)
    {
        var category = _categoryFactory.Create(command.id, command.name);
        await _categoryRepository.AddAsync(category);
    }
}
