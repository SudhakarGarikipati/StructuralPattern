namespace FacadePattern.SubSystem
{
    public class NotificationService
    {
        public bool SendMailToStakeHolders()
        {
            Console.WriteLine("Email sent to the registered customer.");
            return true;
        }
    }
}
