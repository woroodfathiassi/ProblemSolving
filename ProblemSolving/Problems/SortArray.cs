namespace ProblemSolving.Problems
{
    public class SortArray
    {
        public static void Run(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Array is null or empty.");
                return;
            }

            int[] sorted = Sort(arr);
            Console.WriteLine("Sorted Array: ");
            foreach (int num in sorted) 
                Console.Write(num+", ");
        }

        private static int[] Sort(int[] arr)
        {
            int min = 0;
            int temp;
            for(int i=0 ; i < arr.Length - 1 ; i++)
            {
                min = arr[i];
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (min  > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
