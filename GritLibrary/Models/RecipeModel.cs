using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGritLogin.Models
{
    class RecipeModel
    {

    }
    public class Meal
    {
        public int ID { get; set; }
        public string ImageType { get; set; }
        public string Title { get; set; }
        public int ReadyInMinutes { get; set; }
        public int Servings { get; set; }
        public string SourceUrl { get; set; }
    }

    public class Nutrients
    {
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
    }

    public class Root
    {
        public List<Meal> Meals { get; set; }
        public Nutrients Nutrients { get; set; }
       
    }

    public class RecipeRoot
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
    }


}
