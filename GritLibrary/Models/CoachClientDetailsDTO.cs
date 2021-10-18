using System;
using System.Collections.Generic;
using System.Text;

namespace GritLibrary.Models
{
    public class CoachClientDetailsDTO
    {
        public string ClientName { get; set; }
        public string TrainingGoal { get; set; }
        public int InitialWeight { get; set; }
        public int CurrentWeight { get; set; }
        public int ProgressCount { get; set; }

    }
}
