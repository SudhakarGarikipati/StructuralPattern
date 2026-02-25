using FacadePattern.SubSystem;

namespace FacadePattern.Facade
{
    public class OrderFacade
    {
        private readonly InventoryService _inventoryService;
        private readonly ShippingService _shippingService;
        private readonly NotificationService _notificationService;
        private readonly PaymentService _paymentService;

        public OrderFacade()
        {
            _inventoryService = new InventoryService();
            _shippingService = new ShippingService();
            _notificationService = new NotificationService();
            _paymentService = new PaymentService();
        }

        public void PlaceOrder(int productId, double price) {

            Console.WriteLine("Placing the order....");
            if(_inventoryService.CheckStock(productId))
            {
                if(_paymentService.ProcessPayment(price))
                {
                    _shippingService.ShipProduct();
                }
                else
                {
                    Console.WriteLine("Payment failed retry again...");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Product out of stock :(");
                return;
            }
            Console.WriteLine("Order placed successfully!");

        }
    }
}
