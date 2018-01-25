using System.Collections.Generic;
using System.IO;

namespace NumericalCases.Dictionaries
{
    public class Hundreds : IDictionary
    {
        private readonly IDictionary _belowTenDictionary;


        public Hundreds()
        {
            _belowTenDictionary = new BelowTen();
        }


        private readonly Dictionary<Cases, string> _oneHundred = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "сто"},
            {Cases.Genitive, "ста"},
            {Cases.Dative, "ста"},
            {Cases.Accusative, "сто"},
            {Cases.Instrumental, "ста"},
            {Cases.Prepositional, "ста"},
        };

        private readonly Dictionary<Cases, string> _twoHundred = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "двести"},
            {Cases.Genitive, "двухсот"},
            {Cases.Dative, "двумстам"},
            {Cases.Accusative, "двести"},
            {Cases.Instrumental, "двумястами"},
            {Cases.Prepositional, "двухстах"},
        };

        private readonly Dictionary<Cases, string> _lowHundreds = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "ста"},
            {Cases.Genitive, "сот"},
            {Cases.Dative, "стам"},
            {Cases.Accusative, "ста"},
            {Cases.Instrumental, "стами"},
            {Cases.Prepositional, "стах"},
        };

        private readonly Dictionary<Cases, string> _highHundreds = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "сот"},
            {Cases.Genitive, "сот"},
            {Cases.Dative, "стам"},
            {Cases.Accusative, "сот"},
            {Cases.Instrumental, "стами"},
            {Cases.Prepositional, "стах"},
        };

        public string GetStringTranscription(char digit, Cases caseVal, Genders genderVal)
        {
            if (!char.IsDigit(digit))
                throw new InvalidDataException();

            switch (digit)
            {
                case '0':
                    return "";
                case '1':
                    return _oneHundred[caseVal];
                case '2':
                    return _twoHundred[caseVal];
                case '3':
                case '4':
                    var prefixLow = _belowTenDictionary.GetStringTranscription(digit, caseVal, genderVal);
                    var suffixLow = _lowHundreds[caseVal];
                    return prefixLow + suffixLow;
                default:
                    var prefixHigh = _belowTenDictionary.GetStringTranscription(digit, caseVal, genderVal);
                    var suffixHigh= _highHundreds[caseVal];
                    return prefixHigh + suffixHigh;
            }
        }
    }
}