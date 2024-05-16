public static class SumOfMultiples
{
    public static void Main()
    {
        var multiples = new[] { 3, 5};

        var result = Sum(multiples, 10);

        Console.WriteLine(result);

        Console.ReadLine();
    }


    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var listaElementos = new List<int>();

        foreach (var number in multiples.Where(x => x != 0))
        {
            for (int i = number; i < max; i += number)
            {
                listaElementos.Add(i);
            }
        }
        return listaElementos.Distinct().Sum();
    }
}