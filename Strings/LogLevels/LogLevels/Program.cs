static class LogLine
{

    public static void Main(string[] args)
    {
        string message = "[WARNING]: Disk almost full";
        Console.WriteLine($"El mensaje es {Message(message)}");

        Console.WriteLine($"El LogLevel es {LogLevel(message)}");

        Console.WriteLine($"El mensaje original era {message}");
        Console.WriteLine($"El mensaje reformateado es {Reformat(message)}");

        Console.ReadLine();
    }

    public static string Message(string logLine) =>
        logLine[(logLine.IndexOf(':') + 1)..].Trim();

    public static string LogLevel(string logLine) =>
        logLine[1..logLine.IndexOf(']')].ToLower();

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
