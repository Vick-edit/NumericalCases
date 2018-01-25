using NumericalCases.Parsers;
using NUnit.Framework;

namespace NumericalCases.Tests.ParsersTests
{
    [TestFixture]
    public class BillionParserTests
    {
        [TestCase(9456200141, "девять миллиардов", Cases.Nominative, Genders.Feminine)]
        [TestCase(221456821902, "двести двадцать один миллиард", Cases.Nominative, Genders.Feminine)]
        [TestCase(37564564489, "тридцать семь миллиардов", Cases.Nominative, Genders.Feminine)]
        public void ParseNumber_correctNumber_numberAsText(long number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var parser = new BillionParser();

            //act
            var result = parser.ParseNumber(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }
    }
}