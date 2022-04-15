using System;
using System.Collections.Generic;

namespace Solutions
{
    public static class FindTheCapitals
    {
        public static int[] Capitals(string word)
        {
            var indexes = new List<int>();

            if (!string.IsNullOrWhiteSpace(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    var c = word[i];
                    if (Char.IsUpper(c))
                    {
                        indexes.Add(i);
                    }
                }
            }
            return indexes.ToArray();
        }
    }
}