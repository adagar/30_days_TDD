using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ThirtydaysTDD.UnitTests
{
    [TestFixture]
    public class StringUtils
    {
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            //Arrange
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;
            var stringUtils = new StringUtils();

            //Act
            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            //Assert
        }
    }
}
