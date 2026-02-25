namespace FacadePattern.SubSystem
{
    public class PaymentService
    {
        public bool ProcessPayment(double price)
        {
            Console.WriteLine("Payment is progress, please wait.");
            Thread.Sleep(1000);
            Console.WriteLine($"Payment successful, received amount {price}");
            return true;
        }
    }
}
