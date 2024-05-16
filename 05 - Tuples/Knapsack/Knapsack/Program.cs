using System;
public static class Knapsack
{
    public static int MaximumValue(int maxWeight, (int weight, int value)[] items)
    {
        var dp = new int[maxWeight + 1];

        foreach (var (weight, value) in items)
            for (var i = maxWeight; i >= weight; i--)
                dp[i] = Math.Max(dp[i], dp[i - weight] + value);
        return dp[maxWeight];
    }
}