using System.Collections.Generic;
using System.IO;

namespace NumericalCases.Dictionaries
{
    public class BelowTen : IDictionary
    {
        private readonly IPrimitiveDictionary _oneDictionary;
        private readonly IPrimitiveDictionary _twoDictionary;
        private readonly Dictionary<char, Dictionary<Cases, string>> _otherDigits = FormDigitsToString();


        public BelowTen()
        {
            _oneDictionary = new OneDictionary();
            _twoDictionary = new TwoDictionary();
        }


        public string GetStringTranscription(char digit, Cases caseVal, Genders genderVal)
        {
            if (!char.IsDigit(digit))
                throw new InvalidDataException();

            switch (digit)
            {
                case '0':
                    return "";
                case '1':
                    return _oneDictionary.GetStringTranscription(caseVal, genderVal);
                case '2':
                    return _twoDictionary.GetStringTranscription(caseVal, genderVal);
                default:
                    return _otherDigits[digit][caseVal];
            }
        }

        private static Dictionary<char, Dictionary<Cases, string>> FormDigitsToString()
        {
            return new Dictionary<char, Dictionary<Cases, string>>
            {
                {
                    '3', new Dictionary<Cases, string>()
                    {
                        {Cases.Nominative, "три"},
                        {Cases.Genitive, "трёх"},
                        {Cases.Dative, "трём"},
                        {Cases.Accusative, "три"},
                        {Cases.Instrumental, "тремя"},
                        {Cases.Prepositional, "трёх"},
                    }
                },
                {
                    '4', new Dictionary<Cases, string>()
                    {
                        {Cases.Nominative, "четыре"},
                        {Cases.Genitive, "четырёх"},
                        {Cases.Dative, "четырём"},
                        {Cases.Accusative, "четыре"},
                        {Cases.Instrumental, "четырьмя"},
                        {Cases.Prepositional, "четырёх"},
                    }
                },
                {
                    '5', new Dictionary<Cases, string>()
                    {
                        {Cases.Nominative, "пять"},
                        {Cases.Genitive, "пяти"},
                        {Cases.Dative, "пяти"},
                        {Cases.Accusative, "пять"},
                        {Cases.Instrumental, "пятью"},
                        {Cases.Prepositional, "пяти"},
                    }
                },
                {
                    '6', new Dictionary<Cases, string>()
                    {
                        {Cases.Nominative, "шесть"},
                        {Cases.Genitive, "шести"},
                        {Cases.Dative, "шести"},
                        {Cases.Accusative, "шесть"},
                        {Cases.Instrumental, "шестью"},
                        {Cases.Prepositional, "шести"},
                    }
                },
                {
                    '7', new Dictionary<Cases, string>()
                    {
                        {Cases.Nominative, "семь"},
                        {Cases.Genitive, "семи"},
                        {Cases.Dative, "семи"},
                        {Cases.Accusative, "семь"},
                        {Cases.Instrumental, "семью"},
                        {Cases.Prepositional, "семи"},
                    }
                },
                {
                    '8', new Dictionary<Cases, string>()
                    {
                        {Cases.Nominative, "восемь"},
                        {Cases.Genitive, "восьми"},
                        {Cases.Dative, "восьми"},
                        {Cases.Accusative, "восемь"},
                        {Cases.Instrumental, "восьмью"},
                        {Cases.Prepositional, "восьми"},
                    }
                },
                {
                    '9', new Dictionary<Cases, string>()
                    {
                        {Cases.Nominative, "девять"},
                        {Cases.Genitive, "девяти"},
                        {Cases.Dative, "девяти"},
                        {Cases.Accusative, "девять"},
                        {Cases.Instrumental, "девятью"},
                        {Cases.Prepositional, "девяти"},
                    }
                },
            };
        }
    }
}