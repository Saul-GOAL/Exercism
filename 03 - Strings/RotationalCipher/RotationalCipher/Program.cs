using System.Text;

public static class RotationalCipher
{
    public static void Main(string[] args)
    {
        string text = "The quick brown fox jumps over the lazy dog.";
        int shiftkey = 13;
        string encrypted = Rotate(text, shiftkey);

        Console.WriteLine($"The original message is: {text} \n");

        Console.WriteLine($"The encrypted message is: {encrypted} \n");

        Console.WriteLine($"The decrypted message is: {Rotate(encrypted, shiftkey)} \n");

        Console.ReadLine();
    }

    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in text)
        {
            sb.Append(Cipher(c, shiftKey));
        }
        
        return sb.ToString();
    }

    public static char Cipher(char ch, int shiftKey)
    {
        if (char.IsLetter(ch))
        {
            var d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)(((ch + shiftKey - d) % 26) + d);
        }

        return ch;
    }
}