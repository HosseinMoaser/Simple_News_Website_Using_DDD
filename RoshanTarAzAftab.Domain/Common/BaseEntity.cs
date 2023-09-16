using RoshanTarAzAftab.Domain.ValueObjects;

namespace RoshanTarAzAftab.Domain.Common;

public abstract class BaseEntity
{
    public BaseEntityId Id { get; private set; }

	public BaseEntity(BaseEntityId id)
	{
		Id = id;
	}
}
