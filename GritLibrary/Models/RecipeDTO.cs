using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGritLogin.Models
{
    public class RecipeDTO
    {
        [System.ComponentModel.Browsable(false)]
        public int ID { get; set; }
        public string Title { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Url{ get; set; }



    }
}
