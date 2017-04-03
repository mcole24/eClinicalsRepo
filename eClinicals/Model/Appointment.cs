using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class Appointment
    {

        public int AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }

        public string AppointmentDoctor { get; set; }

        public string AppointmentReason { get; set; }

        // May need to remove the below properties later

        public int PatientID { get; set; }
        public int DoctorID { get; set; }

    }
}
