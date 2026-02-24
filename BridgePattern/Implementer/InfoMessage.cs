using BridgePattern.Abstraction;

namespace BridgePattern.Implementer
{
    public class InfoMessage : Message
    {
       private readonly IMessageSender _messageSender;
        public InfoMessage(IMessageSender messageSender) : base(messageSender)
        {
            _messageSender = messageSender;
        }
        public override void SendMessage(string message)
        {
            _messageSender.SendMessage("Info", message);
        }
    }
}
