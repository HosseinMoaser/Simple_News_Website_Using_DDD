using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Application.Exceptions;

public class CategoryNotFoundException : CategoryException
{
    public CategoryNotFoundException() : base("Category Not Found...!")
    {
    }
}
