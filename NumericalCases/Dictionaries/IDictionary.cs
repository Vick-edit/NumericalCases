namespace NumericalCases.Dictionaries
{
    public interface IDictionary
    {
        string GetStringTranscription(char digit, Cases caseVal, Genders genderVal);
    }
}