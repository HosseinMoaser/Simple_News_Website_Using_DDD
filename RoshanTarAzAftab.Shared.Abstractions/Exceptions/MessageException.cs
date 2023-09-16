namespace RoshanTarAzAftab.Shared.Abstractions.Exceptions
{
    public abstract class MessageException : Exception
    {
        public MessageException(string message) : base (message)
        {

        }
    }
}
