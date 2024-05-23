using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) =>
         shirtNum switch
         {
             1 => "goalie",
             2 => "left back",
             3 or 4 => "center back",
             5 => "right back",
             6 or 7 or 8 => "midfielder",
             9 => "left wing",
             10 => "striker",
             11 => "right wing",
             _ => throw new ArgumentOutOfRangeException($"Camiseta desconocida")
         };


    public static string AnalyzeOffField(object report) =>
        report switch
        {
            int i => $"There are {i} supporters at the match.",
            string s => s,
            Injury injury => 
                $"Oh no! {injury.GetDescription()} Medics are on the field.",
            Incident incident => 
                incident.GetDescription(),
            Manager manager => 
                string.IsNullOrEmpty(manager.Name) ? "the manager" : manager.Name + (string.IsNullOrEmpty(manager.Club) ? "" : $" ({manager.Club})"),
            _ => throw new ArgumentException()
        };
}
