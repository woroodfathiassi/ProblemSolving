namespace ProblemSolving.Problems;

public class BinarySearchIterative
{
    public static void Run(int[] arr, int n)
    {
        if (arr == null)
        {
            Console.WriteLine("Error: Input array is null.");
            return;
        }

        if (arr.Length == 0)
        {
            Console.WriteLine("Error: Input array is empty.");
            return;
        }

        int index = FindIndex(arr, n);
        if(index < 0)
        {
            Console.WriteLine("Not found!");
            return;
        }

        Console.WriteLine($"{n} found at index: {index}");
    }

    private static int FindIndex(int[] arr, int n)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == n) return mid;
            if (arr[mid] < n) low = mid + 1;
            else high = mid - 1;
        }

        return -1;
    }
}
