namespace RoshanTarAzAftab.Domain.ValueObjects;

public record PostDate
{
    public DateTime Value { get; }
    public PostDate(DateTime value)
    {
        if (value == DateTime.MinValue)
        {
            Value = DateTime.Now;
        }

        Value = value;
    }

    public static implicit operator DateTime(PostDate date) => date.Value;
    public static implicit operator PostDate(DateTime date) => new(date);

}
