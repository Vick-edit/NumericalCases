using System.Collections.Generic;
using System.IO;
using System.Text;
using NumericalCases.Dictionaries;
using NumericalCases.Parsers;

namespace NumericalCases
{
    public class NumbersToText : INumbersToText
    {
        private readonly IPrimitiveDictionary _zeroDictionary;
        private readonly IPrimitiveDictionary _minusDictionary;
        private readonly INumericalParser _numericalParser;

        private readonly Dictionary<string, Cases> _caseses = new Dictionary<string, Cases>
        {
            { "И", Cases.Nominative },
            { "Р", Cases.Genitive },
            { "Д", Cases.Dative },
            { "В", Cases.Accusative },
            { "Т", Cases.Instrumental },
            { "П", Cases.Prepositional },
        };

        private readonly Dictionary<string, Genders> _genders = new Dictionary<string, Genders>
        {
            { "Ж", Genders.Feminine },
            { "М", Genders.Masculine },
            { "С", Genders.Neuter },
        };

        public NumbersToText()
        {
            _zeroDictionary = new ZeroDictionary();
            _minusDictionary = new MinusDictionary();

            INumericalParser innerParser = new BillionParser();
            innerParser = new MillionsParser(innerParser); 
             innerParser = new ThousandsParser(innerParser);
            _numericalParser = new BelowThousandParser(innerParser); 
        }

        public string sumProp(long nSum, string sGender, string sCase)
        {
            if (!_caseses.ContainsKey(sCase) || !_genders.ContainsKey(sGender))
                throw new InvalidDataException();

            var caseVal = _caseses[sCase];
            var genderVal = _genders[sGender];

            if (nSum == 0)
                return _zeroDictionary.GetStringTranscription(caseVal, genderVal);

            var resultContainer = new StringBuilder();
            if (nSum < 0)
            {
                var minusText = _minusDictionary.GetStringTranscription(caseVal, genderVal);
                resultContainer.Append(minusText);
                resultContainer.Append(" ");
                nSum *= -1;
            }
            var numberText = _numericalParser.ParseNumber(nSum, caseVal, genderVal);
            resultContainer.Append(numberText);
            return resultContainer.ToString();
        }
    }
}