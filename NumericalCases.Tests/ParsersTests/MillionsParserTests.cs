using NumericalCases.Parsers;
using NUnit.Framework;

namespace NumericalCases.Tests.ParsersTests
{
    [TestFixture]
    public class MillionsParserTests
    {
        [TestCase(78956041, "семьдесят восемь миллионов", Cases.Nominative, Genders.Feminine)]
        [TestCase(1654902, "один миллион", Cases.Nominative, Genders.Feminine)]
        [TestCase(352894489, "триста пятьдесят два миллиона", Cases.Nominative, Genders.Feminine)]
        public void ParseNumber_correctNumber_numberAsText(long number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var parser = new MillionsParser();

            //act
            var result = parser.ParseNumber(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }
    }
}