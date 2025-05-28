using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthTrackerApp.Models;

namespace HealthTrackerApp.Tests
{
    [TestClass]
    public class ReportFormTests
    {
        [TestMethod]
        public void ReportForm_GeneratesCorrectReportText()
        {
            // создаём HealthReport с известными данными
            var acts = new Dictionary<string, decimal> { ["Бег"] = 30m };
            var nuts = new Dictionary<string, decimal> { ["Яблоко"] = 52m };
            var sleeps = new Dictionary<DateTime, decimal> { [new DateTime(2025, 5, 10)] = 8m };
            var report = new HealthReport(acts, nuts, sleeps);

            // создаём форму отчёта
            var form = new ReportForm(report);

            // достаём приватное поле rtbReport
            var field = typeof(ReportForm)
                .GetField("rtbReport", BindingFlags.Instance | BindingFlags.NonPublic);
            var rtb = (RichTextBox)field.GetValue(form);
            var text = rtb.Text;

            // проверяем ключевые строки
            StringAssert.Contains(text, "=== Отчёт о здоровье ===",
                "Должен присутствовать заголовок отчёта.");
            StringAssert.Contains(text, "Активность:", "Должен быть раздел Активность.");
            StringAssert.Contains(text, "  Бег: 30 мин.", "Должна быть строка с бегом.");
            StringAssert.Contains(text, "Питание:", "Должен быть раздел Питание.");
            StringAssert.Contains(text, "  Яблоко: 52 ккал.", "Должна быть строка с яблоком.");
            StringAssert.Contains(text, "Сон:", "Должен быть раздел Сон.");
            StringAssert.Contains(text, "10.05.2025: 8 ч.",
                "Дата должна отформатирована как dd.MM.yyyy.");
        }
    }
}
