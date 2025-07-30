using ElectricityUsageCost;

var records = new List<Record>
{
    new (
        DateTime.Parse("2025-07-29 21:30"),
        DateTime.Parse("2025-07-29 22:30"),
        2.0
    ),
    //new (
    //    DateTime.Parse("2025-07-29 21:30"),
    //    DateTime.Parse("2025-07-29 22:30"),
    //    2.0
    //)
};

ElectricityUsageBillingOptimizer.Run(records);