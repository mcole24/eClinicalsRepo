
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
        public eClinicalsController()
        {

        }

        public List<Appointment> GetAllAppointmentReasons()
        {
            return DAL.AppointmentDAL.GetAllAppointmentReasons();
        }

        public  List<Doctor> GetAllDoctorNames()
        {
            return DAL.AppointmentDAL.GetAllDoctorNames();
        }
        public bool CreateAppointment(DateTime appointmentDate, int patientID, int doctorID, int appointmentReasonID)
        {
            return DAL.AppointmentDAL.CreateAppointment(appointmentDate, patientID, doctorID, appointmentReasonID);

        }

        public bool UpdateAppointment(DateTime appointmentDate, int doctorID, int appointmentReasonID, int appointmentID)
        {
            return DAL.AppointmentDAL.UpdateAppointment(appointmentDate, doctorID, appointmentReasonID, appointmentID);
        }


        public bool DeleteAppointment(int appointmentID)
        {
            return DAL.AppointmentDAL.DeleteAppointment(appointmentID);
        }

        public Appointment GetAppointmentByID(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentByID(appointmentID);
        }

        public List<Appointment> GetAllAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllAppointmentsByPatientID(patientID);
        }

        public  List<Appointment> GetAllFutureAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllFutureAppointmentsByPatientID(patientID);
        }

        public  List<Appointment> GetAllPastAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllPastAppointmentsByPatientID(patientID);
        }

        public  List<Appointment> GetAllCurrentDateAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllCurrentDateAppointmentsByPatientID(patientID);
        }

        public AppointmentSummary GetAppointmentSummaryVisitDetails(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummaryVisitDetails(appointmentID);
        }

        public List<AppointmentSummary> GetAppointmentSummarySymptoms(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummarySymptoms(appointmentID);
        }

        public AppointmentSummary GetAppointmentSummaryCheckupResults(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummaryCheckupResults(appointmentID);
        }

        public List<AppointmentSummary> GetAppointmentSummaryDiagnosisResults(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummaryDiagnosisResults(appointmentID);
        }
        public List<AppointmentSummary> GetAppointmentSummaryTestResults(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummaryTestResults(appointmentID);

        }
        public List<RoutineCheck> GetPreviousReadings(int patientID)
        {
            return DAL.VisitDAL.GetPreviousReadings(patientID);
        }

        public List<LabTest> GetAllTests()
        {
            return DAL.LabTestDAL.GetAllTests();
        }

        public List<LabTest> GetTestResults(int patientID)
        {
            return DAL.LabTestDAL.GetTestResults(patientID);
        }

        public bool UpdateResult(int testID, DateTime performedDate, int result)
        {
            return DAL.LabTestDAL.UpdateResult(testID, performedDate, result);
        }

        public  int CreateCheckup(int appointmentID, int nurseID, int systolicBP, int diastolicBP, decimal bodyTemp, int pulse)
        {
            return DAL.VisitDAL.CreateCheckup(appointmentID, nurseID, systolicBP, diastolicBP, bodyTemp, pulse);
        }

        public bool CreateVisitSymptom(int visitID, int symptomID)
        {
            return DAL.VisitDAL.CreateVisitSymptom(visitID, symptomID);
        }

        public  List<Symptom> GetAllSymptoms()
        {
            return DAL.VisitDAL.GetAllSymptoms();
        }

        public List<Diagnosis> GetAllDiagnosis()
        {
            return DAL.VisitDAL.GetAllDiagnosis();
        }

        public static bool addInitialDiagnosis(int visitID, int diagnosisID, int initialDiagnosis)
        {
            return DAL.VisitDAL.addInitialDiagnosis(visitID, diagnosisID, initialDiagnosis);
        }

        public static bool addFinalDiagnosis(int visitID, int diagnosisID, int finalDiagnosis)
        {
            return DAL.VisitDAL.addInitialDiagnosis(visitID, diagnosisID, finalDiagnosis);
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

        public List<Patient> SearchPatientByFirstAndLastName(string fName, string lName)
        {
            return DAL.PatientDAL.SearchPatientByFirstAndLastName(fName, lName);
        }

        public List<Patient> SearchPatientByDOB(DateTime dob)
        {
            return DAL.PatientDAL.SearchPatientByDOB(dob);
        }

        public List<Patient> SearchPatientByLastNameAndDOB(string lName, DateTime dob)
        {
            return DAL.PatientDAL.SearchPatientByLastNameAndDOB(lName, dob);
        }

        public bool UpdatePatient(int contactID, string lastName, string firstName, DateTime DOB, string street, string city, string state,
         string ZIP, string phone, string gender)
        {
            return DAL.PatientDAL.UpdatePatient(contactID, lastName, firstName, DOB, street, city, state, ZIP, phone, gender);
        }
        public bool CreateLogin(int contactID, string username, string password)
        {
            return DAL.PersonDAL.createLogin(contactID, username, password);
        }

        public int CreateContactInfo(string lName, string fName, DateTime dob, string streetAddress, string city, string state, string zip, string phone, string gender, string ssn, int userType)
        {
            return DAL.PersonDAL.createContactInfo(lName, fName, dob, streetAddress, city, state, zip, phone, gender, ssn, userType);
        }

        public bool CheckPassword(string username, string enteredPassword)
        {
            return DAL.PersonDAL.checkPassword(username, enteredPassword);
        }

        public Person GetLoggedInUserDetails(string username, string password)
        {
            return DAL.PersonDAL.GetLoggedInUserDetails(username, password);
        }

        public int GetContactIDWithSsn(string ssn)
        {
            return DAL.PersonDAL.GetContactIDWithSsn(ssn);
        }

        public  Admin GetAdminByID(int contactID)
        {
            return DAL.AdminDAL.GetAdminByID(contactID);
        }

        public static bool CreateAdmin(int contactID)
        {
            return DAL.AdminDAL.CreateAdmin(contactID);
        }

        public List<Report> MostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            return DAL.AdminDAL.MostPerformedTestsDuringDates(startDate, endDate);
        }


    }

}