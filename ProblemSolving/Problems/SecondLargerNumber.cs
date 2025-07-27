namespace ProblemSolving.Problems
{
    public class SecondLargerNumber
    {
        public static void Run(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                Console.WriteLine("Array must contain at least two elements.");
                return;
            }

            var result = FindSecondLargest(nums);

            if (result.HasValue)
                Console.WriteLine($"Second Largest Number: {result.Value}");
            else
                Console.WriteLine("No distinct second largest number found.");
        }

        private static int? FindSecondLargest(int[] arr)
        {
            int? largest = null;
            int? secondLargest = null;

            foreach (var num in arr)
            {
                if (largest == null || num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num < largest && (secondLargest == null || num > secondLargest))
                {
                    secondLargest = num;
                }
            }

            return secondLargest;
        }
    }
}