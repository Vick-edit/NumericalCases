using NumericalCases.Parsers;
using NUnit.Framework;

namespace NumericalCases.Tests.ParsersTests
{
    [TestFixture]
    public class BelowThousandParserTests
    {
        [TestCase(41, "сорок одна", Cases.Nominative, Genders.Feminine)]
        [TestCase(902, "девятьсот две", Cases.Nominative, Genders.Feminine)]
        [TestCase(489, "четыреста восемьдесят девять", Cases.Nominative, Genders.Feminine)]
        public void ParseNumber_correctNumber_numberAsText(long number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var parser = new BelowThousandParser();

            //act
            var result = parser.ParseNumber(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }
    }
}