using FacadePattern.Models;

namespace FacadePattern.SubSystem
{
    public class InventoryService
    {
        private readonly List<Product> products;
        public InventoryService()
        {
            products =
            [
                new Product(){ Id = 1, Name ="Book", Description= "Grade 2 English Book" },
                 new Product(){Id = 2, Name ="Book", Description= "Grade 2 Science Book"  },
                  new Product(){ Id = 3, Name ="Pen", Description= "Gel Pen" },
            ];

        }
        public bool CheckStock(int productID)
        {
            Console.WriteLine("Checking.. stock");
            if (products.Count > 0 && products.Find(t => t.Id == productID) != null)
            {
                Console.WriteLine($"Stock available.");
                return true;
            }
            Console.WriteLine($"Out of stock.");
            return true;
        }

    }
}
