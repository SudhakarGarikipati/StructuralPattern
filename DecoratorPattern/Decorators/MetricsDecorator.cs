using DecoratorPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class MetricsDecorator : BookServiceDecorator
    {
        public MetricsDecorator(IBookService inner) : base(inner)
        {
        }

        public override string GetBookDetails(int bookId)
        {
            var startTime = DateTime.Now;
            var result = base.GetBookDetails(bookId);
            var endTime = DateTime.Now;
            Console.WriteLine($"Metrics: Fetching details for book ID {bookId} took {(endTime - startTime).TotalMilliseconds} ms.");
            return result;
        }
    }
}
