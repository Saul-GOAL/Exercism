using System;
public class Player
{
    Random getrandom = new Random();

    public int RollDie() =>
        getrandom.Next(1, 19);
    public double GenerateSpellStrength() =>
        getrandom.NextDouble() * 100;
}
