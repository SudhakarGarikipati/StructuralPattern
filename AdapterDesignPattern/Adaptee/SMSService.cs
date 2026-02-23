namespace AdapterDesignPattern.Adaptee
{
    public class SMSService
    {
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending SMS to: {phoneNumber}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
