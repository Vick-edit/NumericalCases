using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumericalCases.Dictionaries;

namespace NumericalCases.Parsers
{
    /// <summary> Класс, переводящий числа от 1 до 999 в текст </summary>
    public class BelowThousandParser : BaseNumericalParser, INumericalParser
    {
        protected override long LowRangeVal => 1;
        protected override long HighRangeVal => 1000;

        private readonly IDictionary _digitsDictionary;
        private readonly IDictionary _belowTwentyDictionary;
        private readonly IDictionary _dozensDictionary;
        private readonly IDictionary _hundredsDictionary;


        public BelowThousandParser() : this(null)
        {
        }

        public BelowThousandParser(INumericalParser nextParser) : base(nextParser)
        {
            _digitsDictionary = new BelowTen();
            _belowTwentyDictionary = new BelowTwenty();
            _dozensDictionary = new Dozens();
            _hundredsDictionary = new Hundreds();
        }


        protected override long GetRangeForParsing(long number)
        {
            return number % 1000;
        }

        protected override string GetTextForRange(long number, Cases caseVal, Genders genderVal)
        {
            var textElements = new List<string>();
            var numByDigits = number.ToString().ToCharArray().Reverse().ToArray();

            //парсим единицы
            if (numByDigits.Length < 2 || numByDigits[1] != '1')
            {
                var digitAsText = _digitsDictionary.GetStringTranscription(numByDigits[0], caseVal, genderVal);
                textElements.Add(digitAsText);
            }

            //парсим числа от 10 до 19
            if (numByDigits.Length > 1 && numByDigits[1] == '1')
            {
                var digitAsText = _belowTwentyDictionary.GetStringTranscription(numByDigits[0], caseVal, genderVal);
                textElements.Add(digitAsText);
            }

            //парсим десятки
            if (numByDigits.Length > 1 && numByDigits[1] != '1')
            {
                var digitAsText = _dozensDictionary.GetStringTranscription(numByDigits[1], caseVal, genderVal);
                textElements.Add(digitAsText);
            }

            //парсим сотни
            if (numByDigits.Length > 2 && numByDigits[2] != '0')
            {
                var digitAsText = _hundredsDictionary.GetStringTranscription(numByDigits[2], caseVal, genderVal);
                textElements.Add(digitAsText);
            }

            //объединяем текст
            textElements.Reverse();
            var resultNumericalText = new StringBuilder();
            foreach (var textElement in textElements)
            {
                if (string.IsNullOrEmpty(textElement))
                    continue;

                resultNumericalText.Append(textElement);
                resultNumericalText.Append(" ");
            }

            return resultNumericalText.ToString().Trim();
        }
    }
}