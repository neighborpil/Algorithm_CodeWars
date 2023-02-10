/*


 */
namespace SolutionTests
{
    class FindTheUniqueNumberTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
        public int BaseTest(IEnumerable<int> numbers)
        {
            return FindTheUniqueNumber.GetUnique(numbers);
        }

        [Test]
        public void IfNullEntered()
        {
            //Assert.AreEqual(MakeAFunctionThatDoesArithmetic.Arithmetic(1, 2, ""), Double.NaN);
            //Assert.AreEqual(MakeAFunctionThatDoesArithmetic.Arithmetic(1, 2, null), Double.NaN);
        }

        [Test]
        public void IfDividedByZero()
        {
            //Assert.AreEqual(MakeAFunctionThatDoesArithmetic.Arithmetic(1, 0, "divide"), Double.NaN);
        }


    }
}