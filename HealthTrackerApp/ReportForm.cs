// ReportForm.cs
using System;
using System.Text;
using System.Windows.Forms;
using HealthTrackerApp.Models;

namespace HealthTrackerApp
{
    public partial class ReportForm : Form
    {
        private readonly HealthReport _report;

        public ReportForm(HealthTrackerApp.Models.HealthReport report)
        {
            _report = report;
            InitializeComponent();
            BuildReport();
        }

        private void BuildReport()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=== Отчёт о здоровье ===\n");
            sb.AppendLine("Активность:");
            foreach (var kv in _report.ActivityTotals)
                sb.AppendLine($"  {kv.Key}: {kv.Value} мин.");
            sb.AppendLine("\nПитание:");
            foreach (var kv in _report.NutritionTotals)
                sb.AppendLine($"  {kv.Key}: {kv.Value} ккал.");
            sb.AppendLine("\nСон:");
            foreach (var kv in _report.SleepTotals)
                sb.AppendLine($"  {kv.Key:dd.MM.yyyy}: {kv.Value} ч.");
            rtbReport.Text = sb.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}