using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var numStr = Enumerable.Range(1, 30).ToList()
                .Select(i => i % 15 == 0 ? "FizzBuzz" : (i % 5 == 0 ? "Fizz" : (i % 3 == 0 ? "Buzz" : i.ToString())));
            foreach (var num in numStr)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    } 
}
