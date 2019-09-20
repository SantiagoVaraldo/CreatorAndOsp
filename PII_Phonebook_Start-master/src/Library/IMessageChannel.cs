namespace Library
{
    public interface IMessageChannel
    {
        // tenia un objeto mensage como parametro
        void Send(string from, string to, string text);
    }
}