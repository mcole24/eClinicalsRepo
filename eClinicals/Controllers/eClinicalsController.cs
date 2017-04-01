
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.DAL;
using eClinicals.Model;

namespace eClinicals.Controllers
{
    class eClinicalsController
    {

        public bool CreateAppointment(DateTime appointmentDate, int patientID, int doctorID)
        {
            return DAL.AppointmentDAL.CreateAppointment(appointmentDate, patientID, doctorID);

        }

        public bool DeleteAppointment(int appointmentID)
        {
            return DAL.AppointmentDAL.DeleteAppointment(appointmentID);
        }

        public Appointment GetAppointmentByID(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentByID(appointmentID);
        }

        public bool CreateNurse(int contactID)
        {
            return DAL.NurseDAL.CreateNurse(contactID);
        }

        public bool DeleteNurse(int nurseID)
        {
            return DAL.NurseDAL.DeleteNurse(nurseID);
        }

        public Nurse GetNurseByID(int contactID)
        {
            return DAL.NurseDAL.GetNurseByID(contactID);
        }


    }

   

}
