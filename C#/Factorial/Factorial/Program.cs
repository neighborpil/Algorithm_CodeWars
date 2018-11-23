using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 10;
            long value = 1;
            for (int i = 1; i <= input; i++)
            {
                value *= i;
            }

            Console.WriteLine(assert(3628800, value));
            Console.ReadKey();
        }

        public static bool assert(long answer, long value)
        {
            if (answer == value)
                return true;
            return false;
        }
    }
}
