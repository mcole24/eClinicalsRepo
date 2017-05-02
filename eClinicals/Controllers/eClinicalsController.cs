
using eClinicals.Model;
using System;
using System.Collections.Generic;

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

        public List<Doctor> GetAllDoctorNames()
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
        public List<Appointment> GetAllAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllAppointmentsByPatientID(patientID);
        }

        public List<Appointment> GetAllFutureAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllFutureAppointmentsByPatientID(patientID);
        }

        public List<Appointment> GetAllPastAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllPastAppointmentsByPatientID(patientID);
        }

        public List<Appointment> GetAllCurrentDateAppointmentsByPatientID(int patientID)
        {
            return DAL.AppointmentDAL.GetAllCurrentDateAppointmentsByPatientID(patientID);
        }



        public List<AppointmentSummaryVisitDetails> GetAppointmentSummaryVisitDetails(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummaryVisitDetails(appointmentID);
        }

        public List<AppointmentSummarySymptoms> GetAppointmentSummarySymptoms(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummarySymptoms(appointmentID);
        }

        public List <AppointmentSummaryCheckupResults> GetAppointmentSummaryCheckupResults(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummaryCheckupResults(appointmentID);
        }

        public List<AppointmentSummaryDiagnosisResults> GetAppointmentSummaryDiagnosisResults(int appointmentID)
        {
            return DAL.AppointmentDAL.GetAppointmentSummaryDiagnosisResults(appointmentID);
        }
        public List<AppointmentSummaryTestResults> GetAppointmentSummaryTestResults(int appointmentID)
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

        public int OrderTest(TestOrder testOrdered, int visitID)
        {
            return DAL.TestOrderDAL.OrderTest(testOrdered, visitID);
        }

        public TestOrder GetTestByID(int testID)
        {
            return DAL.TestOrderDAL.GetTestByID(testID);
        }


        public bool UpdateResult(int testID, DateTime performedDate, int result)
        {
            return DAL.LabTestDAL.UpdateResult(testID, performedDate, result);
        }

        public Visit CreateCheckup(int appointmentID, int nurseID, int systolicBP, int diastolicBP, decimal bodyTemp, int pulse, List<int> symptomList)
        {
            return DAL.VisitDAL.CreateCheckup(appointmentID, nurseID, systolicBP, diastolicBP, bodyTemp, pulse, symptomList);
        }

        public List<Symptom> GetAllSymptoms()
        {
            return DAL.VisitDAL.GetAllSymptoms();
        }

        public List<Diagnosis> GetAllDiagnosis()
        {
            return DAL.VisitDAL.GetAllDiagnosis();
        }

        public int addInitialDiagnosis(int visitID, int diagnosisID, int initialDiagnosis)
        {
            return DAL.VisitDAL.addInitialDiagnosis(visitID, diagnosisID, initialDiagnosis);
        }

        public int addFinalDiagnosis(int visitID, int diagnosisID, int finalDiagnosis)
        {
            return DAL.VisitDAL.addInitialDiagnosis(visitID, diagnosisID, finalDiagnosis);
        }
        public static bool CreateAdmin(int contactID)
        {
            return DAL.AdminDAL.CreateAdmin(contactID);
        }

        public bool CreateNurse(int contactID)
        {
            return DAL.NurseDAL.CreateNurse(contactID);
        }

        public Nurse GetNurseByID(int contactID)
        {
            return DAL.NurseDAL.GetNurseByID(contactID);
        }

        public bool CreatePatient(int contactID)
        {
            return DAL.PatientDAL.CreatePatient(contactID);
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

        public List<Report> MostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            return DAL.AdminDAL.MostPerformedTestsDuringDates(startDate, endDate);
        }


    }

}