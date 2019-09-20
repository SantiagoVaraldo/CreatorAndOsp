namespace Library
{
    public interface IMessageChannel
    {
        void Send(string from, string to, string text);
    }
}