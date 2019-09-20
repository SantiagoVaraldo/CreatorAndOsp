namespace Library
{
    // la hice abstracta
    public class Message
    {
        // era protected
        public Message(string from, string to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }
        // cree un metodo abstracto send
        //public abstract void Send(string from, string to, string text);

        public string Text { get; set; }

        public string From { get; }

        public string To { get; }
    }
}