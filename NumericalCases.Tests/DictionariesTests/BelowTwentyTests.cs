using System.IO;
using NumericalCases.Dictionaries;
using NUnit.Framework;

namespace NumericalCases.Tests.DictionariesTests
{
    [TestFixture]
    public class BelowTwentyTests
    {
        [TestCase('0', "десять", Cases.Nominative, Genders.Masculine)]
        [TestCase('1', "одиннадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('2', "двенадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('3', "тринадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('4', "четырнадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('5', "пятнадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('6', "шестнадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('7', "семнадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('8', "восемнадцать", Cases.Nominative, Genders.Masculine)]
        [TestCase('9', "девятнадцать", Cases.Nominative, Genders.Masculine)]
        public void GetStringTranscription_CorrectNumber_CorrectString(char number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var belowTwenty = new BelowTwenty();

            //act
            var result = belowTwenty.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }

        [TestCase('-', Cases.Instrumental, Genders.Neuter)]
        [TestCase('+', Cases.Dative, Genders.Masculine)]
        [TestCase('d', Cases.Prepositional, Genders.Neuter)]
        public void GetStringTranscription_IncorrectNumber_Exception(char number, Cases caseVal, Genders genderVal)
        {
            //arrange
            var belowTwenty = new BelowTwenty();

            //act
            TestDelegate result = () => belowTwenty.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.Throws<InvalidDataException>(result);
        }
    }
}