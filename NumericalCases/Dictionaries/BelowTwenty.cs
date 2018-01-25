using System.Collections.Generic;
using System.IO;

namespace NumericalCases.Dictionaries
{
    public class BelowTwenty : IDictionary
    {
        private readonly Dictionary<char, string> _prefix = new Dictionary<char, string>
        {
            {'1', "один"},
            {'2', "две"},
            {'3', "три"},
            {'4', "четыр"},
            {'5', "пят"},
            {'6', "шест"},
            {'7', "сем"},
            {'8', "восем"},
            {'9', "девят"},
        };

        private readonly Dictionary<Cases, string> _suffix = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "надцать"},
            {Cases.Genitive, "надцати"},
            {Cases.Dative, "надцати"},
            {Cases.Accusative, "надцать"},
            {Cases.Instrumental, "надцатью"},
            {Cases.Prepositional, "надцати"},
        };

        private readonly Dictionary<Cases, string> _ten = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "десять"},
            {Cases.Genitive, "десяти"},
            {Cases.Dative, "десяти"},
            {Cases.Accusative, "десять"},
            {Cases.Instrumental, "десятью"},
            {Cases.Prepositional, "десяти"},
        };


        public string GetStringTranscription(char digit, Cases caseVal, Genders genderVal)
        {
            if (!char.IsDigit(digit))
                throw new InvalidDataException();

            if (digit == '0')
                return _ten[caseVal];
            else
                return _prefix[digit] + _suffix[caseVal];
        }
    }
}