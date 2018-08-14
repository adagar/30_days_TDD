using System;
using NUnit.Framework;
using CharCounterLibrary;

namespace _30DaysTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        [Test]
        public void ShouldBeAbleToCountCharInSimpleSentence()
        {
            //arrange
            var input = "TDD is awesome!";
            var charToScanFor = 'e';
            var expectedResult = 2;

            //Act
            var stringUtils = new CharCounter();
            int result = CharCounter.CountChar(input, charToScanFor);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentence()
        {
            var input = "Once is unique, twice is a coincidence, three times is a pattern.";
            var charToScanFor = 'n';
            var expected = 5;

            var stringUtils = new CharCounter();
            int result = CharCounter.CountChar(input, charToScanFor);

            Assert.AreEqual(expected, result);
        }

    }
}
