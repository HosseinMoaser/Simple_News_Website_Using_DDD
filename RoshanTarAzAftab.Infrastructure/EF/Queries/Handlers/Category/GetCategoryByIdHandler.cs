using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Category;
using RoshanTarAzAftab.Domain.Repositories;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Category;

public class GetCategoryByIdHandler : IQueryHandler<GetCategoryById, CategoryDto>
{
    private readonly ICategoryRepository _repository;

    public GetCategoryByIdHandler(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<CategoryDto> HandleAsync(GetCategoryById query)
    {
        var category = await _repository.GetCategoryAsync(query.Id);
        //should be converted to dto
        return null;
    }
}
