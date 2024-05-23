using System;
using System.Collections.Generic;
public class Robot
{
    static HashSet<string> robotName = new();
    Random rand = new();
    public string Name
    {
        get;
        private set;
    }
    
    public Robot() => 
        Reset();
    
    public void Reset()
    {
        do
        {
            //rand.Next(65, 91) gets a Random UpperCase Letter from A to Z
            Name = $"{(char)rand.Next(65, 91)}{(char)rand.Next(65, 91)}{rand.Next(0, 10)}{rand.Next(0, 10)}{rand.Next(0, 10)}";
        } while (robotName.Contains(Name));
        
        robotName.Add(Name);
    }

}