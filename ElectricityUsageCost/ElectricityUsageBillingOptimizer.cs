namespace ElectricityUsageCost;

public class ElectricityUsageBillingOptimizer
{
    private const double PeakRate = 0.20;
    private const double OffPeakRate = 0.10;

    private static readonly TimeSpan PeakStart = TimeSpan.FromHours(6);
    private static readonly TimeSpan PeakEnd = TimeSpan.FromHours(22);

    public static void Run(List<Record> records)
    {
        Console.WriteLine($"Total Cost: ${FindCost(records):F2}");
    }

    private static double FindCost(List<Record> records)
    {
        double total = 0;

        foreach(Record record in records)
        {
            double cost = CalculatePeakHours(record.StartTime, record.EndTime, record.Rate);

            total += cost;
        }

        return total;
    }

    private static double CalculatePeakHours(DateTime start, DateTime end, double powerKW)
    {
        double total = 0;
        DateTime current = start;

        while(current < end)
        {
            TimeSpan timeOfDay = current.TimeOfDay; 
            Console.WriteLine(timeOfDay);
            DateTime next;

            bool isPeak = timeOfDay >= PeakStart && timeOfDay < PeakEnd;

            if (isPeak)
            {
                DateTime segmentEnd = new DateTime(current.Year, current.Month, current.Day, 22, 0, 0);
                next = end < segmentEnd ? end : segmentEnd;
                Console.WriteLine("isPeak: "+ end + " : " + segmentEnd);

                double hours = (next - current).TotalHours;
                total += hours * powerKW * PeakRate;
            }
            else
            {
                DateTime segmentEnd = timeOfDay < PeakStart
                    ? new DateTime(current.Year, current.Month, current.Day, 6, 0, 0)
                        : new DateTime(current.Year, current.Month, current.Day + 1, 6, 0, 0);

                next = end < segmentEnd ? end : segmentEnd;
                Console.WriteLine("isNotPeak: " + end+" : "+segmentEnd);
                double hours = (next - current).TotalHours;
                total += hours * powerKW * OffPeakRate;
            }

            current = next;
        }

        return total;
    }
}
