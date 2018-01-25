using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace NumericalCases.Dictionaries
{
    public class Dozens : IDictionary
    {
        private readonly IDictionary _belowTenDictionary;


        public Dozens()
        {
            _belowTenDictionary = new BelowTen();
        }


        private readonly Dictionary<Cases, string> _suffixLow = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "дцать"},
            {Cases.Genitive, "дцати"},
            {Cases.Dative, "дцати"},
            {Cases.Accusative, "дцать"},
            {Cases.Instrumental, "дцатью"},
            {Cases.Prepositional, "дцати"},
        };

        private readonly Dictionary<Cases, string> _suffixHigh = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "десят"},
            {Cases.Genitive, "десяти"},
            {Cases.Dative, "десяти"},
            {Cases.Accusative, "десят"},
            {Cases.Instrumental, "десятью"},
            {Cases.Prepositional, "десяти"},
        };

        private readonly Dictionary<Cases, string> _forty = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "сорок"},
            {Cases.Genitive, "сорока"},
            {Cases.Dative, "сорока"},
            {Cases.Accusative, "сорок"},
            {Cases.Instrumental, "сорока"},
            {Cases.Prepositional, "сорока"},
        };

        private readonly Dictionary<Cases, string> _ninety = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "девяносто"},
            {Cases.Genitive, "девяноста"},
            {Cases.Dative, "девяноста"},
            {Cases.Accusative, "девяносто"},
            {Cases.Instrumental, "девяноста"},
            {Cases.Prepositional, "девяноста"},
        };

        public string GetStringTranscription(char digit, Cases caseVal, Genders genderVal)
        {
            if (!char.IsDigit(digit))
                throw new InvalidDataException();

            switch (digit)
            {
                case '0':
                    return "";
                case '2':
                case '3':
                    var prefixLow = _belowTenDictionary.GetStringTranscription(digit, Cases.Nominative, Genders.Masculine);
                    var suffixLow = _suffixLow[caseVal];
                    return prefixLow + suffixLow;
                case '4':
                    return _forty[caseVal];
                case '5':
                case '6':
                case '7':
                case '8':
                    var prefixHigh = _belowTenDictionary.GetStringTranscription(digit, caseVal, genderVal);
                    var suffixHigh = _suffixHigh[caseVal];
                    return prefixHigh + suffixHigh;
                case '9':
                    return _ninety[caseVal];
                default:
                    throw new InvalidDataException();
            }
        }


    }
}