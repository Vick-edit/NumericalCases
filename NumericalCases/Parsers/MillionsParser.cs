using System.Collections.Generic;

namespace NumericalCases.Parsers
{
    public class MillionsParser : BasePostfixParser, INumericalParser
    {
        protected override long LowRangeVal => 1000000;
        protected override long HighRangeVal => 1000000000;

        protected override Genders DescriptionGender => Genders.Masculine;

        protected override Dictionary<Cases, string> LowDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "миллион"},
            {Cases.Genitive, "миллиона"},
            {Cases.Dative, "миллиону"},
            {Cases.Accusative, "миллион"},
            {Cases.Instrumental, "миллионом"},
            {Cases.Prepositional, "миллионе"},
        };

        protected override Dictionary<Cases, string> MiddleDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "миллиона"},
            {Cases.Genitive, "миллионов"},
            {Cases.Dative, "миллионам"},
            {Cases.Accusative, "миллиона"},
            {Cases.Instrumental, "миллионами"},
            {Cases.Prepositional, "миллионах"},
        };

        protected override Dictionary<Cases, string> HighDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "миллионов"},
            {Cases.Genitive, "миллионов"},
            {Cases.Dative, "миллионам"},
            {Cases.Accusative, "миллионов"},
            {Cases.Instrumental, "миллионами"},
            {Cases.Prepositional, "миллионах"},
        };


        public MillionsParser() : this(null)
        {
        }
        public MillionsParser(INumericalParser nextParser) : base(nextParser)
        {
        }
    }
}