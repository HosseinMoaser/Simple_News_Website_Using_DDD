using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Category;

public class CategoryNameNullOrEmptyException : CategoryException
{
    public CategoryNameNullOrEmptyException() : base("Category Name Could Not Be Null Or Empty...!")
    {
    }
}
