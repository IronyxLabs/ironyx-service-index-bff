namespace Ironyx.ServiceIndex.BFF.Application.Models
{
    public class Overview
    {
        public int ServiceCount { get; init; }
        public int HealthyCount { get; init; }
        public int DegradedCount { get; init; }
        public int UnhealthyCount { get; init; }
    }
}
