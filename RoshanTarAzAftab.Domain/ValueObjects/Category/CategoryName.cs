using RoshanTarAzAftab.Domain.Exceptions.Category;
using RoshanTarAzAftab.Domain.ValueObjects.Post;
using System.Xml.Linq;

namespace RoshanTarAzAftab.Domain.ValueObjects.Category;

public record CategoryName
{
    public string Value { get;}
	private const int maxLenght = 25;


	public CategoryName(string value)
	{
		if(string.IsNullOrWhiteSpace(value))
		{
			throw new CategoryNameNullOrEmptyException();
		}

		if(value.Length > maxLenght)
		{
			throw new CategoryNameOutOfRangeLengthException(maxLenght);
		}

		Value = value;
	}

    public static implicit operator string(CategoryName name) => name.Value;
    public static implicit operator CategoryName(string name) => new(name);
}
