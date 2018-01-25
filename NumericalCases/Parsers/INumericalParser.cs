namespace NumericalCases.Parsers
{
    /// <summary> Интерфейс парсинга значения числа </summary>
    public interface INumericalParser
    {
        /// <summary> Распарсить число в текстовое представление </summary>
        /// <param name="number"> Число для парсинга </param>
        /// <param name="caseVal"> Падеж </param>
        /// <param name="genderVal"> Род </param>
        /// <returns> Число пропесью в заданом падеже и роде </returns>
        string ParseNumber(long number, Cases caseVal, Genders genderVal);

        /// <summary> Распарсить число в текстовое представление </summary>
        /// <param name="number"> Число для парсинга </param>
        /// <param name="postfix"> Постфикс, добавляемый к результату парсинга </param>
        /// <param name="caseVal"> Падеж </param>
        /// <param name="genderVal"> Род </param>
        /// <returns> Число пропесью в заданом падеже и роде </returns>
        string ParseNumber(long number, string postfix, Cases caseVal, Genders genderVal);
    }
}