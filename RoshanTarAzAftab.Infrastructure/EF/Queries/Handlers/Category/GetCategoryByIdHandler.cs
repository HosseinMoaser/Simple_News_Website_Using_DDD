using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Category;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Category;

internal class GetCategoryByIdHandler : IQueryHandler<GetCategoryById, CategoryDto>
{
    private readonly DbSet<CategoryReadModel> _categories;

    public GetCategoryByIdHandler(ReadDbContext readContext)
    {
        _categories = readContext.Category;
    }

    public async Task<CategoryDto> HandleAsync(GetCategoryById query)
    {
        var category = await _categories.Include(c => c.Posts)
            .Where(c => c.Id == query.Id)
            .Select(c => c.ToCategoryDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();
        return category;
    }
}
