using RoshanTarAzAftab.Application.DTOs;
using RoshanTarAzAftab.Shared.Abstractions.Queries;

namespace RoshanTarAzAftab.Application.Queries.Category;

public class GetCategories : IQuery<IEnumerable<CategoryDto>>
{
    public List<CategoryDto> Categories { get; set; }
}
