using System;
using System.Collections.Generic;

namespace HealthTrackerApp.Models
{
    public class HealthManager
    {
        private readonly Dictionary<string, decimal> _activities = new Dictionary<string, decimal>();
        private readonly Dictionary<string, decimal> _meals = new Dictionary<string, decimal>();
        private readonly Dictionary<DateTime, decimal> _sleeps = new Dictionary<DateTime, decimal>();

        public void TrackActivity(string type, decimal minutes)
        {
            if (_activities.ContainsKey(type))
                _activities[type] += minutes;
            else
                _activities[type] = minutes;
        }

        public void TrackNutrition(string food, decimal calories)
        {
            if (_meals.ContainsKey(food))
                _meals[food] += calories;
            else
                _meals[food] = calories;
        }

        public void TrackSleep(DateTime date, decimal hours)
        {
            _sleeps[date.Date] = hours;
        }

        public HealthReport GetReport()
        {
            return new HealthReport(
                new Dictionary<string, decimal>(_activities),
                new Dictionary<string, decimal>(_meals),
                new Dictionary<DateTime, decimal>(_sleeps)
            );
        }
    }
}
