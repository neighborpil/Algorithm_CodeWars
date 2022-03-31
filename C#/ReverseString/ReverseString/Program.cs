using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string reversed = "message".ReverseString();
            var reversed = "message".Reverse();
            Console.WriteLine(new string(reversed.ToArray()));

            List<int> before = new List<int>() { 0, 1, 2, 3, 4 };
            before.MyReverse().ForEach(a => Console.Write($"{a} "));

            Console.ReadKey();
        }
    }
}
