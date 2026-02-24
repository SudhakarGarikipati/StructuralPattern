using BridgePattern.Abstraction;

namespace BridgePattern.Implementer
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string subject, string message)
        {
            Console.WriteLine($"Sending SMS with subject: {subject} and message: {message}");
        }
    }
}
