// ActivityDialog.cs
using System.Windows.Forms;

namespace HealthTrackerApp
{
    public partial class ActivityDialog : Form
    {
        public string ActivityType => txtType.Text;
        public decimal Minutes => nudMinutes.Value;

        public ActivityDialog()
        {
            InitializeComponent();
        }
    }
}