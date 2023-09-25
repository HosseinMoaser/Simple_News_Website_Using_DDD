using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Category;

public class GetCategoryById : IQuery<CategoryDto>
{
    public Guid Id { get; set; }
}
