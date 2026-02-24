using BridgePattern.Abstraction;
using BridgePattern.Implementer;

namespace BridgePattern.Client
{
    public static class BridgeClient
    {
        public static void Execute()
        {
            // Create an instance of the implementer (EmailSender) and use it to create different types of messages (InfoMessage, ErrorMessage, NotificationMessage).
            IMessageSender emailSender = new EmailSender();
            Message infoMessage = new InfoMessage(emailSender);
            infoMessage.SendMessage("This is an informational message.");

            Message errorMessage = new ErrorMessage(emailSender);
            errorMessage.SendMessage("This is an error message.");

            Message warningMessage = new NotificationMessage(emailSender);
            warningMessage.SendMessage("This is a warning message.");

            // Now, we can easily switch to a different implementer (SMSSender) without changing the message types.
            IMessageSender messageSender = new SMSSender();
            infoMessage = new InfoMessage(messageSender);
            infoMessage.SendMessage("This is an informational message.");

            errorMessage = new ErrorMessage(messageSender);
            errorMessage.SendMessage("This is an error message.");

            warningMessage = new NotificationMessage(messageSender);
            warningMessage.SendMessage("This is a warning message.");

            // Finally, we can also use a different implementer (NotificationSender) to send messages through push notifications.
            IMessageSender pushNotificationSender = new NotificationSender();
            infoMessage = new InfoMessage(pushNotificationSender);
            infoMessage.SendMessage("This is an informational message.");

            errorMessage = new ErrorMessage(pushNotificationSender);
            errorMessage.SendMessage("This is an error message.");

            warningMessage = new NotificationMessage(pushNotificationSender);
            warningMessage.SendMessage("This is a warning message.");
        }

    }
}
