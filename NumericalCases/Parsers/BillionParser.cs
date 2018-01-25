using System.Collections.Generic;

namespace NumericalCases.Parsers
{
    public class BillionParser : BasePostfixParser, INumericalParser
    {
        protected override long LowRangeVal => 1000000000;
        protected override long HighRangeVal => 1000000000000;

        protected override Genders DescriptionGender => Genders.Masculine;

        protected override Dictionary<Cases, string> LowDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "миллиард"},
            {Cases.Genitive, "миллиарда"},
            {Cases.Dative, "миллиарду"},
            {Cases.Accusative, "миллиард"},
            {Cases.Instrumental, "миллиардом"},
            {Cases.Prepositional, "миллиарде"},
        };

        protected override Dictionary<Cases, string> MiddleDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "миллиарда"},
            {Cases.Genitive, "миллиардов"},
            {Cases.Dative, "миллиардам"},
            {Cases.Accusative, "миллиарда"},
            {Cases.Instrumental, "миллиардами"},
            {Cases.Prepositional, "миллиардах"},
        };

        protected override Dictionary<Cases, string> HighDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "миллиардов"},
            {Cases.Genitive, "миллиардов"},
            {Cases.Dative, "миллиардам"},
            {Cases.Accusative, "миллиардов"},
            {Cases.Instrumental, "миллиардами"},
            {Cases.Prepositional, "миллиардах"},
        };


        public BillionParser() : base(null)
        {
        }
        public BillionParser(INumericalParser nextParser) : base(nextParser)
        {
        }
    }
}