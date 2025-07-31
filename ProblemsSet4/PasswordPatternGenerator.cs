namespace ProblemsSet4;

public class PasswordPatternGenerator
{
    private static readonly char[] Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    private static readonly char[] Lowercase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    private static readonly char[] Digits = "0123456789".ToCharArray();
    private static readonly char[] Symbols = "!@#$%^&*()".ToCharArray();

    public static void GeneratePasswords(string pattern)
    {
        var results = new List<string>();
        Generate("sA#d", 0, "", results);
        Console.WriteLine($"\n\nGenerated {results.Count} passwords:");
        //foreach (var str in results)
        //{
        //    Console.WriteLine(str);
        //}
    }

    public static void Generate(string pattern, int index, string current, List<string> result)
    {
        if(index == pattern.Length )
        {
            result.Add(current);
            return;
        }

        char[] choices;
        char ch = pattern[index];

        if (ch == 'A') choices = Uppercase;
        else if (ch == 'a') choices = Lowercase;
        else if (ch == '#') choices = Digits;
        else if (ch == '*') choices = Symbols;
        else
        {
            Generate(pattern, index + 1, current + ch, result);
            return;
        }

        foreach (char c in choices)
        {
            Generate(pattern, index + 1, current + c, result);
        }
    }
}
