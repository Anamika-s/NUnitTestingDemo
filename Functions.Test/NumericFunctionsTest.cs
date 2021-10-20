using NUnit.Framework;
using System;

namespace Functions.Test
{
    [TestFixture]
    public class NumericFunctionsTest
    {
        [Test]
        public void AddNumbersTest1()
        {
            // AAA
            // A > Arrange
            // A > Act
            // A > Assert
            // Arrange
            Functions.NumericFunctions numericFunctions = new NumericFunctions();

            // Act
            int actual = numericFunctions.AddNumbers(10, 20);

            // Assert
            int expected = 30;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AddNumbersTest2()
        {
            NumericFunctions numericFunctions = new NumericFunctions();
            int actual= numericFunctions.AddNumbers(10, 20);
            Assert.AreEqual(40, 30);
        }
        [Test]
        public void AddNumbersTest3()
        {
            NumericFunctions numericFunctions = new NumericFunctions();
            int actual = numericFunctions.AddNumbers(20, 20);
            Assert.AreEqual(40, actual);
        }
        [Test]
        public void AddNumbersTest4()
        {
            NumericFunctions numericFunctions = new NumericFunctions();
            int actual = numericFunctions.AddNumbers(120, 20);
            Assert.AreEqual(140, actual);
        }



        [TestCase(10, 20, 30)]
        [TestCase(40, 20, 60)]
        [TestCase(60, 20, 80)]
        [TestCase(20, 20, 30)]
        [TestCase(20, 20, 40)]

        public void AddnumbersTest(int x, int y, int expected)
        {
            NumericFunctions numericFunctions = new NumericFunctions();
            int actual = numericFunctions.AddNumbers(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
