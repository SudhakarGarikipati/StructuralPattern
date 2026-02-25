using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    public class CachingDecorator : BookServiceDecorator
    {
        private readonly Dictionary<int, string> _cache = new();

        public CachingDecorator(IBookService inner) : base(inner) { }

        public override string GetBookDetails(int bookId)
        {
            if (_cache.TryGetValue(bookId, out var cachedResult))
            {
                Console.WriteLine($"Cache hit for book ID {bookId}.");
                return cachedResult;
            }
            var bookDtls = base.GetBookDetails(bookId);
            _cache[bookId] = bookDtls;
            Console.WriteLine($"Cache miss for book ID {bookId}. Caching result.");
            return bookDtls;
        }
    }
}
