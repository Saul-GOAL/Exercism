public class Pangram
{
    public const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static void Main()
    { 
        var phrase = "The quick brown fox jumps over the lazy dog.";

        bool isPangram = IsPangram(phrase);

    }

    public static bool IsPangram(string phrase) => alphabet.All(phrase.ToLower().Contains);

}