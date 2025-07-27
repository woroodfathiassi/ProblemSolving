namespace ProblemSolving.Problems;

public class ReverseString
{
    public static void Run(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            Console.WriteLine("Input string is null or empty.");
            return;
        }

        string reverse = FindReverseString(str);
        Console.WriteLine($"Reverse String is: {reverse}");
    } 

    private static string FindReverseString(string str)
    {
        string temp = "";
        for (int i = str.Length - 1 ; i >= 0; i--)
        {
            temp += str[i];
        }
        return temp;
    }
}
