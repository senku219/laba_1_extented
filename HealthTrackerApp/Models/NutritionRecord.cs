// Models/NutritionRecord.cs
namespace HealthTrackerApp.Models
{
    public class NutritionRecord
    {
        public string Food { get; }
        public decimal Calories { get; }

        public NutritionRecord(string food, decimal calories)
        {
            Food = food;
            Calories = calories;
        }
    }
}