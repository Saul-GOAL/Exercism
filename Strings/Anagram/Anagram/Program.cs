
using System.Runtime.CompilerServices;

public class Anagram
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please, write here your Base Word: ");
        var baseWord = Console.ReadLine().ToString();
        
        var anagram = new Anagram(baseWord);

        var candidates = new[] { "lemons", "cherry", "melons" };

        var response = anagram.FindAnagrams(candidates);

        foreach ( var candidate in response )
        {
            Console.WriteLine(candidate);
        }
        Console.ReadLine();
    }

    private readonly string _baseWord;
    private readonly string _baseWordOrdered;

    public Anagram(string baseWord)
    {
        _baseWord = baseWord.ToLower();
        _baseWordOrdered = string.Concat(_baseWord.Order());
    }

    public string[] FindAnagrams(string[] potentialMatches) =>
        potentialMatches.Where(x => isAnagram(x.ToLower())).ToArray();

    public bool isAnagram(string word)
    {
        if ((word.Length != _baseWord.Length) || (word == _baseWord))
        {
            return false;
        }

        word = string.Concat(word.Order());

        return word == _baseWordOrdered;
    }

}