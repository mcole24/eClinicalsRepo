using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using eClinicals.Model;

namespace eClinicals.DAL
{
    class AppointmentDAL
    {

        public static bool CreateAppointment(DateTime appointmentDate, int patientID, int doctorID, int appointmentReasonID)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string insertStmt = "INSERT INTO appointment (appointmentDate, patientID, doctorID, appointmentReasonID) "
                        + "VALUES (@appDate, @patientID, @doctorID, @appointmentReasonID)";
                       
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@patientID", patientID);
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);
                        cmd.Parameters.AddWithValue("@appointmentReasonID", appointmentReasonID);
                        cmd.ExecuteNonQuery();
                        
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

       
        public static bool UpdateAppointment(DateTime appointmentDate, int doctorID, int appointmentReasonID, int appointmentID)
        {
            bool isUpdated = false;
            string updateStmt = "UPDATE appointment SET appointmentDate = @appointmentDate, doctorID = @doctorID, appointmentReasonID = @appointmentReasonID "
            + "WHERE appointmentID = @appointmentID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);
                        cmd.Parameters.AddWithValue("@appointmentReasonID", appointmentReasonID);
                        cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        isUpdated = (cmd.ExecuteNonQuery() > 0);
                    }
                    connect.Close();
                }
                return isUpdated;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    

        public static bool DeleteAppointment(int appointmentID)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string delStmt = "DELETE FROM appointment WHERE appointmentID = @id";
                    using (SqlCommand cmd = new SqlCommand(delStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", appointmentID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }




        public static Appointment GetAppointmentByID(int appointmentID)
        {
            Appointment appointment = new Appointment();
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string selStmt = "SELECT * FROM appointment WHERE appointmentID = @appointmentID";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        connect.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                appointment.AppointmentDate = (DateTime)reader["appointmentDate"];
                                appointment.PatientID = (int)reader["patientID"];
                                appointment.DoctorID = (int)reader["doctorID"];
                                appointment.AppointmentReasonID = (int)reader["appointmentReasonID"];
                            }
                        }
                        connect.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return appointment;
        }

        public static List<Appointment> GetAllAppointmentsByPatientID(int patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            string selectStatement = "SELECT patient.patientID, doctor.doctorID, appointment.appointmentID, appointment.appointmentReasonID, appointmentDate, appointmentReason, contact.lName "
                + "FROM Patient LEFT JOIN Appointment ON Patient.patientID = Appointment.PatientID " 
                + "JOIN appointment_reason ON appointment.appointmentReasonID = appointment_reason.appointmentReasonID "
                + "JOIN doctor ON appointment.doctorID = doctor.doctorID "
                + "JOIN contact ON doctor.contactID = contact.contactID "
                + "WHERE Patient.patientID = @patientID";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientID", patientID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                
                                Appointment appointment = new Appointment();
                                appointment.PatientID = (int)reader["patientID"];
                                appointment.DoctorID = (int)reader["doctorID"];
                                appointment.AppointmentID = (int)reader["appointmentID"];
                                appointment.AppointmentDate = (DateTime)reader["appointmentDate"];
                                appointment.AppointmentReasonID = (int)reader["appointmentReasonID"];
                                appointment.AppointmentReason = reader["appointmentReason"].ToString();
                                appointment.AppointmentDoctor = reader["lName"].ToString();
                                appointmentList.Add(appointment);
                            }
                            reader.Close();
                        }

                    }
                    connection.Close();
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return appointmentList;
        }

        public static List<Appointment> GetAllFutureAppointmentsByPatientID(int patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            string selectStatement = "SELECT patient.patientID, doctor.doctorID, appointment.appointmentID, appointment.appointmentReasonID, appointmentDate, appointmentReason, contact.lName "
                + "FROM Patient LEFT JOIN Appointment ON Patient.patientID = Appointment.PatientID "
                + "JOIN appointment_reason ON appointment.appointmentReasonID = appointment_reason.appointmentReasonID "
                + "JOIN doctor ON appointment.doctorID = doctor.doctorID "
                + "JOIN contact ON doctor.contactID = contact.contactID "
                + "WHERE Patient.patientID = @patientID AND appointmentDate > GETDATE()";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientID", patientID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Appointment appointment = new Appointment();
                                appointment.PatientID = (int)reader["patientID"];
                                appointment.DoctorID = (int)reader["doctorID"];
                                appointment.AppointmentID = (int)reader["appointmentID"];
                                appointment.AppointmentDate = (DateTime)reader["appointmentDate"];
                                appointment.AppointmentReasonID = (int)reader["appointmentReasonID"];
                                appointment.AppointmentReason = reader["appointmentReason"].ToString();
                                appointment.AppointmentDoctor = reader["lName"].ToString();
                                appointmentList.Add(appointment);
                            }
                            reader.Close();
                        }

                    }
                    connection.Close();
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return appointmentList;
        }

        public static List<Appointment> GetAllPastAppointmentsByPatientID(int patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            string selectStatement = "SELECT patient.patientID, doctor.doctorID, appointment.appointmentID, appointment.appointmentReasonID, appointmentDate, appointmentReason, contact.lName "
                + "FROM Patient LEFT JOIN Appointment ON Patient.patientID = Appointment.PatientID "
                + "JOIN appointment_reason ON appointment.appointmentReasonID = appointment_reason.appointmentReasonID "
                + "JOIN doctor ON appointment.doctorID = doctor.doctorID "
                + "JOIN contact ON doctor.contactID = contact.contactID "
                + "WHERE Patient.patientID = @patientID AND appointmentDate < GETDATE()";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientID", patientID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Appointment appointment = new Appointment();
                                appointment.PatientID = (int)reader["patientID"];
                                appointment.DoctorID = (int)reader["doctorID"];
                                appointment.AppointmentID = (int)reader["appointmentID"];
                                appointment.AppointmentDate = (DateTime)reader["appointmentDate"];
                                appointment.AppointmentReasonID = (int)reader["appointmentReasonID"];
                                appointment.AppointmentReason = reader["appointmentReason"].ToString();
                                appointment.AppointmentDoctor = reader["lName"].ToString();
                                appointmentList.Add(appointment);
                            }
                            reader.Close();
                        }

                    }
                    connection.Close();
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return appointmentList;
        }

        public static List<Appointment> GetAllCurrentDateAppointmentsByPatientID(int patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            //   string today = "2017-04-16";
             string today = DateTime.Now.ToString("yyyy-MM-dd");
            string selectStatement = "SELECT patient.patientID, doctor.doctorID, appointment.appointmentID, appointment.appointmentReasonID, appointmentDate, appointmentReason, contact.lName "
                + "FROM Patient LEFT JOIN Appointment ON Patient.patientID = Appointment.PatientID "
                + "JOIN appointment_reason ON appointment.appointmentReasonID = appointment_reason.appointmentReasonID "
                + "JOIN doctor ON appointment.doctorID = doctor.doctorID "
                + "JOIN contact ON doctor.contactID = contact.contactID "
                + "WHERE Patient.patientID = @patientID AND  CONVERT(VARCHAR(25), appointmentDate, 126) LIKE @today+'%'";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientID", patientID);
                       selectCommand.Parameters.AddWithValue("@today", today);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Appointment appointment = new Appointment();
                                appointment.PatientID = (int)reader["patientID"];
                                appointment.DoctorID = (int)reader["doctorID"];
                                appointment.AppointmentID = (int)reader["appointmentID"];
                                appointment.AppointmentDate = (DateTime)reader["appointmentDate"];
                                appointment.AppointmentReasonID = (int)reader["appointmentReasonID"];
                                appointment.AppointmentReason = reader["appointmentReason"].ToString();
                                appointment.AppointmentDoctor = reader["lName"].ToString();
                                appointmentList.Add(appointment);
                            }
                            reader.Close();
                        }

                    }
                    connection.Close();
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return appointmentList;
        }

        public static List<Appointment> GetAllAppointmentReasons()
        {
            List<Appointment> appointmentReasonList = new List<Appointment>();
            string selectStatement = "SELECT * FROM appointment_reason";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Appointment appointmentReason = new Appointment();
                                appointmentReason.AppointmentReasonID = (int)reader["appointmentReasonID"];
                                appointmentReason.AppointmentReason = reader["appointmentReason"].ToString();
                                appointmentReasonList.Add(appointmentReason);
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return appointmentReasonList;
        }

        public static List<Doctor> GetAllDoctorNames()
        {
            List<Doctor> doctorNameList = new List<Doctor>();
            string selectStatement = "SELECT doctorID, lName "
            + "FROM doctor JOIN contact ON doctor.contactID = contact.contactID";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Doctor doctorName = new Doctor();
                                doctorName.DoctorID = (int)reader["doctorID"];
                                doctorName.DoctorName = reader["lName"].ToString();
                                doctorNameList.Add(doctorName);
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return doctorNameList;
        }


        public static AppointmentSummary GetAppointmentSummaryVisitDetails(int appointmentID)
        {
            AppointmentSummary visitDetails = new AppointmentSummary();
                string selStmt = "SELECT visit.visitID, visitTime, lName, appointmentReason "
                        + "FROM visit "
                        + "JOIN appointment ON visit.appointmentID = appointment.appointmentID "
                        + "JOIN appointment_reason ON appointment.appointmentReasonID = appointment_reason.appointmentReasonID "
                        + "JOIN doctor ON appointment.doctorID = doctor.doctorID "
                        + "JOIN contact ON doctor.contactID = contact.contactID "
                        + "WHERE visit.appointmentID = @appointmentID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appointmentID", appointmentID);    
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                visitDetails.VisitID = (int)reader["visitID"];
                                visitDetails.VisitDate = (DateTime)reader["appointmentDate"];
                                visitDetails.Doctor = reader["lName"].ToString();
                                visitDetails.ReasonForVisit = reader["appointmentReason"].ToString();
                            }
                            reader.Close();
                        }
                        connect.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return visitDetails;
        }


        public static List<AppointmentSummary> GetAppointmentSummarySymptoms(int appointmentID)
        {
            List<AppointmentSummary> visitSymptomsList = new List<AppointmentSummary>();
            string selStmt = "SELECT symptomType "
                      + "FROM visit "
                      + "JOIN visit_symptom ON visit.visitID = visit_symptom.visitID "
                      + "JOIN symptom ON visit_symptom.symptomID = symptom.symptomID "
                      + "WHERE visit.appointmentID = @appointmentID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AppointmentSummary visitSymptom = new AppointmentSummary();
                                visitSymptom.Symptoms = reader["symptomType"].ToString();
                                visitSymptomsList.Add(visitSymptom);
                            }
                            reader.Close();
                        }
                        connect.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return visitSymptomsList;
        }


        public static AppointmentSummary GetAppointmentSummaryCheckupResults(int appointmentID)
        {
            AppointmentSummary visit = new AppointmentSummary();
            string selStmt = "SELECT systolicBP, diastolicBP, bodyTemperature, pulse "
                + "FROM visit "
                + "WHERE visit.appointmentID = @appointmentID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                visit.SystolicBPReading = (int)reader["systolicBP"];
                                visit.DiastolicBPReading = (int)reader["diastolicBP"];
                                visit.BodyTemperatureReading = (decimal)reader["bodyTemperature"];
                                visit.PulseReading = (int)reader["pulse"];
                            }
                            reader.Close();
                        }
                        connect.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return visit;
        }

        public static List<AppointmentSummary> GetAppointmentSummaryDiagnosisResults(int appointmentID)
        {
            List<AppointmentSummary> visitDiagnosisList = new List<AppointmentSummary>();
            string selStmt = "SELECT visit.visitID, diagnosisType AS initialDiagnosis "
                          + "FROM visit "
                          + "JOIN visit_has_diagnosis ON visit.visitID = visit_has_diagnosis.visitID "
                          + "JOIN diagnosis ON visit_has_diagnosis.diagnosisID = diagnosis.diagnosisID "
                          + "WHERE appointmentID = @appointmentID AND initialDiagnosis = 1"
                          +
                  "SELECT visit.visitID, diagnosisType AS finalDiagnosis "
                 + " FROM visit "
                 + "JOIN visit_has_diagnosis ON visit.visitID = visit_has_diagnosis.visitID "
                 + "JOIN diagnosis ON visit_has_diagnosis.diagnosisID = diagnosis.diagnosisID "
                 + "WHERE appointmentID = @appointmentID AND finalDiagnosis = 1";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                       cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AppointmentSummary visitDiagnosis = new AppointmentSummary();
                                visitDiagnosis.InitialDiagnosis = reader["initialDiagnosis"].ToString();
                                visitDiagnosis.FinalDiagnosis = reader["finalDiagnosis"].ToString();
                                visitDiagnosisList.Add(visitDiagnosis);
                            }
                            reader.Close();
                        }
                        connect.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return visitDiagnosisList;
        }

        public static List<AppointmentSummary> GetAppointmentSummaryTestResults(int appointmentID)
        {
            List<AppointmentSummary> visitTestResultList = new List<AppointmentSummary>();
            string selStmt = "SELECT testType, result "
           + "FROM visit "
           + "JOIN visit_lab_test ON visit.visitID = visit_lab_test.visitID "
           + "JOIN lab_test ON visit_lab_test.testCode = lab_test.testCode "
           + "WHERE appointmentID = @appointmentID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                       cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AppointmentSummary visitTestResult = new AppointmentSummary();
                                visitTestResult.TestName = reader["testType"].ToString();
                                visitTestResult.ResultRecorded = (bool)reader["result"];
                                if (visitTestResult.ResultRecorded == true)
                                {
                                    visitTestResult.TestResult = "positive";
                                }
                                else
                                {
                                    visitTestResult.TestResult = "negative";
                                }
                                visitTestResultList.Add(visitTestResult);
                            }
                            reader.Close();
                        }
                        connect.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return visitTestResultList;
        }



    }
}
