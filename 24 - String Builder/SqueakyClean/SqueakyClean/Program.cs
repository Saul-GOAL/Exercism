using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (!string.IsNullOrWhiteSpace(identifier))
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < identifier.Length; i++)
            {
                if (char.IsWhiteSpace(identifier[i]))
                {
                    sb.Append('_');
                    continue;
                }
                else if (char.IsControl(identifier[i]))
                {
                    sb.Append("CTRL");
                    continue;
                }
                else if (identifier[i] == '-')
                {
                    if (i + 1 != identifier.Length)
                    {
                        ++i;
                        sb.Append(char.ToUpper(identifier[i]));
                    }
                    continue;
                }
                else if (identifier[i] is >= 'α' and <= 'ω')
                {
                    continue;
                }
                if (char.IsLetter(identifier[i]))
                {
                    sb.Append(identifier[i]);
                }
            }
            return sb.ToString();
        }

        return string.Empty;
    }
}