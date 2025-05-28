using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthTrackerApp.Models;

namespace HealthTrackerApp.Tests
{
    [TestClass]
    public class HealthReportTests
    {
        [TestMethod]
        // проверяем, что изменение исходных словарей, доступно, но никак не меняет заданные исходные значения
        public void HealthReport_ImmutableCopies_AreIndependent()
        {
            // исходные словари
            var act = new Dictionary<string, decimal> { ["Йога"] = 30m };
            var nut = new Dictionary<string, decimal> { ["Суп"] = 200m };
            var slp = new Dictionary<DateTime, decimal> { [DateTime.Today] = 7m };

            // создаём отчёт
            var report = new HealthReport(act, nut, slp);

            // меняем исходные словари
            act["Йога"] = 45m;
            nut["Суп"] = 300m;
            slp[DateTime.Today] = 5m;

            // данные в отчёте не изменились
            Assert.AreEqual(30m, report.ActivityTotals["Йога"],
                "Отчёт должен хранить копии словарей, а не ссылки на внешние объекты.");
            Assert.AreEqual(200m, report.NutritionTotals["Суп"]);
            Assert.AreEqual(7m, report.SleepTotals[DateTime.Today]);
        }
    }
}
