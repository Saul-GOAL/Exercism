using System;

public static class ResistorColorDuo
{
    private static readonly string[] resistorColors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int Value(string[] colors) => colors.Length switch
    {
        < 2 => Array.IndexOf(resistorColors, colors[0]),
        >= 2 => Array.IndexOf(resistorColors, colors[0]) * 10 + Array.IndexOf(resistorColors, colors[1]),
        //_ => 0
    };
}
