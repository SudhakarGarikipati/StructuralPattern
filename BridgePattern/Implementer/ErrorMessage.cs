using BridgePattern.Abstraction;

namespace BridgePattern.Implementer
{
    public class ErrorMessage : Message
    {
        private readonly IMessageSender _messageSender;

        public ErrorMessage(IMessageSender messageSender) : base(messageSender)
        {
            _messageSender = messageSender;
        }

        public override void SendMessage(string message)
        {
            _messageSender.SendMessage("Error", message);
        }
    }
}
