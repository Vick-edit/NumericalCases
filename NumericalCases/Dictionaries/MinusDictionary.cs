using System.Collections.Generic;

namespace NumericalCases.Dictionaries
{
    internal class MinusDictionary : IPrimitiveDictionary
    {
        private readonly Dictionary<Cases, string> _minusDictionary = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "минус"},
            {Cases.Genitive, "минуса"},
            {Cases.Dative, "минусу"},
            {Cases.Accusative, "минус"},
            {Cases.Instrumental, "минусом"},
            {Cases.Prepositional, "минусе"},
        };

        public string GetStringTranscription(Cases caseVal, Genders genderVal)
        {
            return _minusDictionary[caseVal];
        }
    }
}