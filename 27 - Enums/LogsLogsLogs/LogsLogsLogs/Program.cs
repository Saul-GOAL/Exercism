using System;
using System.Text.RegularExpressions;

internal enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
}

static class LogLine
{
    private static readonly string pattern = @"\[(?<logLevel>[A-Z]+)\]";

    public static LogLevel ParseLogLevel(string logLine) =>
        Regex.Match(logLine, pattern).Groups["logLevel"].Value
        switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown,
        };

    public static string OutputForShortLog(LogLevel logLevel, string message) =>
        $"{logLevel.GetHashCode()}:{message}";
}