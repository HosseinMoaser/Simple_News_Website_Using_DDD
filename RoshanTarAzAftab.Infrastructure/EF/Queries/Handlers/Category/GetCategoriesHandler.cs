using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Application.Queries.Category;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Infrastructure.EF.Context;
using RoshanTarAzAftab.Infrastructure.EF.Models;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Infrastructure.EF.Queries.Handlers.Category;

internal class GetCategoriesHandler : IQueryHandler<GetCategories, IEnumerable<CategoryDto>>
{
    private readonly DbSet<CategoryReadModel> _categories;

    public GetCategoriesHandler(ReadDbContext readContext)
    {
        _categories = readContext.Category;
    }

    public async Task<IEnumerable<CategoryDto>> HandleAsync(GetCategories query)
    {
        return await _categories.Include(p=> p.Posts)
            .Select(c => c.ToCategoryDto())
            .ToListAsync();
    }
}
