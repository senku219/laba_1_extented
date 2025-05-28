using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthTrackerApp.Models;

namespace HealthTrackerApp.Tests
{
    [TestClass]
    public class HealthManagerTestsExtended
    {
        private HealthManager _manager;

        [TestInitialize]
        public void Setup()
        {
            _manager = new HealthManager();
        }

        [TestMethod]
        public void TrackActivity_ZeroMinutes_CreatesZeroEntry()
        {
            _manager.TrackActivity("Ходьба", 0m);
            var report = _manager.GetReport();

            
            Assert.IsTrue(report.ActivityTotals.ContainsKey("Ходьба"));
            Assert.AreEqual(0m, report.ActivityTotals["Ходьба"],
                "Должна создаваться запись с нулевым временем.");
        }

        [TestMethod]
        public void TrackActivity_NegativeMinutes_CreatesNegativeEntry()
        {
            
            _manager.TrackActivity("Плавание", -15m);
            var report = _manager.GetReport();

            
            Assert.IsTrue(report.ActivityTotals.ContainsKey("Плавание"));
            Assert.AreEqual(-15m, report.ActivityTotals["Плавание"],
                "Должна сохраняться отрицательная величина без ошибок.");
        }

        [TestMethod]
        public void TrackNutrition_ZeroCalories_CreatesZeroEntry()
        {
          
            _manager.TrackNutrition("Вода", 0m);
            var report = _manager.GetReport();

            
            Assert.IsTrue(report.NutritionTotals.ContainsKey("Вода"));
            Assert.AreEqual(0m, report.NutritionTotals["Вода"]);
        }

        [TestMethod]
        public void TrackNutrition_NegativeCalories_CreatesNegativeEntry()
        {
            
            _manager.TrackNutrition("Суперфуд", -100m);
            var report = _manager.GetReport();

            
            Assert.IsTrue(report.NutritionTotals.ContainsKey("Суперфуд"));
            Assert.AreEqual(-100m, report.NutritionTotals["Суперфуд"]);
        }

        [TestMethod]
        public void TrackSleep_ZeroHours_CreatesZeroEntry()
        {
            
            var date = new DateTime(2025, 5, 5);

            
            _manager.TrackSleep(date, 0m);
            var report = _manager.GetReport();

            
            Assert.IsTrue(report.SleepTotals.ContainsKey(date.Date));
            Assert.AreEqual(0m, report.SleepTotals[date.Date]);
        }

        [TestMethod]
        public void TrackSleep_NegativeHours_CreatesNegativeEntry()
        {
            
            var date = new DateTime(2025, 5, 6);

            
            _manager.TrackSleep(date, -3m);
            var report = _manager.GetReport();

            
            Assert.IsTrue(report.SleepTotals.ContainsKey(date.Date));
            Assert.AreEqual(-3m, report.SleepTotals[date.Date]);
        }
    }
}
