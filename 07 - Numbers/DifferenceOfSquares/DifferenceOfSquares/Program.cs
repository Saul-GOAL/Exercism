public class DifferenceOfSquares
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to select the N natural numbers");
        var n = Int32.Parse(Console.ReadLine());

        var squareSum = CalculateSquareOfSum(n);

        var sumSquares = CalculateSumOfSquares(n);

        var differenceOfSquares = CalculateDifferenceOfSquares(n);

        Console.WriteLine($"The Square of the sum of the first {n} numbers is: {squareSum}");

        Console.WriteLine($"The Sum of the Squares of the first {n} numbers is: {sumSquares}");

        Console.WriteLine($"The difference of Squares of the first {n} numbers is: {differenceOfSquares}");

        Console.ReadLine();
    }

    public static object CalculateDifferenceOfSquares(int n) =>
        CalculateSquareOfSum(n) - CalculateSumOfSquares(n);

    public static int CalculateSumOfSquares(int n) =>
        Enumerable.Range(1, n).Sum(_ => (int)Math.Pow(_, 2));

    public static int CalculateSquareOfSum(int n) =>
        (int)Math.Pow(Enumerable.Range(1, n).Sum(), 2);


}