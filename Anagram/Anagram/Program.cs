using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = anagram("pineapple");
            Console.WriteLine(s);

            Console.ReadKey();
        }

        public static string anagram(string message)
        {
            List<char> result = new List<char>();
            List<char> words = message.ToList();
            Random rnd = new Random();
            for (int i = message.Length - 1; i >= 0; i--)
            {
                int idx = rnd.Next(0, i);
                char ele = words.ElementAt(idx);
                words.RemoveAt(idx);
                result.Add(ele);
            }

            return new string(result.ToArray());
        }
    }
}
