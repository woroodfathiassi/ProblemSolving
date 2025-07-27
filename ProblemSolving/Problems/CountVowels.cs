namespace ProblemSolving.Problems
{
    public class CountVowels
    {
        public static void Run(String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Input string is null or empty.");
                return;
            }

            int count = FindCountVowels(str);
            Console.WriteLine($"Vowel Count: {count}");
        }

        private static int FindCountVowels(String str)
        {
            int count = 0;

            for(int i=0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                    count++;
            }
            return count;
        }

        private static bool IsVowel(char s)
        {
            char ch = char.ToUpper(s);
            return (
                    ch == 'A' || ch == 'E' ||
                    ch == 'I' || ch == 'O' ||
                    ch == 'U');
        }
    }
}
