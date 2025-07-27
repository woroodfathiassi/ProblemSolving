namespace ProblemSolving.Problems
{
    public class MissingNumberInArray
    {
        public static void Run(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Array is null or empty.");
                return;
            }

            int missing = FindMissingNumber(arr);
            Console.WriteLine($"Missing Number: {missing}");
        }

        private static int FindMissingNumber(int[] arr)
        {
            int n = arr.Length + 1;
            int totalSum = n * (n + 1) / 2;
            int sum = 0;

            foreach (int i in arr)
                sum += i;
            
            return totalSum - sum;
        }
    }
}
