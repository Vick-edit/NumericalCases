using System.IO;
using NumericalCases.Dictionaries;
using NUnit.Framework;

namespace NumericalCases.Tests.DictionariesTests
{
    [TestFixture]
    public class HundredsTests
    {
        [TestCase('0', "", Cases.Nominative, Genders.Masculine)]
        [TestCase('1', "сто", Cases.Nominative, Genders.Masculine)]
        [TestCase('2', "двести", Cases.Nominative, Genders.Masculine)]
        [TestCase('3', "триста", Cases.Nominative, Genders.Masculine)]
        [TestCase('4', "четыреста", Cases.Nominative, Genders.Masculine)]
        [TestCase('5', "пятьсот", Cases.Nominative, Genders.Masculine)]
        [TestCase('6', "шестьсот", Cases.Nominative, Genders.Masculine)]
        [TestCase('7', "семьсот", Cases.Nominative, Genders.Masculine)]
        [TestCase('8', "восемьсот", Cases.Nominative, Genders.Masculine)]
        [TestCase('9', "девятьсот", Cases.Nominative, Genders.Masculine)]
        public void GetStringTranscription_CorrectNumber_CorrectString(char number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var hundreds = new Hundreds();

            //act
            var result = hundreds.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }

        [TestCase('-', Cases.Instrumental, Genders.Neuter)]
        [TestCase('+', Cases.Dative, Genders.Masculine)]
        [TestCase('d', Cases.Prepositional, Genders.Neuter)]
        public void GetStringTranscription_IncorrectNumber_Exception(char number, Cases caseVal, Genders genderVal)
        {
            //arrange
            var hundreds = new Hundreds();

            //act
            TestDelegate result = () => hundreds.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.Throws<InvalidDataException>(result);
        }
    }
}