using System.Runtime.CompilerServices;

public static class LogAnalysis
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Please, enter a string: ");
        //var fullString = Console.ReadLine();
        //Console.WriteLine("\n");
        //Console.WriteLine("Please, now enter the string to look for the after: \n");
        //var linkString = Console.ReadLine();
        //Console.WriteLine("\n");

        //Console.WriteLine($"The Substring after '{linkString}' in the String '{fullString}' is: {fullString.SubstringAfter(linkString)} \n");
        //Console.ReadLine();

        //Console.WriteLine("Please, enter a string to find the string between: ");
        //var fullString2 = Console.ReadLine();
        //Console.WriteLine("\n");
        //Console.WriteLine("Please, now enter the first string as point 1: ");
        //var stringpoint1 = Console.ReadLine();
        //Console.WriteLine("\n");
        //Console.WriteLine("Please, now enter the first string as point 2: ");
        //var stringpoint2 = Console.ReadLine();
        //Console.WriteLine("\n");

        //Console.WriteLine($"The Substring between '{stringpoint1}' and '{stringpoint2}' in the String '{fullString2}' is: {fullString2.SubstringBetween(stringpoint1,stringpoint2)} \n");
        //Console.ReadLine();

        //Console.WriteLine("Please, enter a string: ");
        //var fullString3 = Console.ReadLine();
        //Console.WriteLine("\n");
        //Console.WriteLine($"The Message for the String '{fullString3}' is: {fullString3.Message()} \n");
        //Console.ReadLine();

        //Console.WriteLine("Please, enter a string: ");
        //var fullString4 = Console.ReadLine();
        //Console.WriteLine("\n");
        //Console.WriteLine($"The LogLevel for the String '{fullString4}' is: {fullString4.LogLevel()} \n");
        //Console.ReadLine();

    }

    public static string SubstringAfter(this string fullString, string stringPoint) =>
        fullString.Split(stringPoint).Last()
        ;

    public static string SubstringBetween(this string fullString, string point1, string point2) => 
        fullString.Split(point2).First().Split(point1).Last();

    public static string Message(this string fullString) =>
        fullString.SubstringAfter(": ");

    public static string LogLevel(this string fullString) =>
        fullString.SubstringBetween("[", "]");
}