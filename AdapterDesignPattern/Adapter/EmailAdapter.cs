using AdapterDesignPattern.Adaptee;

namespace AdapterDesignPattern.Adapter
{
    public class EmailAdapter : INotificationService
    {
        private string _to = "developer@gmail.com";
        private readonly EMailService _emailService;
        private string _subject = "Build failure notification.";
        private string _message;

        public EmailAdapter(EMailService ems, string message) {
            _emailService = ems;
            _message = message;
        }

        public void SendNotification()
        {
            _emailService.SendEmail(this._to, this._subject, this._message);
        }
    }
}
