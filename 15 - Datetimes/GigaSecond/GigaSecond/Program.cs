using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime dateTime) =>
        dateTime.AddSeconds(1e9);
}