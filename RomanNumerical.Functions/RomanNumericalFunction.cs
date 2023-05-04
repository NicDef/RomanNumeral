namespace RomanNumerical.Functions;

public class RomanNumericalFunction
{
    public static string IntToRoman(int input)
    {
        if (input <= 0 || input >= 4000)
            throw new ArgumentException("Wert darf nicht kleiner 0 und größer als 4000 sein.", nameof(input));

        string result = string.Empty;
        int[] digitsValues = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        string[] romanNumeral = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

        while (input > 0)
        {
            for (int i = digitsValues.Count() - 1; i >= 0; i--)
            {
                if (input / digitsValues[i] >= 1)
                {
                    input -= digitsValues[i];
                    result += romanNumeral[i];
                    break;
                }
            }
        }

        return result;
    }
}