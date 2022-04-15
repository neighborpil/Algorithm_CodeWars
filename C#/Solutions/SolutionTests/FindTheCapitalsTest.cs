using NUnit.Framework;

namespace SolutionTests
{
    public class FindTheCapitalsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.
        /// </summary>
        [Test]
        public void CodEWaRs()
        {
            Assert.AreEqual(Solutions.FindTheCapitals.Capitals("CodEWaRs"), new int[] { 0, 3, 4, 6 });
        }

        [Test]
        public void IfNullEntered()
        {
            Assert.AreEqual(Solutions.FindTheCapitals.Capitals(null), new int[] { });
        }

        [Test]
        public void IfNumberEntered()
        {
            Assert.AreEqual(Solutions.FindTheCapitals.Capitals("1234"), new int[] { });
        }

        [Test]
        public void IfKoreanEntered()
        {
            Assert.AreEqual(Solutions.FindTheCapitals.Capitals("°¨³ª¶ó"), new int[] { });
        }



    }
}