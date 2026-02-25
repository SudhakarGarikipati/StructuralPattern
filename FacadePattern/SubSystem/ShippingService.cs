namespace FacadePattern.SubSystem
{
    public class ShippingService
    {
        public bool ShipProduct()
        {
            Console.WriteLine("Product shipped please track you shipment using tracking number 000020002000");
            return true;
        }
    }
}
