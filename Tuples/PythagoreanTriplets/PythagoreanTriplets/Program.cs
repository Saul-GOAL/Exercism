using System;
using System.Linq;
public class PythagoreanTriplet
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please, introduce the limit value: ");
        var sum = Int32.Parse(Console.ReadLine());

        var triplets = TripletsWithSum(sum);

        foreach (var triplet in triplets)
        {
            Console.WriteLine(triplet);
        }

        Console.ReadLine();
    }
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        // if a reaches sum/3, then there is not point to continue
        // as b > a and c > b, so we overcome the sum
        for (int a = 1; a < sum / 3; a++)
        {
            for (int b = a + 1; b < sum / 2; b++)
            {
                // c is fully determined by the
                // condition we want it to apply
                var c = sum - a - b;
                // simply check the pythagorean relation
                if ((a * a) + b * b == c * c)
                    yield return (a, b, c);
            }
        }
    }
}