using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GritLibrary.Models
{
    public class ProgressModel
    {

        public int ProgressID { get; set; }
        public int ClientID { get; set; }
        public int CurrentWeight { get; set; }
        public int CurrentHeight { get; set; }
        public string TrainingGoal { get; set; }
        public DateTime CurrentDate { get; set; }
        public float BMI { get; set; }
        public string BmiRating { get; set; }

    }
}
