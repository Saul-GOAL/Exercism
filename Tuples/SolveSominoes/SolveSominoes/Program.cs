

public class SolveDominoes
{
    public static void Main(string[] args)
    {
        var dominoes = new[] { (1, 2), (1, 3), (4, 3) };

        var result = CanChain(dominoes);

        if (result)
            Console.WriteLine("Domino pieces can be chained together");
        else
            Console.WriteLine("Domino pieces cannot be chained together");

        Console.ReadLine();
    }

    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (!dominoes.Any())
            return true;

        var chain = Connect(dominoes).ToArray();
        return chain.Length <= 1 && chain[0].Item1 == chain[0].Item2;
    }

    public static IEnumerable<(int, int)> Connect(IEnumerable<(int, int)> dominoes)
    {
        if (dominoes.Count() == 1)
            return dominoes;

        var chain = dominoes;

        var matches = dominoes.Skip(1).Where(x => x.Item1 == dominoes.First().Item2 ||
        x.Item2 == dominoes.First().Item2);

        foreach (var match in matches)
        {
            var links = dominoes.Skip(1).ToList();
            links.Remove(match);

            var head = (dominoes.First().Item1, dominoes.First().Item2 == match.Item1 ? match.Item2 : match.Item1);
            chain = Connect(links.Prepend(head));
            if (chain.Count() == 1) return chain;
        }
        return chain;
    }
}