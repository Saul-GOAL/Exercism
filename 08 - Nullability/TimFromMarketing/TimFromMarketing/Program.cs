using System;
using System.Text;

static class Badge
{
    public static void Main()
    {
        var result = Print(59, "Julie Sokato", null);

        Console.WriteLine(result);
        Console.ReadLine();
    }


    public static string Print(int? id, string name, string? department)
    {
        StringBuilder sb = new StringBuilder();

        if (id != null)
            sb.Append("[" + id + "] - ");

        sb.Append(name);

        if (department == null)
            sb.Append(" - OWNER");
        else
            sb.Append(" - " + department.ToUpper());

        return sb.ToString();
    }
}

