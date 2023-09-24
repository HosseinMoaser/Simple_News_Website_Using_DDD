using RoshanTarAzAftab.Domain.ValueObjects.Category;
using RoshanTarAzAftab.Shared.Abstractions.Exceptions;

namespace RoshanTarAzAftab.Domain.Exceptions.Post;

public class PostAlreadyExistsException : PostException
{
    public PostAlreadyExistsException(CategoryName category) : base($"This Post Is Already Exists In {category.Value} category...!")
    {
    }
}
