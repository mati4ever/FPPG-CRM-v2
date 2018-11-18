using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_CRM_v2
{
    public class ConnectionModel
    {
        public int Id { get; set; }

        public PersonModel FirstPerson { get; set; }

        public PersonModel SecondPerson { get; set; }



    }
}
