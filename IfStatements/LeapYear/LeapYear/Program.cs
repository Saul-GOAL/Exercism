
public class LeapYear
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a year to know if it is a Leap Year or not: ");
        var year = Int32.Parse(Console.ReadLine());

        var isLeap = IsLeapYear(year);
        Console.WriteLine("\n");
        if (isLeap)
            Console.WriteLine($"The Year {year} is a Leap year");
        else
            Console.WriteLine($"The Year {year} is Not a Leap year");

        Console.ReadLine();
    }

    public static bool IsLeapYear(int year) =>
        (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);
}