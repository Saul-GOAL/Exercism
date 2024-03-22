public class Darts
{
    public static void Main(string[] args)
    {
        var dartPosX = 3;
        var dartPosY = 4;

        var points = Score(dartPosX, dartPosY);
        Console.WriteLine($"Your dart goes to the ({dartPosX},{dartPosY}) so it gets {points}");
        Console.ReadLine();
    }

    public static int Score(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y);
        return distance switch
        {
            <= 1 => 10,
            <= 5 => 5,
            <= 10 => 1,
            _ => 0,
        };
    }
}