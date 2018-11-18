using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_CRM_v2
{
    public class TaskModel
    {
        public int Id { get; set; }

        public PersonModel Person { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime DateOfExecution { get; set; }

        public string Category { get; set; }

        public string Note { get; set; }

        public bool Status { get; set; } = false;

        public string Repetition { get; set; }

        public string StatusDisplay()
        {
            if (Status)
            {
                return "Nieaktywne";
            }
            else
            {
                return "Aktywne";
            }

        }

        public string RepresentByDate
        {
            get
            {
                return $@"  {   DateOfExecution.ToString("yyyy-MM-dd") }    --    { Category }    --   { Person.LastName } { Person.FirstName }    --    { StatusDisplay() } ";
            }
        }

    }
}
