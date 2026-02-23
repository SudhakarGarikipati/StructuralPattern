using AdapterDesignPattern.Adaptee;

namespace AdapterDesignPattern.Adapter
{
    public class SMSAdapter : INotificationService
    {
        private readonly SMSService _smsService;
        private readonly string _phoneNumber = "+1234567890";
        private readonly string _message;
        public SMSAdapter(SMSService sMSService, string  message) {
            _smsService = sMSService;
            _message = message;
        }

        public void SendNotification()
        {
            _smsService.SendSMS(this._phoneNumber, this._message);
        }
    }
}
