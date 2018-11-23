using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {


        static void Main(string[] args)
        {
            Enumerable.Range(0, 11).ToList().ForEach(i => Console.WriteLine(fibonacci(i)));
            Console.ReadKey();
        }

        public static int fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException();

            if (n == 1)
                return 1;
            else if (n == 0)
                return 0;
            return fibonacci(n - 1) + fibonacci(n - 2);


        }
    }
}
