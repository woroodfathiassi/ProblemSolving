namespace ProblemSolving.Problems;

public class BinarySearchRecursive
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

        int low = 0;
        int high = arr.Length - 1;

        int index = FindIndex(arr, low, high, n);
        if (index < 0)
        {
            Console.WriteLine("Not found!");
            return;
        }

        Console.WriteLine($"{n} found at index: {index}");
    }

    private static int FindIndex(int[] arr, int low, int high, int n)
    {
        if (low > high) return -1;

        int mid = (low + high) / 2;
        
        if (arr[mid] == n) return mid;
        if (arr[mid] < n) return FindIndex(arr, mid + 1, high, n);
        else return FindIndex(arr, low, mid - 1, n);
    }
}
