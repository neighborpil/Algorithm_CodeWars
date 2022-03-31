using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public static class Extensions
    {
        public static string ReverseString(this string message)
        {
            List<char> chars = message.ToList();
            chars.Reverse();
            return new string(chars.ToArray());
        }

        public static List<T> MyReverse<T>(this List<T> before)
        {
            List<T> after = new List<T>();

            for (int i = before.Count() - 1; i >= 0; i--)
            {
                after.Add(before[i]);
            }
            
            return after;
        }
    }
}
