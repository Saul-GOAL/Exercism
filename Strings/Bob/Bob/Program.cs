public static class Bob
{
    //public static void Main(string[] args)
    //{
    //    var statement = "I HATE THE DENTIST";

    //    Console.WriteLine($"{Response(statement)}");
    //    Console.ReadLine();
    //}

    private static string _defaultResponse = "Whatever.";
    private static string _responseToYelling = "Whoa, chill out!";
    private static string _responseToQuestion = "Sure.";
    private static string _responseToYellingQuestion = "Calm down, I know what I'm doing!";
    private static string _responseToSilence = "Fine. Be that way!";

    public static string Response(string statement)
    {
        var statement_IsQuestion = statement.Trim().EndsWith("?");
        var statement_IsYell = statement.Any(ch => char.IsLetter(ch) && statement.ToUpperInvariant() == statement);
        var statement_IsSilent = string.IsNullOrEmpty(statement);

        if (statement_IsSilent)
            return _responseToSilence;
        if (statement_IsQuestion && statement_IsYell)
            return _responseToYellingQuestion;
        if (statement_IsQuestion)
            return _responseToQuestion;
        if (statement_IsYell)
            return _responseToYelling;
        return _defaultResponse;
    }

}