namespace RoshanTarAzAftab.Application.DTOs;

public class CategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<PostDto> Posts { get; set; }
}
