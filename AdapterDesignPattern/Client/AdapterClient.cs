using AdapterDesignPattern.Adapter;

namespace AdapterDesignPattern.Client
{
    public static class AdapterClient
    {
        public static void Execute()
        {
            var emailService = new Adaptee.EMailService();
            var notifier = new EmailAdapter(emailService, "Build failed due to compilation errors.");
            notifier.SendNotification();

            var smsService = new Adaptee.SMSService();
            var smsNotifier = new SMSAdapter(smsService, "Build failed due to compilation errors.");
            smsNotifier.SendNotification();
        }
    }
}
