using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GritTests
{
 
    [TestClass]
    public class NutritionControlTest
    {
        [TestMethod]
        public void TestCalorieCalculation()
        {
            string getGender = "Male";
            string getTrainingGoal = "Weight Gain";
            decimal getWeight = 68;
            decimal getHeight = 170;
            int age = 24;

            string protein;
            string carbs;
            string fat;
            decimal tdc; //total daily calories 
            decimal weightInPounds = getWeight + (decimal)2.205;

            int proteinGrams;
            int fatGrams;
            int carbsGrams;

            int expectedProteinGrams = 70;
            int expectedFatGrams =35;
            int expectedCarbsGrams =312;

            if (getGender == "Male")
            {
                tdc = ((decimal)13.397 * getWeight) + ((decimal)4.799 * getHeight) - ((decimal)5.677 * age) + (decimal)88.362;
            }
            else
            {
                tdc = ((decimal)9.247 * getWeight) + ((decimal)3.098 * getHeight) - ((decimal)3.098 * age) + (decimal)447.593;
            }

            if (getTrainingGoal == "Weight Loss")
            {
                tdc = tdc - (tdc / 10);
            }
            else
            {
                tdc = tdc + (tdc / 10);
            }

            proteinGrams = (int)weightInPounds;
            int proteinCalories = proteinGrams * 4;
            fatGrams = (int)((int)weightInPounds * 0.5);
            int fatCalories = fatGrams * 9;
            int carbsCalories = (int)(tdc - (fatCalories + proteinCalories));
            carbsGrams = carbsCalories / 4;
            int daily = (int)tdc;

            

            Assert.AreEqual(expectedProteinGrams, proteinGrams);
            Assert.AreEqual(expectedFatGrams, fatGrams);
            Assert.AreEqual(expectedCarbsGrams, carbsGrams);
            
        }

    }
}
