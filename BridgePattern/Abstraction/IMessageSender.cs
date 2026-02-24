
namespace BridgePattern.Abstraction
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string message);
    }
}
