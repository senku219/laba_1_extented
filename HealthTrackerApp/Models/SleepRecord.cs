// Models/SleepRecord.cs
using System;

namespace HealthTrackerApp.Models
{
    public class SleepRecord
    {
        public DateTime Date { get; }
        public decimal Hours { get; }

        public SleepRecord(DateTime date, decimal hours)
        {
            Date = date;
            Hours = hours;
        }
    }
}