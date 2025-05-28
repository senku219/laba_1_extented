// NutritionDialog.cs
using System.Windows.Forms;

namespace HealthTrackerApp
{
    public partial class NutritionDialog : Form
    {
        public string Food => txtFood.Text;
        public decimal Calories => nudCalories.Value;

        public NutritionDialog()
        {
            InitializeComponent();
        }
    }
}