using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class Admin
    {
        public string Address { get;  set; }
        public int AdminID { get;  set; }
        public string City { get;  set; }
        public string Zip { get; set; }
        public int ContactID { get;  set; }
        public DateTime Dob { get;  set; }
        public string FirstName { get;  set; }
        public string Gender { get;  set; }
        public string LastName { get;  set; }
        public string Phone { get;  set; }
        public string Ssn { get;  set; }
        public string State { get;  set; }
        public string UserName { get;  set; }
    }
}
