using System.Collections.Generic;

namespace NumericalCases.Dictionaries
{
    internal class ZeroDictionary : IPrimitiveDictionary
    {
        private readonly Dictionary<Cases, string> _zeroDictionary = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "ноль"},
            {Cases.Genitive, "ноля"},
            {Cases.Dative, "нолю"},
            {Cases.Accusative, "ноль"},
            {Cases.Instrumental, "нолём"},
            {Cases.Prepositional, "ноле"},
        };

        public string GetStringTranscription(Cases caseVal, Genders genderVal)
        {
            return _zeroDictionary[caseVal];
        }
    }
}