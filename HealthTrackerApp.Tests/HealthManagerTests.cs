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
            // gеред каждым тестом создаём свежий экземпляр менеджера
            _manager = new HealthManager();
        }

        [TestMethod]
        // проверка корректности внесения записи, дожна появиться активность с указанным временем
        public void TrackActivity_NewType_CreatesEntry()
        {
            
            string type = "Бег";
            decimal minutes = 30m;

            
            _manager.TrackActivity(type, minutes);
            var report = _manager.GetReport();

            // в отчёте должна быть одна запись "Бег" со значением 30
            Assert.IsTrue(report.ActivityTotals.ContainsKey(type),
                "Ожидалось, что тип активности появится в словаре.");
            Assert.AreEqual(minutes, report.ActivityTotals[type],
                "Количество минут должно соответствовать переданному.");
        }

        [TestMethod]
        // проверка того, что при добавлении одной и той же активности суммируются минуты
        public void TrackActivity_SameType_TotalsAdded()
        {
           
            string type = "Велосипед";
            _manager.TrackActivity(type, 20m);
            _manager.TrackActivity(type, 15m);

           
            var report = _manager.GetReport();

            // минуты сложились
            Assert.AreEqual(35m, report.ActivityTotals[type],
                "При добавлении одной и той же активности минуты должны накапливаться.");
        }

        [TestMethod]
        // проверка корректности внесения записи, дожна появиться еда с указанными калориями
        public void TrackNutrition_NewFood_CreatesEntry()
        {
            
            string food = "Яблоко";
            decimal calories = 52m;

            
            _manager.TrackNutrition(food, calories);
            var report = _manager.GetReport();

            // в отчёте должна быть одна запись "яблоко" со значением 52
            Assert.IsTrue(report.NutritionTotals.ContainsKey(food));
            Assert.AreEqual(calories, report.NutritionTotals[food]);
        }

        [TestMethod]
        // проверка того, что при доавблении одной и той же еды, количество калорий суммируется
        public void TrackNutrition_SameFood_TotalsAdded()
        {
            
            _manager.TrackNutrition("Хлеб", 80m);
            _manager.TrackNutrition("Хлеб", 70m);
            var report = _manager.GetReport();

            // калории сложились
            Assert.AreEqual(150m, report.NutritionTotals["Хлеб"]);
        }

        [TestMethod]
        // првоерка того, что записи на разные даты не смешиваются - для каждой своя запись
        public void TrackSleep_DifferentDates_CreatesSeparateEntries()
        {
            
            var date1 = new DateTime(2025, 5, 1);
            var date2 = new DateTime(2025, 5, 2);
            _manager.TrackSleep(date1, 7.5m);
            _manager.TrackSleep(date2, 8m);
            var report = _manager.GetReport();

            
            Assert.AreEqual(7.5m, report.SleepTotals[date1]);
            Assert.AreEqual(8m, report.SleepTotals[date2]);
        }

        [TestMethod]
        // проверка того, что при добавлении двух записей на одну и ту же дату в хранилище попадет только последнее значение
        public void TrackSleep_SameDate_OverwritesPrevious()
        {
           
            var date = new DateTime(2025, 5, 3);
            _manager.TrackSleep(date, 6m);
            _manager.TrackSleep(date, 9m);

           
            var report = _manager.GetReport();

            // в словаре должно быть только последнее значение
            Assert.AreEqual(9m, report.SleepTotals[date]);
            Assert.AreEqual(1, report.SleepTotals.Count,
                "Для одной даты должна быть ровно одна запись.");
        }
    }
}
