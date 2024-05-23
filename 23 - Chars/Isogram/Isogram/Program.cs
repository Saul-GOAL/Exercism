public class Isogram
{
    public static void Main(string[] args)
    {
        var word = "lumberjacks";

        var isIsogram = IsIsogram(word);

        Console.WriteLine(isIsogram);
        Console.ReadLine();
    }

    public static bool IsIsogram(string word)
    {
        var lowerLetters = word.ToLower().Where(char.IsLetter).ToList();

        return lowerLetters.Distinct().Count() == lowerLetters.Count();
    }
}