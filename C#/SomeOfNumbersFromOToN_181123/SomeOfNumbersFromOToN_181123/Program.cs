using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

/*
Description:

We want to generate a function that computes the series starting from 0 and ending until the given number following the sequence:

0 1 3 6 10 15 21 28 36 45 55 ....

which is created by

0, 0+1, 0+1+2, 0+1+2+3, 0+1+2+3+4, 0+1+2+3+4+5, 0+1+2+3+4+5+6, 0+1+2+3+4+5+6+7 etc..

Input:

LastNumber

Output:

series and result

Example:
Input:

> 6
Output:

0+1+2+3+4+5+6 = 21

Input:

> -15
Output:

-15<0

Input:

> 0
Output:

0=0

*/
namespace SomeOfNumbersFromOToN_181123
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }

    public class SequenceSum
    {
        
        public static string ShowSequence_BestPractices(int n)
        {
            if (n < 0)
                return $"{n}<0";
            if (n == 0)
                return "0=0";

            var sequence = Enumerable.Range(0, n + 1);
            return $"{string.Join("+", sequence)} = {sequence.Sum()}";
        }


        public static string ShowSequence(int n)
        {
            string result = "";

            if (n > 0)
            {
                int value = CalcSequence(n);
                StringBuilder sb = new StringBuilder();
                Enumerable.Range(0, n + 1).ToList().ForEach(i => sb.Append(i == n ? i.ToString() : $"{i}+"));
                result = $"{sb.ToString()} = {value}";
            }
            else if (n == 0)
                result = $"{n}=0";
            else
            {
                result = $"{n}<0";
            }
            return result;
        }

        public static int CalcSequence(int n)
        {
            int value = 0;
            if (n > 0)
                value = n + CalcSequence(n - 1);

            return value;
        }
        [TestFixture]
        public class SequenceSumTests
        {
            [Test]
            public void BasicTests()
            {
                Assert.AreEqual("0+1+2+3+4+5+6 = 21", SequenceSum.ShowSequence(6));
                Assert.AreEqual("-15<0", SequenceSum.ShowSequence(-15));
                Assert.AreEqual("0=0", SequenceSum.ShowSequence(0));
            }
        }
    }
}
