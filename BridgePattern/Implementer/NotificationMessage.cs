using BridgePattern.Abstraction;

namespace BridgePattern.Implementer
{
    public class NotificationMessage : Message
    {
        private readonly IMessageSender _messageSender;
        public NotificationMessage(IMessageSender messageSender) : base(messageSender)
        {
            _messageSender = messageSender;
        }
        public override void SendMessage(string message)
        {
            _messageSender.SendMessage("Notification", message);
        }
    }
}
