using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class Doctor : Person
    {
        public int DoctorID { get; set; }

        public string DoctorName { get; set; }
    }
}
