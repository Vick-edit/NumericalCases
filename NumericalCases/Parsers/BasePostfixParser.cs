using System.Collections.Generic;

namespace NumericalCases.Parsers
{
    public abstract class BasePostfixParser : BaseNumericalParser, INumericalParser
    {
        protected abstract Genders DescriptionGender { get; }

        protected abstract Dictionary<Cases, string> LowDescription { get; }
        protected abstract Dictionary<Cases, string> MiddleDescription { get; }
        protected abstract Dictionary<Cases, string> HighDescription { get; }


        private readonly INumericalParser _belowThousandParser;


        protected BasePostfixParser(INumericalParser nextParser) : base(nextParser)
        {
            _belowThousandParser = new BelowThousandParser();
        }


        protected override long GetRangeForParsing(long number)
        {
            return number % HighRangeVal;
        }

        protected override string GetTextForRange(long number, Cases caseVal, Genders genderVal)
        {
            var numberOfUnits = number / LowRangeVal;
            var numberAsText = _belowThousandParser.ParseNumber(numberOfUnits, caseVal, DescriptionGender);

            string descriptionText;
            if (numberOfUnits % 10 == 1 && numberOfUnits % 100 != 11)
                descriptionText = LowDescription[caseVal];
            else if ((numberOfUnits % 10 >= 2 && numberOfUnits % 10 <= 4)
                     && (numberOfUnits % 100 > 20 || numberOfUnits % 100 < 10))
                descriptionText = MiddleDescription[caseVal];
            else
                descriptionText = HighDescription[caseVal];

            return ConcatTwoResult(numberAsText, descriptionText);
        }
    }
}