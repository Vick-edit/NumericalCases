using System.Collections.Generic;

namespace NumericalCases.Dictionaries
{
    internal class TwoDictionary : IPrimitiveDictionary
    {
        private readonly Dictionary<Cases, string> _feminineDictionary = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "две"},
            {Cases.Genitive, "двух"},
            {Cases.Dative, "двум"},
            {Cases.Accusative, "две"},
            {Cases.Instrumental, "двумя"},
            {Cases.Prepositional, "двух"},
        };

        private readonly Dictionary<Cases, string> _masculineDictionary = new Dictionary<Cases, string>
        {
            {Cases.Nominative, "два"},
            {Cases.Genitive, "двух"},
            {Cases.Dative, "двум"},
            {Cases.Accusative, "два"},
            {Cases.Instrumental, "двумя"},
            {Cases.Prepositional, "двух"},
        };


        public string GetStringTranscription(Cases caseVal, Genders genderVal)
        {
            switch (genderVal)
            {
                case Genders.Feminine:
                    return _feminineDictionary[caseVal];
                case Genders.Masculine:
                case Genders.Neuter:
                    return _masculineDictionary[caseVal];
                default:
                    return null;
            }
        }
    }
}