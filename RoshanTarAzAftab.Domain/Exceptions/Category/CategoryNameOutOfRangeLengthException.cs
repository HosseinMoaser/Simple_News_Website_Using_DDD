using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Category;

public class CategoryNameOutOfRangeLengthException : CategoryException
{
    public CategoryNameOutOfRangeLengthException(int maxLen) : base($"Category Name Could Not Be More Than {maxLen} Characters...!")
    {
    }
}
