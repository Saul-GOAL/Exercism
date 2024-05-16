
public class ReverseString
{
    public static void Main(string[] args)
    {

        Console.WriteLine( "Please write your word: ");
        var word = Console.ReadLine().ToString();

        var revereseString = ReverseTheString(word);

        Console.WriteLine($"You wrote: {word}");
        Console.WriteLine($"In reverse it is: {revereseString}");
        Console.ReadLine();
    }

    public static string ReverseTheString(string word)
    {
        var wordArray = word.ToCharArray();
        Array.Reverse(wordArray);
        return new string(wordArray);
    }
}