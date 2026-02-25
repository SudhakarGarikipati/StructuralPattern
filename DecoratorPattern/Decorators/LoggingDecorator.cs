using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    public class LoggingDecorator : BookServiceDecorator
    {

        public LoggingDecorator(IBookService inner) : base(inner) { }

        public override string GetBookDetails(int bookId)
        {
            Console.WriteLine($"Logging: Fetching details for book ID {bookId}.");
            var bookdtls =  base.GetBookDetails(bookId);
            Console.WriteLine($"Logging: Retrieved details for book ID {bookId}.");
            return bookdtls;
        }
    }
}
