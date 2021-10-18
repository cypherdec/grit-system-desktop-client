using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GritLibrary.Models
{
    public class FoodModel
    {

        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Carbs { get; set; }
        public float Calories { get; set; }

        public string GetFoodName()
        {
            return FoodName;
        }

    }
}
