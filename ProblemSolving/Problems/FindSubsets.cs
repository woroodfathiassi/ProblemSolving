namespace ProblemSolving.Problems;

public class FindSubsets
{
    public static void Run(int[] input)
    {
        if (input == null)
        {
            Console.WriteLine("Error: Input array is null.");
            return;
        }

        if (input.Length == 0)
        {
            Console.WriteLine("Error: Input array is empty.");
            return;
        }

        var result = new List<List<int>>();
        FindSubsetArrays(input, 0, [], result);

        result.Sort((a, b) => a.Count.CompareTo(b.Count));

        foreach (var subset in result)
        {
            Console.WriteLine($"[{string.Join(", ", subset)}]");
        }
    }

    private static void FindSubsetArrays(int[] nums, int index, List<int> current, List<List<int>> result)
    {
        if (index == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            // Choose
            current.Add(nums[i]);

            // Explore
            FindSubsetArrays(nums, i + 1, current, result);

            // backtrack
            current.RemoveAt(current.Count - 1);
        }
    }
}
