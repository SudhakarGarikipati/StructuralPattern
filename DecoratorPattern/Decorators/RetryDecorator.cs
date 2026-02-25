using DecoratorPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class RetryDecorator : BookServiceDecorator
    {
        private readonly int _maxRetryCount;
        public RetryDecorator(IBookService inner, int maxRetryCount) : base(inner)
        {
            _maxRetryCount = maxRetryCount;
        }

        public override string GetBookDetails(int bookId)
        {
            int retryCount = 0;
            while (true)
            {
                try
                {
                    retryCount++;
                    return base.GetBookDetails(bookId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching book details: {ex.Message}. Retrying... ({4 - retryCount}/3)");
                   
                    if (retryCount >= _maxRetryCount)
                    {
                        Console.WriteLine("All retries failed.");
                        throw; // Rethrow the exception after all retries are exhausted
                    }
                }
            }
        }
    }
}
