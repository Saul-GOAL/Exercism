using System;
public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var proverbs = new string[subjects.Length];
        
        if (proverbs.Length == 0)
            return proverbs;
        
        proverbs[subjects.Length - 1] = "And all for the want of a " + subjects[0] + ".";
        
        if (proverbs.Length == 1)
            return proverbs;

        for (int i = 0; i < subjects.Length - 1; i++)
        {
            proverbs[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
        }
        
        return proverbs;
    }
}