// SleepDialog.cs
using System;
using System.Windows.Forms;

namespace HealthTrackerApp
{
    public partial class SleepDialog : Form
    {
        public DateTime DateOfSleep => dtpDateOfSleep.Value.Date;
        public decimal Hours => nudHours.Value;

        public SleepDialog()
        {
            InitializeComponent();
        }
    }
}