using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Factories;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Category.Handlers;

public sealed class UpdateCategoryHandler : ICommandHandler<UpdateCategory>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ICategoryFactory _categoryFactory;

    public UpdateCategoryHandler(ICategoryRepository categoryRepository, ICategoryFactory categoryFactory)
    {
        _categoryRepository = categoryRepository;
        _categoryFactory = categoryFactory;
    }

    public async Task HandleAsync(UpdateCategory command)
    {
        var category = await _categoryRepository.GetCategoryAsync(command.id);

        if(category == null)
        {
            throw new CategoryNotFoundException();
        }

        var updatedCategory = _categoryFactory.Create(command.id,command.name);
        await _categoryRepository.UpdateAsync(updatedCategory);
    }
}
