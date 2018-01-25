using System.Text;

namespace NumericalCases.Parsers
{
    /// <summary> Абстрактный класс, содержащий базовый алгоритм парсинга </summary>
    public abstract class BaseNumericalParser : INumericalParser
    {
        protected abstract long LowRangeVal { get; }
        protected abstract long HighRangeVal { get; }
        private readonly INumericalParser _nextParser;

        protected BaseNumericalParser(INumericalParser nextParser)
        {
            _nextParser = nextParser;
        }

        public string ParseNumber(long number, Cases caseVal, Genders genderVal)
        {
            return ParseNumber(number, null, caseVal, genderVal);
        }

        public string ParseNumber(long number, string postfix, Cases caseVal, Genders genderVal)
        {
            var resultText = "";
            var parsingValue = GetRangeForParsing(number);
            if (LowRangeVal <= parsingValue && parsingValue < HighRangeVal)
            {
                resultText = GetTextForRange(parsingValue, caseVal, genderVal);
            }
            resultText = ConcatTwoResult(resultText, postfix);

            if (_nextParser == null)
                return resultText;
            else
                return _nextParser.ParseNumber(number, resultText, caseVal, genderVal);
        }

        protected string ConcatTwoResult(string firstElement, string secondElement)
        {
            return $"{firstElement} {secondElement}".Trim();
        }

        protected abstract long GetRangeForParsing(long number);

        protected abstract string GetTextForRange(long number, Cases caseVal, Genders genderVal);
    }
}