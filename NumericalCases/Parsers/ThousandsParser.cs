using System.Collections.Generic;

namespace NumericalCases.Parsers
{
    public class ThousandsParser : BasePostfixParser, INumericalParser
    {
        protected override long LowRangeVal => 1000;
        protected override long HighRangeVal => 1000000;

        protected override Genders DescriptionGender => Genders.Feminine;

        protected override Dictionary<Cases, string> LowDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "тысяча"},
            {Cases.Genitive, "тысячи"},
            {Cases.Dative, "тысяче"},
            {Cases.Accusative, "тысячу"},
            {Cases.Instrumental, "тысячей"},
            {Cases.Prepositional, "тысяче"},
        };

        protected override Dictionary<Cases, string> MiddleDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "тысячи"},
            {Cases.Genitive, "тысяч"},
            {Cases.Dative, "тысячам"},
            {Cases.Accusative, "тысячи"},
            {Cases.Instrumental, "тысячами"},
            {Cases.Prepositional, "тысячах"},
        };

        protected override Dictionary<Cases, string> HighDescription => new Dictionary<Cases, string>
        {
            {Cases.Nominative, "тысяч"},
            {Cases.Genitive, "тысяч"},
            {Cases.Dative, "тысячам"},
            {Cases.Accusative, "тысяч"},
            {Cases.Instrumental, "тысячами"},
            {Cases.Prepositional, "тысячах"},
        };

        public ThousandsParser() : this(null)
        {
        }
        public ThousandsParser(INumericalParser nextParser) : base(nextParser)
        {
        }
    }
}