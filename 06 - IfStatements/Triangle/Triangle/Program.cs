public class Triangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first side of the triangle: ");
        var side1 = Double.Parse(Console.ReadLine());
        Console.WriteLine(" Please enter the second side of the triangle: ");
        var side2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third side of the triangle: ");
        var side3 = Double.Parse(Console.ReadLine());

        Console.WriteLine("\n Now we are going to check what kind of triangle it is your triangle. \n");

        if (IsATriangle(side1, side2, side3))
        {
            if (IsScalene(side1, side2, side3))
                Console.WriteLine($"Your sides ({side1},{side2},{side3}) make a Scalene Triangle");
            if (IsIsosceles(side1, side2, side3))
                Console.WriteLine($"Your sides ({side1},{side2},{side3}) make an Isosceles Triangle");
            if (IsEquilateral(side1, side2, side3))
                Console.WriteLine($"Your sides ({side1},{side2},{side3}) make an Equilateal Triangle");
        }
        else
        {
            Console.WriteLine($"Your sides ({side1},{side2},{side3}) dont make a Triangle");
        }
      
        Console.ReadLine();

    }

    public static bool IsEquilateral(double side1, double side2, double side3) =>
        IsATriangle(side1, side2, side3) 
        ? (side1 == side2) && (side2 == side3) && (side1 == side3) 
        : false;

    public static bool IsIsosceles(double side1, double side2, double side3) =>
        IsATriangle(side1, side2, side3)
        ? (side1 == side2) || (side1 == side3) || (side2 == side3)
        : false;

    public static bool IsScalene(double side1, double side2, double side3) =>
        IsATriangle(side1, side2, side3) 
        ? (side1 != side2) && (side1 != side3) && (side2 != side3) 
        : false;

    public static bool IsATriangle(double side1, double side2, double side3) => 
        side1 > 0 && side2 > 0 && side3 > 0 
        ? (side1 + side2 >= side3) && (side2 + side3 >= side1) && (side3 + side1 >= side2)
        : false;
}