namespace BridgePattern.Abstraction
{
    public abstract class Message
    {
        // The IMessageSender is the implementor in the Bridge pattern, and it is used to send messages.
        protected readonly IMessageSender MessageSender;

        // The constructor takes an IMessageSender as a parameter, allowing the concrete message types to use it for sending messages.
        protected Message(IMessageSender messageSender)
        {
            MessageSender = messageSender;
        }

        // Abstract method to send a message, to be implemented by concrete message types
        public abstract void SendMessage(string message);
    }
   
}
