// Models/ActivityRecord.cs
namespace HealthTrackerApp.Models
{
    public class ActivityRecord
    {
        public string Type { get; }
        public decimal Minutes { get; }

        public ActivityRecord(string type, decimal minutes)
        {
            Type = type;
            Minutes = minutes;
        }
    }
}