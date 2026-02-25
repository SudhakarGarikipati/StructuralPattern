using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    public abstract class BookServiceDecorator : IBookService
    {
        protected readonly IBookService _inner;

        protected BookServiceDecorator(IBookService inner)
        {
            _inner = inner;
        }

        public virtual string GetBookDetails(int bookId)
        {
            return _inner.GetBookDetails(bookId);
        }
    }
}
