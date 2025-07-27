namespace ProblemSolving.Problems;

public class HasOnlyDigits
{
    public static void Run(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            Console.WriteLine("Input string is null or empty.");
            return;
        }

        bool hasOnlyDigits = CheckIfHasOnlyDigits(str);
        Console.WriteLine(hasOnlyDigits
            ? $"The '{str}' contains only digits."
            : $"The '{str}' contains non-digit characters.");
    }

    private static bool CheckIfHasOnlyDigits(string str)
    {
        return str.All(char.IsDigit);
    }
}
