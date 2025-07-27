namespace ProblemSolving.Problems
{
    public class MaxValue
    {
        public static void Run(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Array is null or empty.");
                return;
            }

            int max = FindMaxNumber(arr);
            Console.WriteLine($"\nMax Number: {max}");
        }

        private static int FindMaxNumber(int[] arr)
        {
            int largest = int.MinValue;

            foreach (var num in arr)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }
    }
}