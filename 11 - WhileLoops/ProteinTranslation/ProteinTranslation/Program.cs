public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        IDictionary<string, string> proteins = new Dictionary<string, string>
        {
            { "AUG", "Methionine" },
            { "UUU", "Phenylalanine" },
            { "UUC", "Phenylalanine" },
            { "UUA", "Leucine" },
            { "UUG", "Leucine" },
            { "UCU", "Serine" },
            { "UCC", "Serine" },
            { "UCA", "Serine" },
            { "UCG", "Serine" },
            { "UAU", "Tyrosine" },
            { "UAC", "Tyrosine" },
            { "UGU", "Cysteine" },
            { "UGC", "Cysteine" },
            { "UGG", "Tryptophan" },
            { "UAA", "STOP" },
            { "UAG", "STOP" },
            { "UGA", "STOP" }
        };

        return strand
            .Select((k, v) => v)
            .Where(v => v % 3 == 0)
            .Select(v => strand.Substring(v, 3))
            .TakeWhile(k => proteins[k] != "STOP")
            .Select(k => proteins[k]).ToArray();
    }
}