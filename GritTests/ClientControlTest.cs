using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoGritLogin;
using GritLibrary;
using System;
using DemoGritLogin.Services;
using GritLibrary.Models;

namespace GritTests
{
    [TestClass]
    public class ClientControlTest
    {
        [TestMethod]
        public void BmiTest()
        {
            string bmiRating;

            double height = 170;
            double weight = 65;
            height = height / 100;
            double bmi = weight / (height * height);

            bmi = Math.Round(bmi, 2);

            double expectedBmi = 22.49;


            if (bmi < 18.5)
            {
                bmiRating = "Underweight";
            }
            else if (bmi < 24.9)
            {
                bmiRating = "Normal Weight";
            }
            else if (bmi < 29.9)
            {
                bmiRating = "Overweight";
            }
            else
            {
                bmiRating = "Obese";
            }

            Assert.AreEqual(expectedBmi, bmi);
            
        }

        [TestMethod]
        public void InvalidDatabaseSaveTest()
        {
            DAO data = new DAO();
            ClientModel client = new ClientModel();
            ProgressModel progress = new ProgressModel();

            data.SaveNewClientAndProgressInfo(client, progress);

            Assert.IsFalse(data.SaveNewClientAndProgressInfo(client, progress));

        }
    }
}
