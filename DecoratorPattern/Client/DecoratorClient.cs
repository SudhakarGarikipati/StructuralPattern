using DecoratorPattern.Components;
using DecoratorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Client
{
    public static class DecoratorClient
    {
       static IBookService bookService = new LoggingDecorator(new CachingDecorator(new RetryDecorator(new MetricsDecorator( new BookService()),2)));

        public static void Execute()
        {
            Console.WriteLine(bookService.GetBookDetails(7));
            Console.WriteLine(bookService.GetBookDetails(1)); // This will hit the cache
        }
    }
}
