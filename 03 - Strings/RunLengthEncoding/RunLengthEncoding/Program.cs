
using System.Text;

public class RunLengthEncoding
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please enter the code: ");
        var code = Console.ReadLine();

        var encode = Encode(code);
        var decode = Decode(encode);

        Console.WriteLine($"Your code was: {code} \n");
        Console.WriteLine($"The code encoded is: {encode} \n");
        Console.WriteLine($"The code decoded is: {decode} \n");
        Console.ReadLine();

    }

    public static string Encode(string code)
    {
       StringBuilder sb = new();

        char lastChar = code[0];
        int count = 0;

        if ((code.Length < 0) || String.IsNullOrEmpty(code))
        {
            return sb.ToString();
        }

        foreach(char c in code)
        {
            if (c == lastChar)
            {
                count++;
            }
            else
            {
                if (count > 1)
                    sb.Append(count.ToString());
                sb.Append(lastChar);
                lastChar = c;
                count = 1;
            }
        }
        if (count > 1)
            sb.Append(count.ToString());
        sb.Append(lastChar);
        return sb.ToString();
    }

    public static string Decode(string encoded)
    {
        StringBuilder sb = new StringBuilder();

        if (encoded.Length < 1)
            return sb.ToString();

        for (int i = 0; i < encoded.Length; i++)
        {
            int count = 0;
            int digit;

            while (int.TryParse(encoded.Substring(i, 1), out digit))
            {
                count = count * 10 + digit;
                i++;
            }
            for (int c = 0; c < (count > 0 ? count : 1); c++)
            {
                sb.Append(encoded.Substring(i, 1));
            }
        }
        return sb.ToString();
    }

}