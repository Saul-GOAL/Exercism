using System.Text;

public class Acronym
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please, write your phrase here: ");
        var phrase = Console.ReadLine();

        var reponse = GetTheAcronym(phrase);

        Console.WriteLine(reponse);

        Console.ReadLine();

    }

    public static string GetTheAcronym(string phrase)
    {
        char[] separators = { ' ', '_', '-' };
        StringBuilder sb = new();

        var words = phrase.Split(separators);

        foreach (var word in words)
        {
            if (!String.IsNullOrEmpty(word))
                sb.Append(word.Substring(0,1).ToUpper());
        }

        return sb.ToString();
    }
}