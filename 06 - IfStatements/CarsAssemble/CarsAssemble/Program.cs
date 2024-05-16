using System.Reflection.Metadata;

public class AssemblyLine
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please, enter the machine speed, from 0 to 10: ");
        var speed = Int32.Parse(Console.ReadLine());

        var result = AssemblyLine.SuccessRate(speed);

        Console.WriteLine($"The Success rate for a machine speed of {speed} is : {result*100}%");

        Console.WriteLine($"The Production rate per hour (221 cars per hour at 100% succes rate) is : {AssemblyLine.ProductionRatePerHour(speed)} cars per hour");

        Console.WriteLine($"The Working Items Per Minute is: {AssemblyLine.WorkingItemsPerMinute(speed)} cars per minute");
        
        Console.ReadLine();



    }

    public static double SuccessRate(int speed) => 
        speed switch
    {
        > 0 and < 5 => 1,
        > 4 and < 9 => 0.9,
        9  => 0.8,
        10 => 0.77,
        _ => 0,
    };

    public static double ProductionRatePerHour(int speed) =>
        speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) =>
        Convert.ToInt32(ProductionRatePerHour(speed)) / 60;
}