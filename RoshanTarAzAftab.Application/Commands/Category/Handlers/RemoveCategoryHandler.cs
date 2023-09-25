using RoshanTarAzAftab.Application.Exceptions;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Commands;

namespace RoshanTarAzAftab.Application.Commands.Category.Handlers;

public sealed class RemoveCategoryHandler : ICommandHandler<RemoveCategory>
{
    private readonly ICategoryRepository _categoryRepository;

    public RemoveCategoryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task HandleAsync(RemoveCategory command)
    {
        var category = await _categoryRepository.GetCategoryAsync(command.id);

        if(category == null)
        {
            throw new CategoryNotFoundException();
        }

        await _categoryRepository.DeleteAsync(category);
    }
}
