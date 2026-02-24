using BridgePattern.Abstraction;

namespace BridgePattern.Implementer
{
    public class NotificationSender : IMessageSender
    {
        public void SendMessage(string subject, string message)
        {
            Console.WriteLine($"Sending Notification with subject: {subject} and message: {message}");
        }
    }
}
