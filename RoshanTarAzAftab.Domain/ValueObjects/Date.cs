namespace RoshanTarAzAftab.Domain.ValueObjects;

public record Date
{
    public DateTime Value { get; }
    public Date(DateTime value)
    {
        if (value == DateTime.MinValue)
        {
            Value = DateTime.Now;
        }

        Value = value;
    }

    public static implicit operator DateTime(Date date) => date.Value;
    public static implicit operator Date(DateTime date) => new(date);

}
