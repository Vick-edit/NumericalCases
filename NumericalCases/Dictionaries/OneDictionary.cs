using System.Collections.Generic;

namespace NumericalCases.Dictionaries
{
    internal class OneDictionary : IPrimitiveDictionary
    { 
        private readonly Dictionary<Cases, string> _feminineDictionary = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "одна"},
            {Cases.Genitive, "одной"},
            {Cases.Dative, "одной"},
            {Cases.Accusative, "одну"},
            {Cases.Instrumental, "одной"},
            {Cases.Prepositional, "одной"},
        };

        private readonly Dictionary<Cases, string> _masculineDictionary = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "один"},
            {Cases.Genitive, "одного"},
            {Cases.Dative, "одному"},
            {Cases.Accusative, "один"},
            {Cases.Instrumental, "одним"},
            {Cases.Prepositional, "одном"},
        };

        private readonly Dictionary<Cases, string> _neuterDictionary = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "одно"},
            {Cases.Genitive, "одного"},
            {Cases.Dative, "одному"},
            {Cases.Accusative, "одно"},
            {Cases.Instrumental, "одним"},
            {Cases.Prepositional, "одном"},
        };

        public string GetStringTranscription(Cases caseVal, Genders genderVal)
        {
            switch (genderVal)
            {
                case Genders.Feminine:
                    return _feminineDictionary[caseVal];
                case Genders.Masculine:
                    return _masculineDictionary[caseVal];
                case Genders.Neuter:
                    return _neuterDictionary[caseVal];
                default:
                    return null;
            }
        }
    }
}