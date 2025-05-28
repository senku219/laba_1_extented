using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthTrackerApp.Models;

namespace HealthTrackerApp.Tests
{
    [TestClass]
    public class HealthManagerTests
    {
        private HealthManager _manager;

        [TestInitialize]
        public void Setup()
        {
            // Перед каждым тестом создаём свежий экземпляр менеджера
            _manager = new HealthManager();
        }

        [TestMethod]
        public void TrackActivity_NewType_CreatesEntry()
        {
            // Arrange
            string type = "Бег";
            decimal minutes = 30m;

            // Act
            _manager.TrackActivity(type, minutes);
            var report = _manager.GetReport();

            // Assert: в отчёте должна быть одна запись "Бег" со значением 30
            Assert.IsTrue(report.ActivityTotals.ContainsKey(type),
                "Ожидалось, что тип активности появится в словаре.");
            Assert.AreEqual(minutes, report.ActivityTotals[type],
                "Количество минут должно соответствовать переданному.");
        }

        [TestMethod]
        public void TrackActivity_SameType_TotalsAdded()
        {
            // Arrange
            string type = "Велосипед";
            _manager.TrackActivity(type, 20m);
            _manager.TrackActivity(type, 15m);

            // Act
            var report = _manager.GetReport();

            // Assert: минуты сложились
            Assert.AreEqual(35m, report.ActivityTotals[type],
                "При добавлении одной и той же активности минуты должны накапливаться.");
        }

        [TestMethod]
        public void TrackNutrition_NewFood_CreatesEntry()
        {
            // Arrange
            string food = "Яблоко";
            decimal calories = 52m;

            // Act
            _manager.TrackNutrition(food, calories);
            var report = _manager.GetReport();

            // Assert
            Assert.IsTrue(report.NutritionTotals.ContainsKey(food));
            Assert.AreEqual(calories, report.NutritionTotals[food]);
        }

        [TestMethod]
        public void TrackNutrition_SameFood_TotalsAdded()
        {
            // Arrange & Act
            _manager.TrackNutrition("Хлеб", 80m);
            _manager.TrackNutrition("Хлеб", 70m);
            var report = _manager.GetReport();

            // Assert
            Assert.AreEqual(150m, report.NutritionTotals["Хлеб"]);
        }

        [TestMethod]
        public void TrackSleep_DifferentDates_CreatesSeparateEntries()
        {
            // Arrange & Act
            var date1 = new DateTime(2025, 5, 1);
            var date2 = new DateTime(2025, 5, 2);
            _manager.TrackSleep(date1, 7.5m);
            _manager.TrackSleep(date2, 8m);
            var report = _manager.GetReport();

            // Assert
            Assert.AreEqual(7.5m, report.SleepTotals[date1]);
            Assert.AreEqual(8m, report.SleepTotals[date2]);
        }

        [TestMethod]
        public void TrackSleep_SameDate_OverwritesPrevious()
        {
            // Arrange
            var date = new DateTime(2025, 5, 3);
            _manager.TrackSleep(date, 6m);
            _manager.TrackSleep(date, 9m);

            // Act
            var report = _manager.GetReport();

            // Assert: в словаре должно быть только последнее значение
            Assert.AreEqual(9m, report.SleepTotals[date]);
            Assert.AreEqual(1, report.SleepTotals.Count,
                "Для одной даты должна быть ровно одна запись.");
        }
    }
}
