using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthTrackerApp;

namespace HealthTrackerApp.Tests
{
    [TestClass]
    public class DialogTests
    {
        [TestMethod]
        public void ActivityDialog_DefaultValues_AreEmptyAndZero()
        {
            var dlg = new ActivityDialog();

           
            Assert.AreEqual(string.Empty, dlg.ActivityType,
                "По умолчанию тип активности должен быть пустой строкой.");
            Assert.AreEqual(0m, dlg.Minutes,
                "По умолчанию число минут должно быть 0.");
        }

        [TestMethod]
        public void NutritionDialog_DefaultValues_AreEmptyAndZero()
        {
            
            var dlg = new NutritionDialog();

            
            Assert.AreEqual(string.Empty, dlg.Food,
                "По умолчанию название продукта должно быть пустым.");
            Assert.AreEqual(0m, dlg.Calories,
                "По умолчанию калорийность должна быть 0.");
        }
    }
}
