using System;
using System.Windows.Forms;
using HealthTrackerApp.Models;

namespace HealthTrackerApp
{
    public partial class HealthForm : Form
    {
        private readonly HealthManager _manager = new HealthManager();

        public HealthForm()
        {
            InitializeComponent();
        }

        private void btnTrackActivity_Click(object sender, EventArgs e)
        {
            using (var dlg = new ActivityDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _manager.TrackActivity(dlg.ActivityType, dlg.Minutes);
                }
            }
        }

        private void btnTrackNutrition_Click(object sender, EventArgs e)
        {
            using (var dlg = new NutritionDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _manager.TrackNutrition(dlg.Food, dlg.Calories);
                }
            }
        }

        private void btnTrackSleep_Click(object sender, EventArgs e)
        {
            using (var dlg = new SleepDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _manager.TrackSleep(dlg.DateOfSleep, dlg.Hours);
                }
            }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            var report = _manager.GetReport();
            using (var frm = new ReportForm(report))
            {
                frm.ShowDialog();
            }
        }
    }
}
