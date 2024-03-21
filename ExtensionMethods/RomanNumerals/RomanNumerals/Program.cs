using System.Runtime.CompilerServices;

public static class RomanNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please, enter the number you want to convert into Roman Numbers: ");
        var number = Convert.ToInt32(Console.ReadLine());

        var romanNumber = number.ToRoman();

        Console.WriteLine($"The roman Number of: {number} \n is: {romanNumber}");

        Console.ReadLine();
    }

    public static string ToRoman(this int number) => 
        number switch
    {
        < 0 => throw new ArgumentOutOfRangeException(nameof(number), "insert a positive value"),
        < 1 => string.Empty,
        >= 1000 => "M" + (number - 1000).ToRoman(),
        >= 900 => "CM" + (number - 900).ToRoman(),
        >= 500 => "D" + (number - 500).ToRoman(),
        >= 400 => "CD" + (number - 400).ToRoman(),
        >= 100 => "C" + (number - 100).ToRoman(),
        >= 90 => "XC" + (number - 90).ToRoman(),
        >= 50 => "L" + (number - 50).ToRoman(),
        >= 40 => "XL" + (number - 40).ToRoman(),
        >= 10 => "X" + (number - 10).ToRoman(),
        >= 9 => "IX" + (number - 9).ToRoman(),
        >= 5 => "V" + (number - 5).ToRoman(),
        >= 4 => "IV" + (number - 4).ToRoman(),
        >= 1 => "I" + (number - 1).ToRoman(),
    };

}