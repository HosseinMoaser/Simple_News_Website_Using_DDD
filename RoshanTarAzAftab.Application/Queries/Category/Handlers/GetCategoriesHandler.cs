using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Category.Handlers;

public class GetCategoriesHandler : IQueryHandler<GetCategories, IEnumerable<CategoryDto>>
{
    private readonly ICategoryRepository _repository;

    public GetCategoriesHandler(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CategoryDto>> HandleAsync(GetCategories query)
    {
        var categories = await _repository.GetCategories();
        // Should be converted to dtos
        return null;
    }
}
