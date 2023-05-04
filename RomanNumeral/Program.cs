using RomanNumerical.Functions;

namespace RomanNumeral;

internal class Program
{
    static void Main(string[] args)
    {
        int input;

        Console.WriteLine("Herzlich Willkommen! Mit diesem Programm können Sie arabische Zahlen in römische Zahlen umwandeln.");
        Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 3999 ein: ");

        do
        {
            string? line = Console.ReadLine();
            bool isNumber = Int32.TryParse(line, out input);
            if (isNumber && input > 0 && input < 4000)
                break;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 3999 ein: ");
        } while (true);

        Console.Clear();
        Console.WriteLine($"Die römische Zahl von {input} ist {RomanNumericalFunction.IntToRoman(input)}");
    }


}