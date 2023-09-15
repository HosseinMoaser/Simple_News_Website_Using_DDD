namespace RoshanTarAzAftab.Shared.Abstractions.Exceptions;

public abstract class BaseEntityException : Exception
{
	protected BaseEntityException(string message) : base(message) 
	{

	}
}
