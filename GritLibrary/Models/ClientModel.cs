using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GritLibrary.Models
{
    public class ClientModel : _BaseUserModel
    {
        public int ClientID { get; set; }       
        public string gender { get; set; }
        public DateTime Date { get; set; }
        public string AssignedCoach { get; set; }


    }
}
