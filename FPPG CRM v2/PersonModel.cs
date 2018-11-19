using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_CRM_v2
{
    public class PersonModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string PersonalIdNumber { get; set; }

        public string PESEL { get; set; }

        public string Note { get; set; }

        public string RepresentByLastName
        {
            get
            {
               return  $@"{ LastName }  { FirstName }    --    { PhoneNumber }    --    { EmailAddress }";
            }
        }

        public string RepresentByID
        {
            get
            {
                return $@"ID: {Id}    --    { LastName } { FirstName }    --    { PhoneNumber }    --    { EmailAddress }";
            }
        }

        public string RepresentByLastNameShort
        {
            get
            {
                return $@"{ LastName }  { FirstName }";
            }
        }

    }
}
