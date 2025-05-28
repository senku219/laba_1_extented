using System;
using System.Collections.Generic;

namespace HealthTrackerApp.Models
{
    public class HealthReport
    {
        public IReadOnlyDictionary<string, decimal> ActivityTotals { get; }
        public IReadOnlyDictionary<string, decimal> NutritionTotals { get; }
        public IReadOnlyDictionary<DateTime, decimal> SleepTotals { get; }

        public HealthReport(
            Dictionary<string, decimal> activityTotals,
            Dictionary<string, decimal> nutritionTotals,
            Dictionary<DateTime, decimal> sleepTotals)
        {
            ActivityTotals = new Dictionary<string, decimal>(activityTotals);
            NutritionTotals = new Dictionary<string, decimal>(nutritionTotals);
            SleepTotals = new Dictionary<DateTime, decimal>(sleepTotals);
        }
    }
}
