namespace ProblemSolving.Problems;

public class FirstNonRepeatedChar
{
    public static void Run(String str)
    {
        if (string.IsNullOrEmpty(str))
        {
            Console.WriteLine("Input string is null or empty.");
            return;
        }

        char? result = FindNonRepeatedChar(str);

        if (result.HasValue)
            Console.WriteLine($"First non-repeated character: {result.Value}");
        else
            Console.WriteLine("No non-repeated character found.");
    }

    private static char? FindNonRepeatedChar(string str)
    {
        Dictionary<char, int> dict = [];

        foreach (char c in str)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }

        foreach (char c in str)
        {
            if (dict[c] == 1)
                return c;
        }

        return null;
    }
}
