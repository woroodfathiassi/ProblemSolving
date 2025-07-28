namespace ProblemSolving.Problems;

public class PrimeNumberFinder
{
    public static async Task Run(int number)
    {
        List<int> primeNumbers = await FindAllPrimesAsync(number);
        Console.WriteLine($"Prime count: {primeNumbers.Count}");
        //foreach( int i in primeNumbers ) 
        //    Console.WriteLine( i );
    }

    private static async Task<List<int>> FindAllPrimesAsync(int maxNumber)
    {
        int processorCount = Environment.ProcessorCount;
        int size = maxNumber / processorCount;

        var tasks = new List<Task<List<int>>>();

        for (int i = 0; i < processorCount; i++)
        {
            int start = i * size;
            int end = (i == processorCount - 1) ? maxNumber : start + size;

            tasks.Add(Task.Run(() => FindPrimesInRange(start, end)));
        }

        var results = await Task.WhenAll(tasks);

        return [.. results.SelectMany(x => x).OrderBy(x => x)];
    }

    private static List<int> FindPrimesInRange(int start, int end)
    {
        var primes = new List<int>();

        for (int i = Math.Max(2, start); i < end; i++)
        {
            if (IsPrime(i))
                primes.Add(i);
        }

        return primes;
    }

    private static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i=3; i < num; i++)         
            if(num % i == 0) return false;
   
        return true;
    }
}
