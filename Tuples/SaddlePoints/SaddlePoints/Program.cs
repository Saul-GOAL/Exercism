public class SaddlePoints
{
    public static void Main(string[] args)
    {
        var matrix = new[,]
     {
             { 9, 8, 8 },
             { 5, 3, 4 },
             { 6, 6, 1 }
        };
        var actual = SaddlePoints.Calculate(matrix);

        Console.WriteLine($"The right position for the Tree House is: {actual.First()}, whith a hight of {matrix[actual.First().Item1-1, actual.First().Item2-1]}");
        Console.ReadLine();
    }

    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[i, j] - matrix[i, x])
                    .Concat(Enumerable.Range(0, matrix.GetLength(0))
                        .Select(x => matrix[x, j] - matrix[i, j]))
                    .All(x => x >= 0))
                {
                    yield return (i + 1, j + 1);
                }
            }
        }
    }
}