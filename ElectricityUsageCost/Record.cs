namespace ElectricityUsageCost;

public class Record
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public double Rate { get; set; }

    public Record(DateTime start, DateTime end, double rate)
    {
        StartTime = start;
        EndTime = end;
        Rate = rate;
    }
}
