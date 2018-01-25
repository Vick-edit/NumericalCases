using System;
using System.IO;
using NumericalCases.Dictionaries;
using NUnit.Framework;

namespace NumericalCases.Tests.DictionariesTests
{
    [TestFixture]
    public class BelowTenTests
    {
        [TestCase('0', "", Cases.Genitive, Genders.Masculine)]
        [TestCase('1', "одно", Cases.Accusative, Genders.Neuter)]
        [TestCase('2', "двум", Cases.Dative, Genders.Feminine)]
        [TestCase('3', "тремя", Cases.Instrumental, Genders.Masculine)]
        [TestCase('4', "четырёх", Cases.Prepositional, Genders.Feminine)]
        [TestCase('5', "пять", Cases.Nominative, Genders.Neuter)]
        [TestCase('6', "шесть", Cases.Nominative, Genders.Masculine)]
        [TestCase('7', "семью", Cases.Instrumental, Genders.Neuter)]
        [TestCase('8', "восьми", Cases.Dative, Genders.Masculine)]
        [TestCase('9', "девяти", Cases.Prepositional, Genders.Neuter)]
        public void GetStringTranscription_CorrectNumber_CorrectString(char number, string resultTest, Cases caseVal, Genders genderVal)
        {
            //arrange
            var belowTenDict = new BelowTen();

            //act
            var result = belowTenDict.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.That(result, Is.EqualTo(resultTest));
        }

        [TestCase('-', Cases.Instrumental, Genders.Neuter)]
        [TestCase('+', Cases.Dative, Genders.Masculine)]
        [TestCase('d', Cases.Prepositional, Genders.Neuter)]
        public void GetStringTranscription_IncorrectNumber_Exception(char number, Cases caseVal, Genders genderVal)
        {
            //arrange
            var belowTenDict = new BelowTen();

            //act
            TestDelegate result = () => belowTenDict.GetStringTranscription(number, caseVal, genderVal);

            //assert
            Assert.Throws<InvalidDataException>(result);
        }
    }
}