using NUnit.Framework;
using Solutions;
using System;

/*
 *
 *
Given two numbers and an arithmetic operator (the name of it, as a string), return the result of the two numbers having that operator used on them.

a and b will both be positive integers, and a will always be the first number in the operation, and b always the second.

The four operators are "add", "subtract", "divide", "multiply".

A few examples:(Input1, Input2, Input3 --> Output)

 *
 */
namespace SolutionTests
{
    class MakeAFunctionThatDoesArithmeticTest    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        ///
        /// </summary>
        [Test]
        public void Arithmetic()
        {
            Assert.AreEqual(3, MakeAFunctionThatDoesArithmetic.Arithmetic(1, 2, "add"));
            Assert.AreEqual(6, MakeAFunctionThatDoesArithmetic.Arithmetic(8, 2, "subtract"));
            Assert.AreEqual(10, MakeAFunctionThatDoesArithmetic.Arithmetic(5, 2, "multiply"));
            Assert.AreEqual(4, MakeAFunctionThatDoesArithmetic.Arithmetic(8, 2, "divide"));
        }

        [Test]
        public void IfNullEntered()
        {
            Assert.AreEqual(MakeAFunctionThatDoesArithmetic.Arithmetic(1, 2, ""), Double.NaN);
            Assert.AreEqual(MakeAFunctionThatDoesArithmetic.Arithmetic(1, 2, null), Double.NaN);
        }

        [Test]
        public void IfDividedByZero()
        {
            Assert.AreEqual(MakeAFunctionThatDoesArithmetic.Arithmetic(1, 0, "divide"), Double.NaN);
        }


    }
}