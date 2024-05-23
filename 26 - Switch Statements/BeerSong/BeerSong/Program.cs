using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder result = new();
        var bottles = startBottles;

        while (bottles > 0 && takeDown > 0)
        {
            result.AppendLine(bottles > 1
                ? $"{bottles} bottles of beer on the wall, {bottles} bottles of beer."
                : $"{bottles} bottle of beer on the wall, {bottles} bottle of beer.");
            bottles--;

            switch (bottles)
            {
                case > 1:
                    result.AppendLine($"Take one down and pass it around, {bottles} bottles of beer on the wall.");
                    break;
                case 1:
                    result.AppendLine($"Take one down and pass it around, {bottles} bottle of beer on the wall.");
                    break;
                default:
                    result.AppendLine("Take it down and pass it around, no more bottles of beer on the wall.");
                    break;
            }
            takeDown--;

            if (bottles > 0 && takeDown > 0)
            {
                result.AppendLine();
            }
        }

        if (bottles == 0 && takeDown > 0)
        {
            if (result.Length > 0)
            {
                result.AppendLine();
            }
            result.AppendLine("No more bottles of beer on the wall, no more bottles of beer.");
            result.AppendLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
        }

        result.Remove(result.Length - 1, 1);

        return result.ToString();
    }
}