
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
        public eClinicalsController() {

        }
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

        public bool CreatePatient(int contactID)
        {
            return DAL.PatientDAL.CreatePatient(contactID);
        }

        public bool DeletePatient(int contactID)
        {
            return DAL.PatientDAL.DeletePatient(contactID);
        }

        public Patient GetPatientByID(int contactID)
        {
            return DAL.PatientDAL.GetPatientByID(contactID);
        }

        public bool CreateLogin(int contactID, string username, string password)
        {
            return DAL.PersonDAL.createLogin(contactID, username, password);
        }

        public bool CreateContactInfo(string lName, string fName, DateTime dob, string streetAddress, string city, string state, string zip, string phone, string gender, string ssn, int userType)
        {
            return DAL.PersonDAL.createContactInfo(lName, fName, dob, streetAddress, city, state, zip, phone, gender, ssn, userType);
        }

        public bool CheckPassword(string username, string enteredPassword)
        {
            return DAL.PersonDAL.checkPassword(username, enteredPassword);
        }

    }

}
