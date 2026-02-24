using BridgePattern.Abstraction;

namespace BridgePattern.Implementer
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string message)
        {
            Console.WriteLine($"Sending [Email] with subject: {subject} and message: {message}");
        }
    }
}
