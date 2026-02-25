using DecoratorPattern.Models;

namespace DecoratorPattern.Components
{
    public class BookService : IBookService
    {
        private readonly List<Book> _bookCollection;

        public BookService()
        {
            _bookCollection =
            [
                new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", 10.99m),
                new Book(2, "To Kill a Mockingbird", "Harper Lee", 8.99m),
                new Book(3, "1984", "George Orwell", 9.99m)
            ];
        }

        public string GetBookDetails(int bookId)
        {
            var book = _bookCollection.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                return $"Book with ID {bookId} not found.";
            }
            return book.Description;
        }
    }
}
