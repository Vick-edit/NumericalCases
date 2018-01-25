using NumericalCases.Parsers;
using NUnit.Framework;

namespace NumericalCases.Tests.ParsersTests
{
    [TestFixture]
    public class ThousandsParserTests
    {
        [TestCase(1041, "одна тысяча", Cases.Nominative, Genders.Feminine)]
        [TestCase(56902, "пятьдесят шесть тысяч", Cases.Nominative, Genders.Feminine)]
        [TestCase(741489, "семьсот сорок одна тысяча", Cases.Nominative, Genders.Feminine)]
        public void ParseNumber_correctNumber_numberAsText(long number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var parser = new ThousandsParser();

            //act
            var result = parser.ParseNumber(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }
    }
}