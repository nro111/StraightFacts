using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vote.Models;

namespace Vote.Models
{
    public class DashboardViewModelHolder
    {
        public List<National_Elected_Officials_Model> national_Elected_Officials { get; set; }
        public List<State_Elected_Officials_Model> state_Elected_Officials { get; set; }
        public List<Local_Elected_Officials_Model>local_Elected_Officials { get; set; }
    }
}
