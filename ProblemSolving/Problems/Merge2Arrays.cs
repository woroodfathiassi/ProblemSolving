namespace ProblemSolving.Problems
{
    public class Merge2Arrays
    {
        public static void Run(int[] arr1, int[] arr2)
        {
            int[] sorted = SortTwoArrays(arr1, arr2);
            Console.WriteLine("Merged and sorted array:");
            foreach (int i in sorted) 
                Console.WriteLine(i);
        }

        private static int[] SortTwoArrays(int[] arr1, int[] arr2)
        {
            int size1 = arr1.Length;
            int size2 = arr2.Length;
            int i=0, j=0, k=0;

            if (arr1 == null || size1 == 0) return arr2;
            
            if (arr2 == null || size2 == 0) return arr1;

            int[] ints = new int[size1 + size2];

            while ( i< size1 &&  j< size2)
            {
                if (arr1[i] > arr2[j])
                {
                    ints[k++] = arr2[j++];
                }
                else
                {
                    ints[k++] = arr1[i++];
                }
            }

            while(i < size1)
            {
                ints[k++] = arr1[i++];
            }

            while (j < size2)
            {
                ints[k++] = arr2[j++];
            }

            return ints;
        }
    }
}
