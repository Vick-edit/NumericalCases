using System.IO;
using NumericalCases.Dictionaries;
using NUnit.Framework;

namespace NumericalCases.Tests.DictionariesTests
{
    [TestFixture]
    public class DozensTests
    {
        [TestCase('0', "", Cases.Nominative, Genders.Masculine)]
        [TestCase('2', "двадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('3', "тридцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('4', "сорок", Cases.Nominative, Genders.Masculine)]
        [TestCase('5', "пятьдесят", Cases.Nominative, Genders.Masculine)]
        [TestCase('6', "шестьдесят", Cases.Nominative, Genders.Masculine)]
        [TestCase('7', "семьдесят", Cases.Nominative, Genders.Masculine)]
        [TestCase('8', "восемьдесят", Cases.Nominative, Genders.Masculine)]
        [TestCase('9', "девяносто", Cases.Nominative, Genders.Masculine)]
        public void GetStringTranscription_CorrectNumber_CorrectString(char number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var dozens = new Dozens();

            //act
            var result = dozens.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }

        [TestCase('-', Cases.Instrumental, Genders.Neuter)]
        [TestCase('+', Cases.Dative, Genders.Masculine)]
        [TestCase('1', Cases.Prepositional, Genders.Neuter)]
        public void GetStringTranscription_IncorrectNumber_Exception(char number, Cases caseVal, Genders genderVal)
        {
            //arrange
            var dozens = new Dozens();

            //act
            TestDelegate result = () => dozens.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.Throws<InvalidDataException>(result);
        }
    }
}